namespace FormVSC4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InformativeLabel = new System.Windows.Forms.Label();
            this.UpgradeButton = new System.Windows.Forms.Button();
            this.UpgradeLabel = new System.Windows.Forms.Label();
            this.StatPowerLabel = new System.Windows.Forms.Label();
            this.StatTotalLabel = new System.Windows.Forms.Label();
            this.ClickDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatTotal = new System.Windows.Forms.Label();
            this.StatPower = new System.Windows.Forms.Label();
            this.MistakeLabel = new System.Windows.Forms.Label();
            this.DaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InformativeLabel
            // 
            this.InformativeLabel.AutoSize = true;
            this.InformativeLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel.Location = new System.Drawing.Point(114, 9);
            this.InformativeLabel.Name = "InformativeLabel";
            this.InformativeLabel.Size = new System.Drawing.Size(257, 42);
            this.InformativeLabel.TabIndex = 0;
            this.InformativeLabel.Text = "hi click the damn moji";
            // 
            // UpgradeButton
            // 
            this.UpgradeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeButton.Location = new System.Drawing.Point(257, 240);
            this.UpgradeButton.Name = "UpgradeButton";
            this.UpgradeButton.Size = new System.Drawing.Size(150, 60);
            this.UpgradeButton.TabIndex = 2;
            this.UpgradeButton.Text = "Upgrade";
            this.UpgradeButton.UseVisualStyleBackColor = false;
            this.UpgradeButton.Click += new System.EventHandler(this.UpgradeButton_Click);
            // 
            // UpgradeLabel
            // 
            this.UpgradeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpgradeLabel.AutoSize = true;
            this.UpgradeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeLabel.Location = new System.Drawing.Point(74, 313);
            this.UpgradeLabel.Name = "UpgradeLabel";
            this.UpgradeLabel.Size = new System.Drawing.Size(333, 23);
            this.UpgradeLabel.TabIndex = 3;
            this.UpgradeLabel.Text = "Your power was upgraded to x00!!!!!!";
            this.UpgradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatPowerLabel
            // 
            this.StatPowerLabel.AutoSize = true;
            this.StatPowerLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPowerLabel.Location = new System.Drawing.Point(12, 429);
            this.StatPowerLabel.Name = "StatPowerLabel";
            this.StatPowerLabel.Size = new System.Drawing.Size(143, 23);
            this.StatPowerLabel.TabIndex = 4;
            this.StatPowerLabel.Text = "Current Power:";
            // 
            // StatTotalLabel
            // 
            this.StatTotalLabel.AutoSize = true;
            this.StatTotalLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatTotalLabel.Location = new System.Drawing.Point(12, 406);
            this.StatTotalLabel.Name = "StatTotalLabel";
            this.StatTotalLabel.Size = new System.Drawing.Size(119, 23);
            this.StatTotalLabel.TabIndex = 5;
            this.StatTotalLabel.Text = "Total Clicks:";
            // 
            // ClickDisplay
            // 
            this.ClickDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClickDisplay.AutoSize = true;
            this.ClickDisplay.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickDisplay.Location = new System.Drawing.Point(251, 182);
            this.ClickDisplay.Name = "ClickDisplay";
            this.ClickDisplay.Size = new System.Drawing.Size(120, 55);
            this.ClickDisplay.TabIndex = 6;
            this.ClickDisplay.Text = "0000";
            this.ClickDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClickDisplay.Click += new System.EventHandler(this.ClickDisplay_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clicks:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatTotal
            // 
            this.StatTotal.AutoSize = true;
            this.StatTotal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatTotal.Location = new System.Drawing.Point(189, 406);
            this.StatTotal.Name = "StatTotal";
            this.StatTotal.Size = new System.Drawing.Size(43, 23);
            this.StatTotal.TabIndex = 9;
            this.StatTotal.Text = "000";
            // 
            // StatPower
            // 
            this.StatPower.AutoSize = true;
            this.StatPower.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPower.Location = new System.Drawing.Point(189, 429);
            this.StatPower.Name = "StatPower";
            this.StatPower.Size = new System.Drawing.Size(43, 23);
            this.StatPower.TabIndex = 8;
            this.StatPower.Text = "000";
            // 
            // MistakeLabel
            // 
            this.MistakeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MistakeLabel.AutoSize = true;
            this.MistakeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MistakeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MistakeLabel.Location = new System.Drawing.Point(74, 336);
            this.MistakeLabel.Name = "MistakeLabel";
            this.MistakeLabel.Size = new System.Drawing.Size(294, 23);
            this.MistakeLabel.TabIndex = 10;
            this.MistakeLabel.Text = "You need 0000 clicks to upgrade!";
            this.MistakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaveButton
            // 
            this.DaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DaveButton.BackgroundImage = global::FormVSC4.Properties.Resources.finch4;
            this.DaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaveButton.Location = new System.Drawing.Point(75, 150);
            this.DaveButton.Name = "DaveButton";
            this.DaveButton.Size = new System.Drawing.Size(150, 150);
            this.DaveButton.TabIndex = 1;
            this.DaveButton.UseVisualStyleBackColor = false;
            this.DaveButton.Click += new System.EventHandler(this.DaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.MistakeLabel);
            this.Controls.Add(this.StatTotal);
            this.Controls.Add(this.StatPower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClickDisplay);
            this.Controls.Add(this.StatTotalLabel);
            this.Controls.Add(this.StatPowerLabel);
            this.Controls.Add(this.UpgradeLabel);
            this.Controls.Add(this.UpgradeButton);
            this.Controls.Add(this.DaveButton);
            this.Controls.Add(this.InformativeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "David Fynch Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformativeLabel;
        private System.Windows.Forms.Button DaveButton;
        private System.Windows.Forms.Button UpgradeButton;
        private System.Windows.Forms.Label UpgradeLabel;
        private System.Windows.Forms.Label StatPowerLabel;
        private System.Windows.Forms.Label StatTotalLabel;
        private System.Windows.Forms.Label ClickDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatTotal;
        private System.Windows.Forms.Label StatPower;
        private System.Windows.Forms.Label MistakeLabel;
    }
}

