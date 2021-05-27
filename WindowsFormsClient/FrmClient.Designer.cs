
namespace WindowsFormsClient
{
    partial class FrmClient
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
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMessaging = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpMembership = new System.Windows.Forms.GroupBox();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroupname = new System.Windows.Forms.TextBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.grpConnection.SuspendLayout();
            this.grpMessaging.SuspendLayout();
            this.grpMembership.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.btnDisconnect);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.txtUsername);
            this.grpConnection.Controls.Add(this.txtUrl);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Location = new System.Drawing.Point(13, 13);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(467, 117);
            this.grpConnection.TabIndex = 0;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(199, 75);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(108, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(90, 76);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(90, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "user";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(90, 23);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(217, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "http://localhost:8080/signalr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // grpMessaging
            // 
            this.grpMessaging.Controls.Add(this.btnSend);
            this.grpMessaging.Controls.Add(this.txtMessage);
            this.grpMessaging.Controls.Add(this.label3);
            this.grpMessaging.Enabled = false;
            this.grpMessaging.Location = new System.Drawing.Point(12, 136);
            this.grpMessaging.Name = "grpMessaging";
            this.grpMessaging.Size = new System.Drawing.Size(467, 89);
            this.grpMessaging.TabIndex = 1;
            this.grpMessaging.TabStop = false;
            this.grpMessaging.Text = "Messaging";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(91, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(217, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(91, 19);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(217, 20);
            this.txtMessage.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // grpMembership
            // 
            this.grpMembership.Controls.Add(this.btnLeave);
            this.grpMembership.Controls.Add(this.btnJoin);
            this.grpMembership.Controls.Add(this.label4);
            this.grpMembership.Controls.Add(this.txtGroupname);
            this.grpMembership.Enabled = false;
            this.grpMembership.Location = new System.Drawing.Point(13, 231);
            this.grpMembership.Name = "grpMembership";
            this.grpMembership.Size = new System.Drawing.Size(467, 89);
            this.grpMembership.TabIndex = 2;
            this.grpMembership.TabStop = false;
            this.grpMembership.Text = "Group Membership";
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(199, 49);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(108, 23);
            this.btnLeave.TabIndex = 9;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(90, 50);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(108, 23);
            this.btnJoin.TabIndex = 8;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Group name";
            // 
            // txtGroupname
            // 
            this.txtGroupname.Location = new System.Drawing.Point(90, 23);
            this.txtGroupname.Name = "txtGroupname";
            this.txtGroupname.Size = new System.Drawing.Size(217, 20);
            this.txtGroupname.TabIndex = 7;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Location = new System.Drawing.Point(13, 326);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(467, 229);
            this.grpLog.TabIndex = 3;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(455, 204);
            this.txtLog.TabIndex = 10;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 567);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpMembership);
            this.Controls.Add(this.grpMessaging);
            this.Controls.Add(this.grpConnection);
            this.Name = "FrmClient";
            this.Text = "Client";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpMessaging.ResumeLayout(false);
            this.grpMessaging.PerformLayout();
            this.grpMembership.ResumeLayout(false);
            this.grpMembership.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMessaging;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpMembership;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroupname;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
    }
}

