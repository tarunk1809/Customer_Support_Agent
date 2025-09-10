namespace Agent_Login
{
    partial class ChatForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lstChats = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblChatHeader = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMessages.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlSidebar.Controls.Add(this.lstChats);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 679);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lstChats
            // 
            this.lstChats.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstChats.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstChats.FormattingEnabled = true;
            this.lstChats.ItemHeight = 32;
            this.lstChats.Items.AddRange(new object[] {
            "Chat With Tarun",
            "Chat With Manoj"});
            this.lstChats.Location = new System.Drawing.Point(0, 148);
            this.lstChats.Name = "lstChats";
            this.lstChats.Size = new System.Drawing.Size(250, 531);
            this.lstChats.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Agent_Login.Properties.Resources.chat;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlMessages);
            this.panel1.Controls.Add(this.lblChatHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 679);
            this.panel1.TabIndex = 1;
            // 
            // pnlMessages
            // 
            this.pnlMessages.AutoScroll = true;
            this.pnlMessages.Controls.Add(this.panel2);
            this.pnlMessages.Controls.Add(this.pnlInput);
            this.pnlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessages.Location = new System.Drawing.Point(0, 48);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(754, 631);
            this.pnlMessages.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(454, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 571);
            this.panel2.TabIndex = 1;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.btnSend);
            this.pnlInput.Controls.Add(this.txtMessage);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInput.Location = new System.Drawing.Point(0, 571);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(754, 60);
            this.pnlInput.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Image = global::Agent_Login.Properties.Resources.dm21;
            this.btnSend.Location = new System.Drawing.Point(699, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(55, 60);
            this.btnSend.TabIndex = 1;
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(754, 39);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lblChatHeader
            // 
            this.lblChatHeader.AutoSize = true;
            this.lblChatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChatHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatHeader.Location = new System.Drawing.Point(0, 0);
            this.lblChatHeader.Name = "lblChatHeader";
            this.lblChatHeader.Size = new System.Drawing.Size(97, 48);
            this.lblChatHeader.TabIndex = 0;
            this.lblChatHeader.Text = "Chat";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1004, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMessages.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstChats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChatHeader;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel2;
    }
}