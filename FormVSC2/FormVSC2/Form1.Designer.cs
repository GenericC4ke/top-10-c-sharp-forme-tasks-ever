namespace FormVSC2
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginText = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.Label();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.FreakBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlertImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(22, 616);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(297, 54);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Enter The Colloseum";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginText.ForeColor = System.Drawing.Color.White;
            this.LoginText.Location = new System.Drawing.Point(15, 198);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(147, 42);
            this.LoginText.TabIndex = 1;
            this.LoginText.Text = "Username:";
            this.LoginText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginText.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginInput
            // 
            this.LoginInput.BackColor = System.Drawing.Color.Gray;
            this.LoginInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginInput.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginInput.Location = new System.Drawing.Point(168, 200);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(162, 34);
            this.LoginInput.TabIndex = 2;
            this.LoginInput.TextChanged += new System.EventHandler(this.LoginInput_TextChanged);
            // 
            // PassText
            // 
            this.PassText.AutoSize = true;
            this.PassText.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassText.ForeColor = System.Drawing.Color.White;
            this.PassText.Location = new System.Drawing.Point(26, 277);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(136, 42);
            this.PassText.TabIndex = 3;
            this.PassText.Text = "Password:";
            this.PassText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassInput
            // 
            this.PassInput.BackColor = System.Drawing.Color.Gray;
            this.PassInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassInput.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PassInput.Location = new System.Drawing.Point(168, 285);
            this.PassInput.Name = "PassInput";
            this.PassInput.Size = new System.Drawing.Size(162, 34);
            this.PassInput.TabIndex = 4;
            this.PassInput.TextChanged += new System.EventHandler(this.PassInput_TextChanged);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.ForeColor = System.Drawing.Color.White;
            this.TextLabel.Location = new System.Drawing.Point(79, 27);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(174, 58);
            this.TextLabel.TabIndex = 6;
            this.TextLabel.Text = "Welcome";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.White;
            this.InfoLabel.Location = new System.Drawing.Point(34, 105);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(296, 30);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "please login down below to proceed";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FreakBox
            // 
            this.FreakBox.AutoSize = true;
            this.FreakBox.Location = new System.Drawing.Point(124, 437);
            this.FreakBox.Name = "FreakBox";
            this.FreakBox.Size = new System.Drawing.Size(15, 14);
            this.FreakBox.TabIndex = 8;
            this.FreakBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FreakBox.UseVisualStyleBackColor = true;
            this.FreakBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(23, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "messages will pop up here at times";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AlertImage
            // 
            this.AlertImage.BackgroundImage = global::FormVSC2.Properties.Resources.handsome1;
            this.AlertImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlertImage.Location = new System.Drawing.Point(89, 411);
            this.AlertImage.Name = "AlertImage";
            this.AlertImage.Size = new System.Drawing.Size(167, 187);
            this.AlertImage.TabIndex = 5;
            this.AlertImage.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(342, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FreakBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.AlertImage);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.LoginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.Text = "the networkings";
            ((System.ComponentModel.ISupportInitialize)(this.AlertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label PassText;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.PictureBox AlertImage;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.CheckBox FreakBox;
        private System.Windows.Forms.Label label1;
    }
}

