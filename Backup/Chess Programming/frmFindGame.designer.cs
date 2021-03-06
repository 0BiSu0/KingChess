namespace Chess_Programming
{
    partial class frmFindGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindGame));
            this.timerSendBroadcast = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerUpdateHost = new System.Windows.Forms.Timer(this.components);
            this.btnsend = new System.Windows.Forms.Button();
            this.lstChat = new System.Windows.Forms.ListBox();
            this.txtchat = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lstHost = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.btnHostGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerSendBroadcast
            // 
            this.timerSendBroadcast.Enabled = true;
            this.timerSendBroadcast.Interval = 1000;
            this.timerSendBroadcast.Tick += new System.EventHandler(this.timerSendBroadcast_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images.jpg");
            // 
            // timerUpdateHost
            // 
            this.timerUpdateHost.Enabled = true;
            this.timerUpdateHost.Interval = 3000;
            this.timerUpdateHost.Tick += new System.EventHandler(this.timerUpdateHost_Tick);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(578, 187);
            this.btnsend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(64, 27);
            this.btnsend.TabIndex = 12;
            this.btnsend.Text = "G&ửi";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lstChat
            // 
            this.lstChat.FormattingEnabled = true;
            this.lstChat.ItemHeight = 16;
            this.lstChat.Location = new System.Drawing.Point(236, 221);
            this.lstChat.Name = "lstChat";
            this.lstChat.ScrollAlwaysVisible = true;
            this.lstChat.Size = new System.Drawing.Size(406, 132);
            this.lstChat.TabIndex = 11;
            // 
            // txtchat
            // 
            this.txtchat.Location = new System.Drawing.Point(236, 189);
            this.txtchat.Name = "txtchat";
            this.txtchat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtchat.Size = new System.Drawing.Size(336, 23);
            this.txtchat.TabIndex = 10;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(236, 160);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(123, 23);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "Gửi tin mạng LAN";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(12, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(180, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Danh sách các máy đang chờ";
            // 
            // lstHost
            // 
            this.lstHost.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHost.FullRowSelect = true;
            this.lstHost.GridLines = true;
            this.lstHost.LargeImageList = this.imageList1;
            this.lstHost.Location = new System.Drawing.Point(12, 39);
            this.lstHost.MultiSelect = false;
            this.lstHost.Name = "lstHost";
            this.lstHost.Size = new System.Drawing.Size(206, 360);
            this.lstHost.TabIndex = 15;
            this.lstHost.UseCompatibleStateImageBehavior = false;
            this.lstHost.View = System.Windows.Forms.View.Tile;
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(553, 370);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "T&hoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGame.Image = global::Chess_Programming.Properties.Resources.Savedata;
            this.btnJoinGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJoinGame.Location = new System.Drawing.Point(236, 98);
            this.btnJoinGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(145, 55);
            this.btnJoinGame.TabIndex = 2;
            this.btnJoinGame.Text = "Vào phòng chơi";
            this.btnJoinGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJoinGame.UseVisualStyleBackColor = true;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // btnHostGame
            // 
            this.btnHostGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHostGame.Image = ((System.Drawing.Image)(resources.GetObject("btnHostGame.Image")));
            this.btnHostGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHostGame.Location = new System.Drawing.Point(236, 39);
            this.btnHostGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHostGame.Name = "btnHostGame";
            this.btnHostGame.Size = new System.Drawing.Size(145, 51);
            this.btnHostGame.TabIndex = 1;
            this.btnHostGame.Text = "Tạo phòng chơi";
            this.btnHostGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHostGame.UseVisualStyleBackColor = true;
            this.btnHostGame.Click += new System.EventHandler(this.btnHostGame_Click);
            // 
            // frmFindGame
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 416);
            this.ControlBox = false;
            this.Controls.Add(this.lstHost);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtchat);
            this.Controls.Add(this.btnJoinGame);
            this.Controls.Add(this.btnHostGame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFindGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Phòng Chơi - Cờ Vua CĐTH07A";
            this.Load += new System.EventHandler(this.frmFindGame_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindGame_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHostGame;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerSendBroadcast;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerUpdateHost;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.TextBox txtchat;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ListView lstHost;
    }
}