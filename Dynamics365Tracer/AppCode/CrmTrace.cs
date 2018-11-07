using System.IO;

namespace Dynamics365Tracer.AppCode
{
    /// <summary>
    /// This class represents an object that can deal with trace settings
    /// </summary>
    internal class CrmTrace
    {
        #region Constants

        /// <summary>
        /// Path to CRM registrey keys
        /// </summary>
        private const string CrmRegistryPath = @"Software\Microsoft\MSCRM";

        #endregion Constants

        #region Constructor

        /// <summary>
        /// Initializes a new instance of class CrmTrace
        /// </summary>
        public CrmTrace()
        {
            // Retrieve current registry keys for trace
            TraceEnabled = RegistryHelper.EvaluateOption("TraceEnabled", CrmRegistryPath);
            TraceCallStack = RegistryHelper.EvaluateOption("TraceCallStack", CrmRegistryPath);
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// If you use a value of 0, the call stack is not included in the trace
        /// file. If you use a value of 1, the call stack is included in the trace
        /// file.
        /// </summary>
        public bool TraceCallStack { get; set; }

        /// <summary>
        /// If you use a value of 0, tracing is disabled. If you use a value of
        /// 1, tracing is enabled.
        /// </summary>
        public bool TraceEnabled { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Apply current instance properties to trace registry keys
        /// </summary>
        public void ApplyChanges()
        {
            int traceRefresh = RegistryHelper.EvaluateInteger("TraceRefresh", CrmRegistryPath);

            if (traceRefresh < 100)
                traceRefresh += 1;
            else
                traceRefresh = 1;

            RegistryHelper.SetOption(CrmRegistryPath, "TraceCallStack", TraceCallStack);
            RegistryHelper.SetOption(CrmRegistryPath, "TraceEnabled", TraceEnabled);
            RegistryHelper.SetInteger(CrmRegistryPath, "TraceRefresh", traceRefresh);
        }

        internal static string GetTraceFolderPath()
        {
            string tracePath = RegistryHelper.EvaluateString("TraceDirectory", CrmRegistryPath);

            if (tracePath == null)
            {
                string installPath = RegistryHelper.EvaluateString("CRM_Server_InstallDir", CrmRegistryPath);

                tracePath = Path.Combine(installPath, "Trace");
            }

            return tracePath;
        }

        #endregion Methods
    }
}