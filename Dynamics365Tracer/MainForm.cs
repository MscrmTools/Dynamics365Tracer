using Dynamics365Tracer.AppCode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Dynamics365Tracer
{
    public partial class MainForm : Form
    {
        private readonly Assembly currentAssembly;
        private readonly CrmTrace trace;

        public MainForm()
        {
            InitializeComponent();

            currentAssembly = Assembly.GetExecutingAssembly();

            try
            {
                tcMain.Enabled = false;

                trace = new CrmTrace();
                CheckStatus();
            }
            catch (NotCrmWebServerException)
            {
                tcMain.TabPages.Remove(tpDevErrors);
            }
            catch (NotCrmServerException)
            {
                pnlNotLocal.Visible = true;
            }
            finally
            {
                tcMain.Enabled = true;
            }
        }

        #region Events

        private void btn_devErrors_status_Click(object sender, EventArgs e)
        {
            try
            {
                DevelopmentErrors de = new DevelopmentErrors();

                if (btn_devErrors_status.Text == @"Turn DevErrors Off")
                {
                    de.SetStatus(false);
                }
                else if (btn_devErrors_status.Text == @"Turn DevErrors On")
                {
                    de.SetStatus(true);
                }

                // Refresh the current status to see if the change worked or not...
                if (de.GetStatus())
                {
                    using (Stream myStream =
                        currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_green.png"))
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        btn_devErrors_status.Image = new Bitmap(myStream);
                    }

                    btn_devErrors_status.Text = @"Turn DevErrors Off";
                }
                else
                {
                    using (Stream myStream =
                        currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_red.png"))
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        btn_devErrors_status.Image = new Bitmap(myStream);
                    }

                    btn_devErrors_status.Text = @"Turn DevErrors On";
                }
            }
            catch (NotCrmWebServerException)
            {
                tpDevErrors.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(this,
                    @"Error while updating devErrors settings: " + error.Message,
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_trace_cleandirectory_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> filesNotDeleted = new List<string>();

                // Retrieving files in the specified trace directory
                DirectoryInfo di = new DirectoryInfo(CrmTrace.GetTraceFolderPath());
                foreach (FileInfo fi in di.GetFiles())
                {
                    try
                    {
                        File.Delete(fi.FullName);
                    }
                    catch
                    {
                        filesNotDeleted.Add(fi.Name);
                    }
                }

                // Displaying files not deleted because they are still in use
                // by some Crm service
                if (filesNotDeleted.Count > 0)
                {
                    string message = "The following files where not deleted because they are locked by Dynamics 365 services:\r\n" + string.Join("\r\n", filesNotDeleted);
                    MessageBox.Show(this, message, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(this, @"Trace directory cleaned!", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, @"Error while cleaning trace directory: " + error.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_trace_opendirectory_Click(object sender, EventArgs e)
        {
            try
            {
                // Opens explorer.exe to the trace directory
                Process prc = new Process { StartInfo = { FileName = CrmTrace.GetTraceFolderPath() } };
                prc.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(this, @"Error while opening trace directory: " + error.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_trace_status_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_trace_status.Text == @"Enable trace")
                {
                    // Saves settings
                    trace.TraceEnabled = true;
                    trace.TraceCallStack = cb_trace_callstack.Checked;

                    // Saves settings
                    trace.ApplyChanges();

                    // Updates button label and icon
                    btn_trace_status.Text = @"Disable trace";
                    using (Stream myStream = currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_green.png"))
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        btn_trace_status.Image = new Bitmap(myStream);
                    }

                    // Disables other groupboxes
                    btn_trace_cleandirectory.Enabled = false;
                    btn_trace_zipfiles.Enabled = false;
                }
                else
                {
                    // Stops trace
                    trace.TraceEnabled = false;

                    // Saves settings
                    trace.ApplyChanges();

                    // Updates button label and icon
                    btn_trace_status.Text = @"Enable trace";
                    using (Stream myStream = currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_red.png"))
                    {
                        // ReSharper disable once AssignNullToNotNullAttribute
                        btn_trace_status.Image = new Bitmap(myStream);
                    }

                    // Enables other groupboxes
                    btn_trace_cleandirectory.Enabled = true;
                    btn_trace_zipfiles.Enabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $@"An error occured while setting the trace on: {error.Message}

Try to restart this application with elevated privileges", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_trace_zipfiles_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = @"Archive file (*.zip)| *.zip",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ZipManager zManager = new ZipManager();
                    zManager.CompressFolder(CrmTrace.GetTraceFolderPath(), saveFileDialog.FileName);

                    MessageBox.Show(this, @"Zip file created successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(this,
                        @"Error while creating zip file: " + error.Message,
                        @"Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_level_trace.SelectedIndex = 0;
        }

        #endregion Events

        private void CheckStatus()
        {
            btn_trace_status.Text = @"Unknown status";
            btn_devErrors_status.Text = @"Unknown status";

            FillTraceControls();
            FillDevErrorsControls();
        }

        /// <summary>
        /// Fills controls related to Dev errors
        /// </summary>
        private void FillDevErrorsControls()
        {
            DevelopmentErrors de = new DevelopmentErrors();

            if (de.GetStatus())
            {
                using (Stream myStream = currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_green.png"))
                {
                    btn_devErrors_status.Image = new Bitmap(myStream);
                }

                btn_devErrors_status.Text = @"Turn DevErrors Off";
            }
            else
            {
                using (Stream myStream = currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_red.png"))
                {
                    btn_devErrors_status.Image = new Bitmap(myStream);
                }

                btn_devErrors_status.Text = @"Turn DevErrors On";
            }
        }

        /// <summary>
        /// Fills controls related to Crm trace
        /// </summary>
        private void FillTraceControls()
        {
            cb_trace_callstack.Checked = trace.TraceCallStack;

            if (trace.TraceEnabled)
            {
                btn_trace_status.Text = @"Disable trace";

                using (Stream myStream = currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_green.png"))
                {
                    btn_trace_status.Image = new Bitmap(myStream);
                }

                btn_trace_cleandirectory.Enabled = false;
                btn_trace_zipfiles.Enabled = false;
            }
            else
            {
                btn_trace_status.Text = @"Enable trace";

                using (Stream myStream = currentAssembly.GetManifestResourceStream("Dynamics365Tracer.Images.bullet_red.png"))
                {
                    btn_trace_status.Image = new Bitmap(myStream);
                }
            }
        }
    }
}