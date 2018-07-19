namespace  eyetracking
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._box1 = new System.Windows.Forms.GroupBox();
            this._connectButton = new System.Windows.Forms.Button();
            this._trackerInfoLabel = new System.Windows.Forms.Label();
            this._trackerList = new System.Windows.Forms.ListView();
            this._confirmButton = new System.Windows.Forms.Button();
            this._GazeButton = new System.Windows.Forms.Button();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._box2 = new System.Windows.Forms.GroupBox();
            this._selectpicture = new System.Windows.Forms.ComboBox();
            this._calibrateButton = new System.Windows.Forms.Button();
            this._trackStatus = new eyetracking.TrackStatusControl();
            this._trackButton = new System.Windows.Forms.Button();
            this._calib5 = new System.Windows.Forms.RadioButton();
            this._calib9 = new System.Windows.Forms.RadioButton();
            this._dammyButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveCalibrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._viewCalibrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._loadCalibrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._framerateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._openpictureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._box1.SuspendLayout();
            this._statusStrip.SuspendLayout();
            this._box2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _box1
            // 
            this._box1.Controls.Add(this._connectButton);
            this._box1.Controls.Add(this._trackerInfoLabel);
            this._box1.Controls.Add(this._trackerList);
            this._box1.Location = new System.Drawing.Point(13, 35);
            this._box1.Name = "_box1";
            this._box1.Size = new System.Drawing.Size(237, 344);
            this._box1.TabIndex = 1;
            this._box1.TabStop = false;
            this._box1.Text = "Eyetrackers Found on the  Network";
            // 
            // _connectButton
            // 
            this._connectButton.Enabled = false;
            this._connectButton.Location = new System.Drawing.Point(45, 308);
            this._connectButton.Name = "_connectButton";
            this._connectButton.Size = new System.Drawing.Size(142, 25);
            this._connectButton.TabIndex = 2;
            this._connectButton.Text = "Connect to Eyetracker";
            this._connectButton.UseVisualStyleBackColor = true;
            this._connectButton.Click += new System.EventHandler(this._connectButton_Click);
            // 
            // _trackerInfoLabel
            // 
            this._trackerInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._trackerInfoLabel.Location = new System.Drawing.Point(19, 208);
            this._trackerInfoLabel.Name = "_trackerInfoLabel";
            this._trackerInfoLabel.Size = new System.Drawing.Size(196, 88);
            this._trackerInfoLabel.TabIndex = 1;
            // 
            // _trackerList
            // 
            this._trackerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._trackerList.Location = new System.Drawing.Point(19, 30);
            this._trackerList.MultiSelect = false;
            this._trackerList.Name = "_trackerList";
            this._trackerList.ShowItemToolTips = true;
            this._trackerList.Size = new System.Drawing.Size(196, 166);
            this._trackerList.TabIndex = 0;
            this._trackerList.UseCompatibleStateImageBehavior = false;
            this._trackerList.View = System.Windows.Forms.View.SmallIcon;
            this._trackerList.SelectedIndexChanged += new System.EventHandler(this._trackerList_SelectedIndexChanged);
            // 
            // _confirmButton
            // 
            this._confirmButton.Location = new System.Drawing.Point(197, 250);
            this._confirmButton.Name = "_confirmButton";
            this._confirmButton.Size = new System.Drawing.Size(111, 25);
            this._confirmButton.TabIndex = 2;
            this._confirmButton.Text = "Confirm";
            this._confirmButton.UseVisualStyleBackColor = true;
            this._confirmButton.Click += new System.EventHandler(this._confirmButton_Click);
            // 
            // _GazeButton
            // 
            this._GazeButton.Location = new System.Drawing.Point(197, 277);
            this._GazeButton.Name = "_GazeButton";
            this._GazeButton.Size = new System.Drawing.Size(111, 25);
            this._GazeButton.TabIndex = 3;
            this._GazeButton.Text = "Gaze";
            this._GazeButton.UseVisualStyleBackColor = true;
            this._GazeButton.Click += new System.EventHandler(this._GazeButton_Click);
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._connectionStatusLabel});
            this._statusStrip.Location = new System.Drawing.Point(0, 383);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(665, 23);
            this._statusStrip.TabIndex = 2;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _connectionStatusLabel
            // 
            this._connectionStatusLabel.Name = "_connectionStatusLabel";
            this._connectionStatusLabel.Size = new System.Drawing.Size(85, 18);
            this._connectionStatusLabel.Text = "Disconnected";
            // 
            // _box2
            // 
            this._box2.Controls.Add(this._selectpicture);
            this._box2.Controls.Add(this._calibrateButton);
            this._box2.Controls.Add(this._confirmButton);
            this._box2.Controls.Add(this._trackStatus);
            this._box2.Controls.Add(this._trackButton);
            this._box2.Controls.Add(this._GazeButton);
            this._box2.Controls.Add(this._calib5);
            this._box2.Controls.Add(this._calib9);
            this._box2.Controls.Add(this._dammyButton);
            this._box2.Location = new System.Drawing.Point(256, 35);
            this._box2.Name = "_box2";
            this._box2.Size = new System.Drawing.Size(395, 344);
            this._box2.TabIndex = 3;
            this._box2.TabStop = false;
            this._box2.Text = "Eyetracker Status";
            // 
            // _selectpicture
            // 
            this._selectpicture.FormattingEnabled = true;
            this._selectpicture.Items.AddRange(new object[] {
            "1",
            "2"});
            this._selectpicture.Location = new System.Drawing.Point(197, 309);
            this._selectpicture.Name = "_selectpicture";
            this._selectpicture.Size = new System.Drawing.Size(104, 20);
            this._selectpicture.TabIndex = 0;
            this._selectpicture.SelectedIndexChanged += new System.EventHandler(this._selectpicture_SelectedIndexChanged);
            // 
            // _calibrateButton
            // 
            this._calibrateButton.Location = new System.Drawing.Point(74, 277);
            this._calibrateButton.Name = "_calibrateButton";
            this._calibrateButton.Size = new System.Drawing.Size(111, 25);
            this._calibrateButton.TabIndex = 2;
            this._calibrateButton.Text = "Run Calibration";
            this._calibrateButton.UseVisualStyleBackColor = true;
            this._calibrateButton.Click += new System.EventHandler(this._calibrateButton_Click);
            // 
            // _trackStatus
            // 
            this._trackStatus.BackColor = System.Drawing.Color.Black;
            this._trackStatus.Location = new System.Drawing.Point(74, 30);
            this._trackStatus.Name = "_trackStatus";
            this._trackStatus.Size = new System.Drawing.Size(234, 165);
            this._trackStatus.TabIndex = 1;
            // 
            // _trackButton
            // 
            this._trackButton.Location = new System.Drawing.Point(74, 250);
            this._trackButton.Name = "_trackButton";
            this._trackButton.Size = new System.Drawing.Size(111, 25);
            this._trackButton.TabIndex = 0;
            this._trackButton.Text = "Start Tracking";
            this._trackButton.UseVisualStyleBackColor = true;
            this._trackButton.Click += new System.EventHandler(this._trackButton_Click);
            // 
            // _calib5
            // 
            this._calib5.Checked = true;
            this._calib5.Location = new System.Drawing.Point(74, 308);
            this._calib5.Name = "_calib5";
            this._calib5.Size = new System.Drawing.Size(50, 24);
            this._calib5.TabIndex = 4;
            this._calib5.TabStop = true;
            this._calib5.Text = "5";
            this._calib5.Click += new System.EventHandler(this._calib5_Click);
            // 
            // _calib9
            // 
            this._calib9.Location = new System.Drawing.Point(130, 309);
            this._calib9.Name = "_calib9";
            this._calib9.Size = new System.Drawing.Size(50, 24);
            this._calib9.TabIndex = 5;
            this._calib9.Text = "9";
            this._calib9.Click += new System.EventHandler(this._calib9_Click);
            // 
            // _dammyButton
            // 
            this._dammyButton.Location = new System.Drawing.Point(314, 307);
            this._dammyButton.Name = "_dammyButton";
            this._dammyButton.Size = new System.Drawing.Size(75, 23);
            this._dammyButton.TabIndex = 6;
            this._dammyButton.Text = "dammy";
            this._dammyButton.Click += new System.EventHandler(this._dammyButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.pictureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "_menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveCalibrationMenuItem,
            this._viewCalibrationMenuItem,
            this._loadCalibrationMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // _saveCalibrationMenuItem
            // 
            this._saveCalibrationMenuItem.Name = "_saveCalibrationMenuItem";
            this._saveCalibrationMenuItem.Size = new System.Drawing.Size(171, 22);
            this._saveCalibrationMenuItem.Text = "Save Calibration";
            this._saveCalibrationMenuItem.Click += new System.EventHandler(this._saveCalibrationMenuItem_Click);
            // 
            // _viewCalibrationMenuItem
            // 
            this._viewCalibrationMenuItem.Name = "_viewCalibrationMenuItem";
            this._viewCalibrationMenuItem.Size = new System.Drawing.Size(171, 22);
            this._viewCalibrationMenuItem.Text = "View Calibration";
            this._viewCalibrationMenuItem.Click += new System.EventHandler(this._viewCalibrationMenuItem_Click);
            // 
            // _loadCalibrationMenuItem
            // 
            this._loadCalibrationMenuItem.Name = "_loadCalibrationMenuItem";
            this._loadCalibrationMenuItem.Size = new System.Drawing.Size(171, 22);
            this._loadCalibrationMenuItem.Text = "Load Calibration";
            this._loadCalibrationMenuItem.Click += new System.EventHandler(this._loadCalibrationMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._framerateMenuItem});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // _framerateMenuItem
            // 
            this._framerateMenuItem.Name = "_framerateMenuItem";
            this._framerateMenuItem.Size = new System.Drawing.Size(150, 22);
            this._framerateMenuItem.Text = "Framerate...";
            this._framerateMenuItem.Click += new System.EventHandler(this._framerateMenuItem_Click);
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.pictureToolStripMenuItem.Text = "picture";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openFileToolStripMenuItem.Text = "open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.DefaultExt = "calib";
            this._openFileDialog.FileName = "file";
            this._openFileDialog.Filter = "Calibration Files |*.calib";
            this._openFileDialog.Title = "Load Calibration File";
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.DefaultExt = "calib";
            this._saveFileDialog.FileName = "file";
            this._saveFileDialog.Filter = "Calibration Files|*.calib";
            this._saveFileDialog.Title = "Save Calibration File";
            // 
            // _openpictureFileDialog
            // 
            this._openpictureFileDialog.DefaultExt = "picture";
            this._openpictureFileDialog.FileName = "file";
            this._openpictureFileDialog.Filter = "picture Files |*.jpg;*.png;*.bmp";
            this._openpictureFileDialog.Title = "Load Picture File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 406);
            this.Controls.Add(this._box2);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SDK - Basic Eyetracking Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._box1.ResumeLayout(false);
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this._box2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _box1;
        private System.Windows.Forms.ListView _trackerList;
        private System.Windows.Forms.Label _trackerInfoLabel;
        private System.Windows.Forms.Button _connectButton;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _connectionStatusLabel;
        private System.Windows.Forms.GroupBox _box2;
        private System.Windows.Forms.Button _trackButton;
        private TrackStatusControl _trackStatus;
        private System.Windows.Forms.Button _calibrateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _saveCalibrationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _viewCalibrationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _loadCalibrationMenuItem;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
        private System.Windows.Forms.OpenFileDialog _openpictureFileDialog;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _framerateMenuItem;

        private System.Windows.Forms.Button _confirmButton;
        private System.Windows.Forms.Button _GazeButton;
        private System.Windows.Forms.Button _dammyButton;
        private System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.RadioButton _calib5;
        private System.Windows.Forms.RadioButton _calib9;
        private System.Windows.Forms.ComboBox _selectpicture;
    }
}

