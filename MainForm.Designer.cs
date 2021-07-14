
namespace Zoe13010.SQLLocalDB.GUI
{
    partial class MainForm
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
            this.cbInstance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetectExecFile = new System.Windows.Forms.Button();
            this.lbDetectStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbInstancePipeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInstanceLastStartTime = new System.Windows.Forms.Label();
            this.lbInstanceState = new System.Windows.Forms.Label();
            this.lbInstanceName = new System.Windows.Forms.Label();
            this.lbInstanceAutoCreate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbInstanceOwner = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbInstanceSharedName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbInstanceVer = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCreateInstance = new System.Windows.Forms.Button();
            this.btnLoadInstance = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefreshInstanceInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenSqlCmd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInstance
            // 
            this.cbInstance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInstance.FormattingEnabled = true;
            this.cbInstance.Location = new System.Drawing.Point(141, 35);
            this.cbInstance.Name = "cbInstance";
            this.cbInstance.Size = new System.Drawing.Size(341, 28);
            this.cbInstance.TabIndex = 0;
            this.cbInstance.SelectedIndexChanged += new System.EventHandler(this.cbInstance_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instance name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDetectExecFile);
            this.groupBox1.Controls.Add(this.lbDetectStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detect SQLLocalDB:";
            // 
            // btnDetectExecFile
            // 
            this.btnDetectExecFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectExecFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectExecFile.Location = new System.Drawing.Point(300, 28);
            this.btnDetectExecFile.Name = "btnDetectExecFile";
            this.btnDetectExecFile.Size = new System.Drawing.Size(182, 32);
            this.btnDetectExecFile.TabIndex = 2;
            this.btnDetectExecFile.Text = "Detect SQLLocalDB.exe";
            this.btnDetectExecFile.UseVisualStyleBackColor = true;
            this.btnDetectExecFile.Click += new System.EventHandler(this.btnDetectExecFile_Click);
            // 
            // lbDetectStatus
            // 
            this.lbDetectStatus.AutoSize = true;
            this.lbDetectStatus.Location = new System.Drawing.Point(86, 34);
            this.lbDetectStatus.Name = "lbDetectStatus";
            this.lbDetectStatus.Size = new System.Drawing.Size(78, 20);
            this.lbDetectStatus.TabIndex = 5;
            this.lbDetectStatus.Text = "(unknown)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.cbInstance);
            this.groupBox3.Controls.Add(this.btnCreateInstance);
            this.groupBox3.Controls.Add(this.btnLoadInstance);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 382);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Instance:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbInstancePipeName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbInstanceLastStartTime);
            this.groupBox2.Controls.Add(this.lbInstanceState);
            this.groupBox2.Controls.Add(this.lbInstanceName);
            this.groupBox2.Controls.Add(this.lbInstanceAutoCreate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lbInstanceOwner);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbInstanceSharedName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbInstanceVer);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(28, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 248);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instance Info";
            // 
            // tbInstancePipeName
            // 
            this.tbInstancePipeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInstancePipeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInstancePipeName.Location = new System.Drawing.Point(191, 210);
            this.tbInstancePipeName.Name = "tbInstancePipeName";
            this.tbInstancePipeName.ReadOnly = true;
            this.tbInstancePipeName.Size = new System.Drawing.Size(228, 27);
            this.tbInstancePipeName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // lbInstanceLastStartTime
            // 
            this.lbInstanceLastStartTime.AutoSize = true;
            this.lbInstanceLastStartTime.Location = new System.Drawing.Point(191, 183);
            this.lbInstanceLastStartTime.Name = "lbInstanceLastStartTime";
            this.lbInstanceLastStartTime.Size = new System.Drawing.Size(27, 20);
            this.lbInstanceLastStartTime.TabIndex = 4;
            this.lbInstanceLastStartTime.Text = "---";
            // 
            // lbInstanceState
            // 
            this.lbInstanceState.AutoSize = true;
            this.lbInstanceState.Location = new System.Drawing.Point(191, 158);
            this.lbInstanceState.Name = "lbInstanceState";
            this.lbInstanceState.Size = new System.Drawing.Size(27, 20);
            this.lbInstanceState.TabIndex = 4;
            this.lbInstanceState.Text = "---";
            // 
            // lbInstanceName
            // 
            this.lbInstanceName.AutoSize = true;
            this.lbInstanceName.Location = new System.Drawing.Point(191, 33);
            this.lbInstanceName.Name = "lbInstanceName";
            this.lbInstanceName.Size = new System.Drawing.Size(27, 20);
            this.lbInstanceName.TabIndex = 3;
            this.lbInstanceName.Text = "---";
            // 
            // lbInstanceAutoCreate
            // 
            this.lbInstanceAutoCreate.AutoSize = true;
            this.lbInstanceAutoCreate.Location = new System.Drawing.Point(191, 133);
            this.lbInstanceAutoCreate.Name = "lbInstanceAutoCreate";
            this.lbInstanceAutoCreate.Size = new System.Drawing.Size(27, 20);
            this.lbInstanceAutoCreate.TabIndex = 4;
            this.lbInstanceAutoCreate.Text = "---";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Instance pipe name:";
            // 
            // lbInstanceOwner
            // 
            this.lbInstanceOwner.AutoSize = true;
            this.lbInstanceOwner.Location = new System.Drawing.Point(191, 108);
            this.lbInstanceOwner.Name = "lbInstanceOwner";
            this.lbInstanceOwner.Size = new System.Drawing.Size(27, 20);
            this.lbInstanceOwner.TabIndex = 4;
            this.lbInstanceOwner.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Version:";
            // 
            // lbInstanceSharedName
            // 
            this.lbInstanceSharedName.AutoSize = true;
            this.lbInstanceSharedName.Location = new System.Drawing.Point(191, 83);
            this.lbInstanceSharedName.Name = "lbInstanceSharedName";
            this.lbInstanceSharedName.Size = new System.Drawing.Size(27, 20);
            this.lbInstanceSharedName.TabIndex = 4;
            this.lbInstanceSharedName.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Shared name:";
            // 
            // lbInstanceVer
            // 
            this.lbInstanceVer.AutoSize = true;
            this.lbInstanceVer.Location = new System.Drawing.Point(191, 58);
            this.lbInstanceVer.Name = "lbInstanceVer";
            this.lbInstanceVer.Size = new System.Drawing.Size(27, 20);
            this.lbInstanceVer.TabIndex = 4;
            this.lbInstanceVer.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Last start time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Owner:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Auto-create:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "State:";
            // 
            // btnCreateInstance
            // 
            this.btnCreateInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInstance.Location = new System.Drawing.Point(141, 69);
            this.btnCreateInstance.Name = "btnCreateInstance";
            this.btnCreateInstance.Size = new System.Drawing.Size(153, 32);
            this.btnCreateInstance.TabIndex = 2;
            this.btnCreateInstance.Text = "Create a instance";
            this.btnCreateInstance.UseVisualStyleBackColor = true;
            this.btnCreateInstance.Click += new System.EventHandler(this.btnCreateInstance_Click);
            // 
            // btnLoadInstance
            // 
            this.btnLoadInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadInstance.Location = new System.Drawing.Point(300, 69);
            this.btnLoadInstance.Name = "btnLoadInstance";
            this.btnLoadInstance.Size = new System.Drawing.Size(182, 32);
            this.btnLoadInstance.TabIndex = 2;
            this.btnLoadInstance.Text = "Refresh Instances List";
            this.btnLoadInstance.UseVisualStyleBackColor = true;
            this.btnLoadInstance.Click += new System.EventHandler(this.btnLoadInstance_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnRefreshInstanceInfo);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnOpenSqlCmd);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Location = new System.Drawing.Point(12, 482);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 110);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Instance Actions:";
            // 
            // btnRefreshInstanceInfo
            // 
            this.btnRefreshInstanceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshInstanceInfo.Location = new System.Drawing.Point(28, 64);
            this.btnRefreshInstanceInfo.Name = "btnRefreshInstanceInfo";
            this.btnRefreshInstanceInfo.Size = new System.Drawing.Size(454, 32);
            this.btnRefreshInstanceInfo.TabIndex = 2;
            this.btnRefreshInstanceInfo.Text = "Refresh Instance Info";
            this.btnRefreshInstanceInfo.UseVisualStyleBackColor = true;
            this.btnRefreshInstanceInfo.Click += new System.EventHandler(this.btnRefreshInstanceInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(194, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenSqlCmd
            // 
            this.btnOpenSqlCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSqlCmd.Location = new System.Drawing.Point(289, 26);
            this.btnOpenSqlCmd.Name = "btnOpenSqlCmd";
            this.btnOpenSqlCmd.Size = new System.Drawing.Size(193, 32);
            this.btnOpenSqlCmd.TabIndex = 2;
            this.btnOpenSqlCmd.Text = "Open SqlCmd";
            this.btnOpenSqlCmd.UseVisualStyleBackColor = true;
            this.btnOpenSqlCmd.Click += new System.EventHandler(this.btnOpenSqlCmd_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(111, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 32);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(28, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(291, 602);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(113, 32);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(410, 602);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 646);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::SQLLocalDBGUI.Properties.Resources.SSMS;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Microsoft SQL Local Database - GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInstance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDetectStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetectExecFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbInstanceName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbInstanceLastStartTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbInstanceState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbInstanceAutoCreate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbInstanceOwner;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbInstanceSharedName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbInstanceVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadInstance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCreateInstance;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefreshInstanceInfo;
        private System.Windows.Forms.TextBox tbInstancePipeName;
        private System.Windows.Forms.Button btnOpenSqlCmd;
    }
}

