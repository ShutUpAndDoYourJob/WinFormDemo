namespace WinFormDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelConnection = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataSource = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTaskDelay = new System.Windows.Forms.Button();
            this.buttonDatabaseTime = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.tableLayoutPanelConnection.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxConnection, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.statusStrip, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.tabControlMain, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelButtons, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 461);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.tableLayoutPanelConnection);
            this.groupBoxConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxConnection.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(698, 108);
            this.groupBoxConnection.TabIndex = 0;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Oracle Database Connection";
            // 
            // tableLayoutPanelConnection
            // 
            this.tableLayoutPanelConnection.ColumnCount = 2;
            this.tableLayoutPanelConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelConnection.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelConnection.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelConnection.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelConnection.Controls.Add(this.textBoxDataSource, 1, 0);
            this.tableLayoutPanelConnection.Controls.Add(this.textBoxUser, 1, 1);
            this.tableLayoutPanelConnection.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanelConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelConnection.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelConnection.Name = "tableLayoutPanelConnection";
            this.tableLayoutPanelConnection.RowCount = 3;
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelConnection.Size = new System.Drawing.Size(692, 86);
            this.tableLayoutPanelConnection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "User:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDataSource.Location = new System.Drawing.Point(103, 3);
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(586, 23);
            this.textBoxDataSource.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUser.Location = new System.Drawing.Point(103, 31);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(586, 23);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(103, 59);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(586, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(704, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "Status";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Enabled = false;
            this.toolStripProgressBar.MarqueeAnimationSpeed = 0;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageOutput);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(3, 117);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(698, 284);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.textBoxOutput);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 24);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(690, 256);
            this.tabPageOutput.TabIndex = 0;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 3);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(684, 250);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutput_KeyPress);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.listBoxLogs);
            this.tabPageLog.Location = new System.Drawing.Point(4, 24);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(690, 256);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Logs";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLogs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.HorizontalScrollbar = true;
            this.listBoxLogs.ItemHeight = 14;
            this.listBoxLogs.Location = new System.Drawing.Point(3, 3);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(684, 250);
            this.listBoxLogs.TabIndex = 0;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.Controls.Add(this.buttonTaskDelay);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonDatabaseTime);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(3, 407);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(698, 29);
            this.flowLayoutPanelButtons.TabIndex = 3;
            // 
            // buttonTaskDelay
            // 
            this.buttonTaskDelay.Location = new System.Drawing.Point(3, 3);
            this.buttonTaskDelay.Name = "buttonTaskDelay";
            this.buttonTaskDelay.Size = new System.Drawing.Size(120, 23);
            this.buttonTaskDelay.TabIndex = 1;
            this.buttonTaskDelay.Text = "Task Delay(10)";
            this.buttonTaskDelay.UseVisualStyleBackColor = true;
            this.buttonTaskDelay.Click += new System.EventHandler(this.buttonTaskDelay_Click);
            // 
            // buttonDatabaseTime
            // 
            this.buttonDatabaseTime.Location = new System.Drawing.Point(129, 3);
            this.buttonDatabaseTime.Name = "buttonDatabaseTime";
            this.buttonDatabaseTime.Size = new System.Drawing.Size(120, 23);
            this.buttonDatabaseTime.TabIndex = 0;
            this.buttonDatabaseTime.Text = "Database Time";
            this.buttonDatabaseTime.UseVisualStyleBackColor = true;
            this.buttonDatabaseTime.Click += new System.EventHandler(this.buttonDatabaseTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "Form1";
            this.Text = "WinForm Demo";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.tableLayoutPanelConnection.ResumeLayout(false);
            this.tableLayoutPanelConnection.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnection;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOutput;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonDatabaseTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDataSource;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonTaskDelay;
    }
}

