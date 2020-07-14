namespace FinalCardGamePro
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button_speak = new System.Windows.Forms.Button();
            this.bt_mute = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_top = new System.Windows.Forms.Button();
            this.bt_go = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button_speak);
            this.splitContainer1.Panel2.Controls.Add(this.bt_mute);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.bt_top);
            this.splitContainer1.Panel2.Controls.Add(this.bt_go);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 661);
            this.splitContainer1.SplitterDistance = 877;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(102, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_speak
            // 
            this.button_speak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_speak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_speak.BackgroundImage")));
            this.button_speak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_speak.Location = new System.Drawing.Point(176, 468);
            this.button_speak.Name = "button_speak";
            this.button_speak.Size = new System.Drawing.Size(73, 50);
            this.button_speak.TabIndex = 13;
            this.button_speak.UseVisualStyleBackColor = false;
            this.button_speak.Click += new System.EventHandler(this.button_speak_Click);
            // 
            // bt_mute
            // 
            this.bt_mute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_mute.BackgroundImage")));
            this.bt_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_mute.Location = new System.Drawing.Point(67, 468);
            this.bt_mute.Name = "bt_mute";
            this.bt_mute.Size = new System.Drawing.Size(73, 50);
            this.bt_mute.TabIndex = 12;
            this.bt_mute.UseVisualStyleBackColor = false;
            this.bt_mute.Click += new System.EventHandler(this.bt_mute_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 63);
            this.button2.TabIndex = 11;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bt_top
            // 
            this.bt_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_top.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_top.Location = new System.Drawing.Point(50, 276);
            this.bt_top.Name = "bt_top";
            this.bt_top.Size = new System.Drawing.Size(199, 58);
            this.bt_top.TabIndex = 10;
            this.bt_top.Text = "Top Player";
            this.bt_top.UseVisualStyleBackColor = false;
            // 
            // bt_go
            // 
            this.bt_go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_go.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_go.Location = new System.Drawing.Point(90, 187);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(126, 57);
            this.bt_go.TabIndex = 9;
            this.bt_go.Text = "Go";
            this.bt_go.UseVisualStyleBackColor = false;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(40, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 116);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Flip Card Game Play";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1250, 730);
            this.MinimumSize = new System.Drawing.Size(1150, 680);
            this.Name = "welcome";
            this.Text = "Memory Card Game";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.welcome_FormClosing);
            this.Load += new System.EventHandler(this.welcome_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_top;
        private System.Windows.Forms.Button bt_go;
        private System.Windows.Forms.Button bt_mute;
        private System.Windows.Forms.Button button_speak;
        private System.Windows.Forms.Button button1;
    }
}

