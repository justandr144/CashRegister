namespace CashRegister
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.smallButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.largeButton = new System.Windows.Forms.Button();
            this.xLargeButton = new System.Windows.Forms.Button();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppingsText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(-13, -6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(684, 80);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Bear\'s Pizza Parlour";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.sizeLabel.Location = new System.Drawing.Point(12, 104);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(100, 24);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Pizza Size:";
            // 
            // smallButton
            // 
            this.smallButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.smallButton.FlatAppearance.BorderSize = 4;
            this.smallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.smallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallButton.ForeColor = System.Drawing.SystemColors.Control;
            this.smallButton.Location = new System.Drawing.Point(145, 99);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(100, 39);
            this.smallButton.TabIndex = 2;
            this.smallButton.Text = "Small";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.Click += new System.EventHandler(this.SmallButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mediumButton.FlatAppearance.BorderSize = 4;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.SystemColors.Control;
            this.mediumButton.Location = new System.Drawing.Point(261, 99);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(100, 39);
            this.mediumButton.TabIndex = 3;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // largeButton
            // 
            this.largeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.largeButton.FlatAppearance.BorderSize = 4;
            this.largeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.largeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.largeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.largeButton.Location = new System.Drawing.Point(377, 99);
            this.largeButton.Name = "largeButton";
            this.largeButton.Size = new System.Drawing.Size(100, 39);
            this.largeButton.TabIndex = 4;
            this.largeButton.Text = "Large";
            this.largeButton.UseVisualStyleBackColor = true;
            this.largeButton.Click += new System.EventHandler(this.LargeButton_Click);
            // 
            // xLargeButton
            // 
            this.xLargeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.xLargeButton.FlatAppearance.BorderSize = 4;
            this.xLargeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.xLargeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xLargeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLargeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.xLargeButton.Location = new System.Drawing.Point(493, 99);
            this.xLargeButton.Name = "xLargeButton";
            this.xLargeButton.Size = new System.Drawing.Size(100, 39);
            this.xLargeButton.TabIndex = 5;
            this.xLargeButton.Text = "xLarge";
            this.xLargeButton.UseVisualStyleBackColor = true;
            this.xLargeButton.Click += new System.EventHandler(this.XLargeButton_Click);
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.toppingsLabel.Location = new System.Drawing.Point(12, 187);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(189, 24);
            this.toppingsLabel.TabIndex = 6;
            this.toppingsLabel.Text = "Number of Toppings:";
            // 
            // toppingsText
            // 
            this.toppingsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsText.Location = new System.Drawing.Point(261, 184);
            this.toppingsText.Name = "toppingsText";
            this.toppingsText.Size = new System.Drawing.Size(332, 29);
            this.toppingsText.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.BorderSize = 4;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.calculateButton.Location = new System.Drawing.Point(245, 252);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(164, 64);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(110, 338);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(425, 86);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.toppingsText);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.xLargeButton);
            this.Controls.Add(this.largeButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.smallButton);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Bear\'s Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button smallButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button largeButton;
        private System.Windows.Forms.Button xLargeButton;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.TextBox toppingsText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

