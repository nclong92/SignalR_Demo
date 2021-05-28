
namespace WindowsFormsServer
{
    partial class FrmServer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBroastCast = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.rdToClient = new System.Windows.Forms.RadioButton();
            this.rdToGroup = new System.Windows.Forms.RadioButton();
            this.rdToAll = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpBroastCast.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server 1";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(185, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(103, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(74, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(74, 24);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(214, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://localhost:8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // grpBroastCast
            // 
            this.grpBroastCast.Controls.Add(this.btnSend);
            this.grpBroastCast.Controls.Add(this.txtMessage);
            this.grpBroastCast.Controls.Add(this.label2);
            this.grpBroastCast.Controls.Add(this.cmbClients);
            this.grpBroastCast.Controls.Add(this.cmbGroups);
            this.grpBroastCast.Controls.Add(this.rdToClient);
            this.grpBroastCast.Controls.Add(this.rdToGroup);
            this.grpBroastCast.Controls.Add(this.rdToAll);
            this.grpBroastCast.Enabled = false;
            this.grpBroastCast.Location = new System.Drawing.Point(12, 103);
            this.grpBroastCast.Name = "grpBroastCast";
            this.grpBroastCast.Size = new System.Drawing.Size(441, 152);
            this.grpBroastCast.TabIndex = 1;
            this.grpBroastCast.TabStop = false;
            this.grpBroastCast.Text = "Broadcast Message";
            this.grpBroastCast.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(319, 115);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(105, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(112, 117);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(201, 20);
            this.txtMessage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message";
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(112, 87);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(201, 21);
            this.cmbClients.TabIndex = 4;
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(112, 60);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(201, 21);
            this.cmbGroups.TabIndex = 3;
            // 
            // rdToClient
            // 
            this.rdToClient.AutoSize = true;
            this.rdToClient.Location = new System.Drawing.Point(22, 91);
            this.rdToClient.Name = "rdToClient";
            this.rdToClient.Size = new System.Drawing.Size(67, 17);
            this.rdToClient.TabIndex = 2;
            this.rdToClient.TabStop = true;
            this.rdToClient.Text = "To Client";
            this.rdToClient.UseVisualStyleBackColor = true;
            // 
            // rdToGroup
            // 
            this.rdToGroup.AutoSize = true;
            this.rdToGroup.Location = new System.Drawing.Point(22, 64);
            this.rdToGroup.Name = "rdToGroup";
            this.rdToGroup.Size = new System.Drawing.Size(70, 17);
            this.rdToGroup.TabIndex = 1;
            this.rdToGroup.TabStop = true;
            this.rdToGroup.Text = "To Group";
            this.rdToGroup.UseVisualStyleBackColor = true;
            // 
            // rdToAll
            // 
            this.rdToAll.AutoSize = true;
            this.rdToAll.Checked = true;
            this.rdToAll.Location = new System.Drawing.Point(22, 41);
            this.rdToAll.Name = "rdToAll";
            this.rdToAll.Size = new System.Drawing.Size(52, 17);
            this.rdToAll.TabIndex = 0;
            this.rdToAll.TabStop = true;
            this.rdToAll.Text = "To All";
            this.rdToAll.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 357);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(429, 317);
            this.txtLog.TabIndex = 4;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBroastCast);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBroastCast.ResumeLayout(false);
            this.grpBroastCast.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBroastCast;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.RadioButton rdToClient;
        private System.Windows.Forms.RadioButton rdToGroup;
        private System.Windows.Forms.RadioButton rdToAll;
        private System.Windows.Forms.TextBox txtLog;
    }
}

