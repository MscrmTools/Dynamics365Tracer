namespace Dynamics365Tracer
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbPlatformTracing = new System.Windows.Forms.TabPage();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.gb_trace_actions = new System.Windows.Forms.GroupBox();
            this.btn_trace_cleandirectory = new System.Windows.Forms.Button();
            this.btn_trace_opendirectory = new System.Windows.Forms.Button();
            this.btn_trace_zipfiles = new System.Windows.Forms.Button();
            this.gb_trace_status = new System.Windows.Forms.GroupBox();
            this.btn_trace_status = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lbl_trace_callstack = new System.Windows.Forms.Label();
            this.cb_trace_callstack = new System.Windows.Forms.CheckBox();
            this.lbl_trace_level = new System.Windows.Forms.Label();
            this.cbb_level_trace = new System.Windows.Forms.ComboBox();
            this.pnlInfoTracing = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpDevErrors = new System.Windows.Forms.TabPage();
            this.gb_devErrors = new System.Windows.Forms.GroupBox();
            this.btn_devErrors_status = new System.Windows.Forms.Button();
            this.pnlInfoDevErrors = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlNotLocal = new System.Windows.Forms.Panel();
            this.lblNotLocalInfo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tcMain.SuspendLayout();
            this.tbPlatformTracing.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.gb_trace_actions.SuspendLayout();
            this.gb_trace_status.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.pnlInfoTracing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpDevErrors.SuspendLayout();
            this.gb_devErrors.SuspendLayout();
            this.pnlInfoDevErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlNotLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tbPlatformTracing);
            this.tcMain.Controls.Add(this.tpDevErrors);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(800, 616);
            this.tcMain.TabIndex = 0;
            // 
            // tbPlatformTracing
            // 
            this.tbPlatformTracing.Controls.Add(this.pnlActions);
            this.tbPlatformTracing.Controls.Add(this.gbOptions);
            this.tbPlatformTracing.Controls.Add(this.pnlInfoTracing);
            this.tbPlatformTracing.Location = new System.Drawing.Point(4, 33);
            this.tbPlatformTracing.Name = "tbPlatformTracing";
            this.tbPlatformTracing.Padding = new System.Windows.Forms.Padding(3);
            this.tbPlatformTracing.Size = new System.Drawing.Size(792, 579);
            this.tbPlatformTracing.TabIndex = 0;
            this.tbPlatformTracing.Text = "Platform Tracing";
            this.tbPlatformTracing.UseVisualStyleBackColor = true;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.gb_trace_actions);
            this.pnlActions.Controls.Add(this.gb_trace_status);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(3, 267);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(786, 309);
            this.pnlActions.TabIndex = 18;
            // 
            // gb_trace_actions
            // 
            this.gb_trace_actions.Controls.Add(this.btn_trace_cleandirectory);
            this.gb_trace_actions.Controls.Add(this.btn_trace_opendirectory);
            this.gb_trace_actions.Controls.Add(this.btn_trace_zipfiles);
            this.gb_trace_actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_trace_actions.Location = new System.Drawing.Point(388, 0);
            this.gb_trace_actions.Margin = new System.Windows.Forms.Padding(6);
            this.gb_trace_actions.Name = "gb_trace_actions";
            this.gb_trace_actions.Padding = new System.Windows.Forms.Padding(6);
            this.gb_trace_actions.Size = new System.Drawing.Size(398, 309);
            this.gb_trace_actions.TabIndex = 15;
            this.gb_trace_actions.TabStop = false;
            this.gb_trace_actions.Text = "Actions";
            // 
            // btn_trace_cleandirectory
            // 
            this.btn_trace_cleandirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_trace_cleandirectory.Image = ((System.Drawing.Image)(resources.GetObject("btn_trace_cleandirectory.Image")));
            this.btn_trace_cleandirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trace_cleandirectory.Location = new System.Drawing.Point(11, 212);
            this.btn_trace_cleandirectory.Margin = new System.Windows.Forms.Padding(6);
            this.btn_trace_cleandirectory.Name = "btn_trace_cleandirectory";
            this.btn_trace_cleandirectory.Size = new System.Drawing.Size(381, 74);
            this.btn_trace_cleandirectory.TabIndex = 2;
            this.btn_trace_cleandirectory.Text = "Clean Trace Directory";
            this.btn_trace_cleandirectory.UseVisualStyleBackColor = true;
            this.btn_trace_cleandirectory.Click += new System.EventHandler(this.btn_trace_cleandirectory_Click);
            // 
            // btn_trace_opendirectory
            // 
            this.btn_trace_opendirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_trace_opendirectory.Image = ((System.Drawing.Image)(resources.GetObject("btn_trace_opendirectory.Image")));
            this.btn_trace_opendirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trace_opendirectory.Location = new System.Drawing.Point(11, 42);
            this.btn_trace_opendirectory.Margin = new System.Windows.Forms.Padding(6);
            this.btn_trace_opendirectory.Name = "btn_trace_opendirectory";
            this.btn_trace_opendirectory.Size = new System.Drawing.Size(381, 74);
            this.btn_trace_opendirectory.TabIndex = 1;
            this.btn_trace_opendirectory.Text = "Open Trace Directory";
            this.btn_trace_opendirectory.UseVisualStyleBackColor = true;
            this.btn_trace_opendirectory.Click += new System.EventHandler(this.btn_trace_opendirectory_Click);
            // 
            // btn_trace_zipfiles
            // 
            this.btn_trace_zipfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_trace_zipfiles.Image = ((System.Drawing.Image)(resources.GetObject("btn_trace_zipfiles.Image")));
            this.btn_trace_zipfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trace_zipfiles.Location = new System.Drawing.Point(11, 127);
            this.btn_trace_zipfiles.Margin = new System.Windows.Forms.Padding(6);
            this.btn_trace_zipfiles.Name = "btn_trace_zipfiles";
            this.btn_trace_zipfiles.Size = new System.Drawing.Size(381, 74);
            this.btn_trace_zipfiles.TabIndex = 0;
            this.btn_trace_zipfiles.Text = "Zip Trace Files";
            this.btn_trace_zipfiles.UseVisualStyleBackColor = true;
            this.btn_trace_zipfiles.Click += new System.EventHandler(this.btn_trace_zipfiles_Click);
            // 
            // gb_trace_status
            // 
            this.gb_trace_status.Controls.Add(this.btn_trace_status);
            this.gb_trace_status.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_trace_status.Location = new System.Drawing.Point(0, 0);
            this.gb_trace_status.Margin = new System.Windows.Forms.Padding(6);
            this.gb_trace_status.Name = "gb_trace_status";
            this.gb_trace_status.Padding = new System.Windows.Forms.Padding(6);
            this.gb_trace_status.Size = new System.Drawing.Size(388, 309);
            this.gb_trace_status.TabIndex = 14;
            this.gb_trace_status.TabStop = false;
            this.gb_trace_status.Text = "Trace Status";
            // 
            // btn_trace_status
            // 
            this.btn_trace_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_trace_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trace_status.Image = ((System.Drawing.Image)(resources.GetObject("btn_trace_status.Image")));
            this.btn_trace_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trace_status.Location = new System.Drawing.Point(11, 42);
            this.btn_trace_status.Margin = new System.Windows.Forms.Padding(6);
            this.btn_trace_status.Name = "btn_trace_status";
            this.btn_trace_status.Size = new System.Drawing.Size(365, 74);
            this.btn_trace_status.TabIndex = 0;
            this.btn_trace_status.Text = "btn_trace_status";
            this.btn_trace_status.UseVisualStyleBackColor = true;
            this.btn_trace_status.Click += new System.EventHandler(this.btn_trace_status_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lbl_trace_callstack);
            this.gbOptions.Controls.Add(this.cb_trace_callstack);
            this.gbOptions.Controls.Add(this.lbl_trace_level);
            this.gbOptions.Controls.Add(this.cbb_level_trace);
            this.gbOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOptions.Location = new System.Drawing.Point(3, 131);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(786, 136);
            this.gbOptions.TabIndex = 17;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // lbl_trace_callstack
            // 
            this.lbl_trace_callstack.AutoSize = true;
            this.lbl_trace_callstack.Location = new System.Drawing.Point(6, 76);
            this.lbl_trace_callstack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_trace_callstack.Name = "lbl_trace_callstack";
            this.lbl_trace_callstack.Size = new System.Drawing.Size(160, 25);
            this.lbl_trace_callstack.TabIndex = 13;
            this.lbl_trace_callstack.Text = "Include call stack";
            // 
            // cb_trace_callstack
            // 
            this.cb_trace_callstack.AutoSize = true;
            this.cb_trace_callstack.Location = new System.Drawing.Point(244, 79);
            this.cb_trace_callstack.Margin = new System.Windows.Forms.Padding(6);
            this.cb_trace_callstack.Name = "cb_trace_callstack";
            this.cb_trace_callstack.Size = new System.Drawing.Size(22, 21);
            this.cb_trace_callstack.TabIndex = 12;
            this.cb_trace_callstack.UseVisualStyleBackColor = true;
            // 
            // lbl_trace_level
            // 
            this.lbl_trace_level.AutoSize = true;
            this.lbl_trace_level.Location = new System.Drawing.Point(6, 35);
            this.lbl_trace_level.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_trace_level.Name = "lbl_trace_level";
            this.lbl_trace_level.Size = new System.Drawing.Size(59, 25);
            this.lbl_trace_level.TabIndex = 11;
            this.lbl_trace_level.Text = "Level";
            // 
            // cbb_level_trace
            // 
            this.cbb_level_trace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_level_trace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_level_trace.FormattingEnabled = true;
            this.cbb_level_trace.Items.AddRange(new object[] {
            "Error",
            "Warning",
            "Info",
            "Verbose"});
            this.cbb_level_trace.Location = new System.Drawing.Point(244, 29);
            this.cbb_level_trace.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_level_trace.Name = "cbb_level_trace";
            this.cbb_level_trace.Size = new System.Drawing.Size(533, 32);
            this.cbb_level_trace.TabIndex = 10;
            // 
            // pnlInfoTracing
            // 
            this.pnlInfoTracing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlInfoTracing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoTracing.Controls.Add(this.label1);
            this.pnlInfoTracing.Controls.Add(this.pictureBox1);
            this.pnlInfoTracing.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoTracing.Location = new System.Drawing.Point(3, 3);
            this.pnlInfoTracing.Margin = new System.Windows.Forms.Padding(6);
            this.pnlInfoTracing.Name = "pnlInfoTracing";
            this.pnlInfoTracing.Size = new System.Drawing.Size(786, 128);
            this.pnlInfoTracing.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 126);
            this.label1.TabIndex = 13;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 126);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tpDevErrors
            // 
            this.tpDevErrors.Controls.Add(this.gb_devErrors);
            this.tpDevErrors.Controls.Add(this.pnlInfoDevErrors);
            this.tpDevErrors.Location = new System.Drawing.Point(4, 33);
            this.tpDevErrors.Name = "tpDevErrors";
            this.tpDevErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevErrors.Size = new System.Drawing.Size(792, 579);
            this.tpDevErrors.TabIndex = 1;
            this.tpDevErrors.Text = "Development Errors";
            this.tpDevErrors.UseVisualStyleBackColor = true;
            // 
            // gb_devErrors
            // 
            this.gb_devErrors.Controls.Add(this.btn_devErrors_status);
            this.gb_devErrors.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_devErrors.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_devErrors.Location = new System.Drawing.Point(3, 107);
            this.gb_devErrors.Margin = new System.Windows.Forms.Padding(6);
            this.gb_devErrors.Name = "gb_devErrors";
            this.gb_devErrors.Padding = new System.Windows.Forms.Padding(6);
            this.gb_devErrors.Size = new System.Drawing.Size(786, 174);
            this.gb_devErrors.TabIndex = 16;
            this.gb_devErrors.TabStop = false;
            this.gb_devErrors.Text = "Status";
            // 
            // btn_devErrors_status
            // 
            this.btn_devErrors_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devErrors_status.Image = ((System.Drawing.Image)(resources.GetObject("btn_devErrors_status.Image")));
            this.btn_devErrors_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_devErrors_status.Location = new System.Drawing.Point(11, 54);
            this.btn_devErrors_status.Margin = new System.Windows.Forms.Padding(6);
            this.btn_devErrors_status.Name = "btn_devErrors_status";
            this.btn_devErrors_status.Size = new System.Drawing.Size(763, 74);
            this.btn_devErrors_status.TabIndex = 0;
            this.btn_devErrors_status.Text = "btn_devErrors_status";
            this.btn_devErrors_status.UseVisualStyleBackColor = true;
            this.btn_devErrors_status.Click += new System.EventHandler(this.btn_devErrors_status_Click);
            // 
            // pnlInfoDevErrors
            // 
            this.pnlInfoDevErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlInfoDevErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoDevErrors.Controls.Add(this.label3);
            this.pnlInfoDevErrors.Controls.Add(this.pictureBox3);
            this.pnlInfoDevErrors.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoDevErrors.Location = new System.Drawing.Point(3, 3);
            this.pnlInfoDevErrors.Margin = new System.Windows.Forms.Padding(6);
            this.pnlInfoDevErrors.Name = "pnlInfoDevErrors";
            this.pnlInfoDevErrors.Size = new System.Drawing.Size(786, 104);
            this.pnlInfoDevErrors.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(29, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(755, 102);
            this.label3.TabIndex = 13;
            this.label3.Text = "Microsoft CRM Web Application usually displays simplified error messages to the e" +
    "nd user.\r\nClick the below button to Enable or Disable display of more detailed e" +
    "rror messages.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 102);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pnlNotLocal
            // 
            this.pnlNotLocal.Controls.Add(this.lblNotLocalInfo);
            this.pnlNotLocal.Controls.Add(this.pictureBox2);
            this.pnlNotLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotLocal.Location = new System.Drawing.Point(0, 0);
            this.pnlNotLocal.Name = "pnlNotLocal";
            this.pnlNotLocal.Size = new System.Drawing.Size(800, 616);
            this.pnlNotLocal.TabIndex = 1;
            this.pnlNotLocal.Visible = false;
            // 
            // lblNotLocalInfo
            // 
            this.lblNotLocalInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotLocalInfo.Location = new System.Drawing.Point(130, 284);
            this.lblNotLocalInfo.Name = "lblNotLocalInfo";
            this.lblNotLocalInfo.Size = new System.Drawing.Size(549, 189);
            this.lblNotLocalInfo.TabIndex = 1;
            this.lblNotLocalInfo.Text = "This utility must be opened on a Microsoft Dynamics 365 server";
            this.lblNotLocalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dynamics365Tracer.Properties.Resources.warning;
            this.pictureBox2.Location = new System.Drawing.Point(340, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.pnlNotLocal);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamics 365 Tracer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tbPlatformTracing.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.gb_trace_actions.ResumeLayout(false);
            this.gb_trace_status.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.pnlInfoTracing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpDevErrors.ResumeLayout(false);
            this.gb_devErrors.ResumeLayout(false);
            this.pnlInfoDevErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlNotLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tbPlatformTracing;
        private System.Windows.Forms.Panel pnlInfoTracing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tpDevErrors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.GroupBox gb_trace_actions;
        private System.Windows.Forms.Button btn_trace_cleandirectory;
        private System.Windows.Forms.Button btn_trace_opendirectory;
        private System.Windows.Forms.Button btn_trace_zipfiles;
        private System.Windows.Forms.GroupBox gb_trace_status;
        private System.Windows.Forms.Button btn_trace_status;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label lbl_trace_callstack;
        private System.Windows.Forms.CheckBox cb_trace_callstack;
        private System.Windows.Forms.Label lbl_trace_level;
        private System.Windows.Forms.ComboBox cbb_level_trace;
        private System.Windows.Forms.GroupBox gb_devErrors;
        private System.Windows.Forms.Button btn_devErrors_status;
        private System.Windows.Forms.Panel pnlInfoDevErrors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlNotLocal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNotLocalInfo;
    }
}

