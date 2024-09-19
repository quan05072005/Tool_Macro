namespace Tool_Macro
{
    partial class Tool
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
            this.CheckTriggerbot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Screen_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckTriggerbot
            // 
            this.CheckTriggerbot.AutoSize = true;
            this.CheckTriggerbot.Location = new System.Drawing.Point(31, 31);
            this.CheckTriggerbot.Name = "CheckTriggerbot";
            this.CheckTriggerbot.Size = new System.Drawing.Size(104, 17);
            this.CheckTriggerbot.TabIndex = 0;
            this.CheckTriggerbot.Text = "checkTriggerbot";
            this.CheckTriggerbot.UseVisualStyleBackColor = true;
            this.CheckTriggerbot.CheckedChanged += new System.EventHandler(this.CheckTriggerbot_CheckedChanged);
            this.CheckTriggerbot.CheckStateChanged += new System.EventHandler(this.CheckTriggerbot_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Screen_pic
            // 
            this.Screen_pic.Location = new System.Drawing.Point(31, 54);
            this.Screen_pic.Name = "Screen_pic";
            this.Screen_pic.Size = new System.Drawing.Size(989, 496);
            this.Screen_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Screen_pic.TabIndex = 2;
            this.Screen_pic.TabStop = false;
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 582);
            this.Controls.Add(this.Screen_pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckTriggerbot);
            this.Name = "Tool";
            this.Text = "Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tool_FormClosed);
            this.Load += new System.EventHandler(this.Tool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Screen_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckTriggerbot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Screen_pic;
    }
}