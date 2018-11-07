using System;
using System.IO;
using System.Xml;

namespace Dynamics365Tracer.AppCode
{
    /// <summary>
    /// This class helps to manage the DevErrors flag of Microsoft Dynamics CRM
    /// 2011 web application
    /// </summary>
    internal class DevelopmentErrors
    {
        #region Variables

        /// <summary>
        /// Web.Config document data
        /// </summary>
        private XmlDocument webConfigDocument;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of class DevelopmentErrors
        /// </summary>
        public DevelopmentErrors()
        {
            LoadWebConfigDocument();
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Gets the DevErrors flag status
        /// </summary>
        /// <returns>Indicates if DevErrors flag is "On"</returns>
        internal bool GetStatus()
        {
            return GetDevErrorsNode().Attributes["value"].Value == "On";
        }

        /// <summary>
        /// Sets the DevErrors flag status
        /// </summary>
        /// <param name="isActive">Indicates if DevErrors flag is "On"</param>
        internal void SetStatus(bool isActive)
        {
            GetDevErrorsNode().Attributes["value"].Value = isActive ? "On" : "Off";

            webConfigDocument.Save(GetWebConfigDirectoryPath() + @"\Web.Config");
        }

        /// <summary>
        /// Gets the XmlNode representation of DevErrors flag
        /// </summary>
        /// <returns>DevErrors Xml node</returns>
        private XmlNode GetDevErrorsNode()
        {
            XmlNode devErrorsNode = webConfigDocument.SelectSingleNode("//add[@key='DevErrors']");

            if (devErrorsNode?.Attributes?["value"] == null)
                throw new Exception("Invalid web.config! It does not contain DevErrors flag");

            return devErrorsNode;
        }

        /// <summary>
        /// Gets the local or network path for the web.config directory
        /// </summary>
        /// <returns></returns>
        private string GetWebConfigDirectoryPath()
        {
            return RegistryHelper.EvaluateString("WebSitePath", @"Software\Microsoft\MSCRM");
        }

        /// <summary>
        /// Loads the web.config file for the target server
        /// </summary>
        private void LoadWebConfigDocument()
        {
            string webSitePath = GetWebConfigDirectoryPath();

            if (webSitePath == null)
                throw new NotCrmWebServerException();

            if (!Directory.Exists(webSitePath))
                throw new NotCrmWebServerException();

            webConfigDocument = new XmlDocument();
            webConfigDocument.Load(webSitePath + @"\Web.Config");
        }

        #endregion Methods
    }
}