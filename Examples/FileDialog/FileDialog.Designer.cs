namespace FileDialog {
    partial class FileDialog {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label filenameLabel;
            System.Windows.Forms.Label filetypeLabel;
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.openButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.shellView = new GongSolutions.Shell.ShellView();
            this.toolbar = new GongSolutions.Shell.FileDialogToolbar();
            this.filterCombo = new GongSolutions.Shell.FileFilterComboBox();
            this.fileNameCombo = new GongSolutions.Shell.FileNameComboBox();
            this.placesToolbar1 = new GongSolutions.Shell.PlacesToolbar();
            filenameLabel = new System.Windows.Forms.Label();
            filetypeLabel = new System.Windows.Forms.Label();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            filenameLabel.Location = new System.Drawing.Point(61, 679);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new System.Drawing.Size(112, 32);
            filenameLabel.TabIndex = 0;
            filenameLabel.Text = "File &name:";
            filenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filetypeLabel
            // 
            filetypeLabel.AutoSize = true;
            filetypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            filetypeLabel.Location = new System.Drawing.Point(61, 711);
            filetypeLabel.Name = "filetypeLabel";
            filetypeLabel.Size = new System.Drawing.Size(112, 32);
            filetypeLabel.TabIndex = 2;
            filetypeLabel.Text = "Files of &type:";
            filetypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.Transparent;
            this.mainLayout.ColumnCount = 4;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.Controls.Add(this.shellView, 1, 1);
            this.mainLayout.Controls.Add(filenameLabel, 1, 2);
            this.mainLayout.Controls.Add(filetypeLabel, 1, 3);
            this.mainLayout.Controls.Add(this.openButton, 3, 2);
            this.mainLayout.Controls.Add(this.cancelButton, 3, 3);
            this.mainLayout.Controls.Add(this.toolbar, 0, 0);
            this.mainLayout.Controls.Add(this.filterCombo, 2, 3);
            this.mainLayout.Controls.Add(this.fileNameCombo, 2, 2);
            this.mainLayout.Controls.Add(this.placesToolbar1, 0, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.Size = new System.Drawing.Size(1558, 746);
            this.mainLayout.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(1468, 682);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(83, 26);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "&Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(1468, 714);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 26);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // shellView
            // 
            this.mainLayout.SetColumnSpan(this.shellView, 3);
            this.shellView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellView.Location = new System.Drawing.Point(61, 63);
            this.shellView.Name = "shellView";
            this.shellView.Size = new System.Drawing.Size(1490, 613);
            this.shellView.StatusBar = null;
            this.shellView.TabIndex = 6;
            this.shellView.Text = "shellView1";
            this.shellView.View = GongSolutions.Shell.ShellViewStyle.List;
            this.shellView.SelectionChanged += new System.EventHandler(this.shellView_SelectionChanged);
            this.shellView.DoubleClick += new System.EventHandler(this.shellView_DoubleClick);
            // 
            // toolbar
            // 
            this.toolbar.AutoSize = true;
            this.mainLayout.SetColumnSpan(this.toolbar, 4);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbar.Location = new System.Drawing.Point(10, 6);
            this.toolbar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.toolbar.Name = "toolbar";
            this.toolbar.ShellView = this.shellView;
            this.toolbar.Size = new System.Drawing.Size(1538, 51);
            this.toolbar.TabIndex = 7;
            // 
            // filterCombo
            // 
            this.filterCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterCombo.FilterItems = "Text Files (*.txt)|*.txt|Video Files|*.avi, *.wmv|All Files (*.*)|*.*";
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Location = new System.Drawing.Point(179, 714);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.ShellView = this.shellView;
            this.filterCombo.Size = new System.Drawing.Size(1283, 26);
            this.filterCombo.TabIndex = 3;
            // 
            // fileNameCombo
            // 
            this.fileNameCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameCombo.FilterControl = this.filterCombo;
            this.fileNameCombo.FormattingEnabled = true;
            this.fileNameCombo.Location = new System.Drawing.Point(179, 682);
            this.fileNameCombo.Name = "fileNameCombo";
            this.fileNameCombo.ShellView = this.shellView;
            this.fileNameCombo.Size = new System.Drawing.Size(1283, 26);
            this.fileNameCombo.TabIndex = 1;
            this.fileNameCombo.FileNameEntered += new System.EventHandler(this.fileNameCombo_FilenameEntered);
            this.fileNameCombo.TextChanged += new System.EventHandler(this.fileNameCombo_TextChanged);
            // 
            // placesToolbar1
            // 
            this.placesToolbar1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.placesToolbar1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.placesToolbar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placesToolbar1.Location = new System.Drawing.Point(10, 63);
            this.placesToolbar1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.placesToolbar1.Name = "placesToolbar1";
            this.mainLayout.SetRowSpan(this.placesToolbar1, 3);
            this.placesToolbar1.ShellView = this.shellView;
            this.placesToolbar1.Size = new System.Drawing.Size(42, 677);
            this.placesToolbar1.TabIndex = 8;
            // 
            // FileDialog
            // 
            this.AcceptButton = this.openButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 746);
            this.Controls.Add(this.mainLayout);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Example File Dialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileDialog_FormClosed);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private GongSolutions.Shell.ShellView shellView;
        private System.Windows.Forms.Button cancelButton;
        private GongSolutions.Shell.FileDialogToolbar toolbar;
        private GongSolutions.Shell.FileFilterComboBox filterCombo;
        private GongSolutions.Shell.FileNameComboBox fileNameCombo;
        private GongSolutions.Shell.PlacesToolbar placesToolbar1;
        private System.Windows.Forms.Button openButton;
    }
}
