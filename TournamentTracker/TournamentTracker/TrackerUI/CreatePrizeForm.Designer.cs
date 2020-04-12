namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.palceNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.palceNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Blue;
            this.headerLabel.Location = new System.Drawing.Point(11, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 50);
            this.headerLabel.TabIndex = 14;
            this.headerLabel.Text = "Create Prize";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(197, 72);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(162, 35);
            this.placeNumberValue.TabIndex = 18;
            // 
            // palceNumberLabel
            // 
            this.palceNumberLabel.AutoSize = true;
            this.palceNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.palceNumberLabel.ForeColor = System.Drawing.Color.Blue;
            this.palceNumberLabel.Location = new System.Drawing.Point(29, 69);
            this.palceNumberLabel.Name = "palceNumberLabel";
            this.palceNumberLabel.Size = new System.Drawing.Size(177, 37);
            this.palceNumberLabel.TabIndex = 17;
            this.palceNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(197, 124);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(162, 35);
            this.placeNameValue.TabIndex = 20;
            // 
            // palceNameLabel
            // 
            this.palceNameLabel.AutoSize = true;
            this.palceNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.palceNameLabel.ForeColor = System.Drawing.Color.Blue;
            this.palceNameLabel.Location = new System.Drawing.Point(29, 121);
            this.palceNameLabel.Name = "palceNameLabel";
            this.palceNameLabel.Size = new System.Drawing.Size(152, 37);
            this.palceNameLabel.TabIndex = 19;
            this.palceNameLabel.Text = "Place Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 35);
            this.textBox1.TabIndex = 22;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.Blue;
            this.prizeAmountLabel.Location = new System.Drawing.Point(29, 173);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(174, 37);
            this.prizeAmountLabel.TabIndex = 21;
            this.prizeAmountLabel.Text = "Place Amount";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(197, 299);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(162, 35);
            this.prizePercentageValue.TabIndex = 24;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.Blue;
            this.prizePercentageLabel.Location = new System.Drawing.Point(29, 296);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(102, 37);
            this.prizePercentageLabel.TabIndex = 23;
            this.prizePercentageLabel.Text = "Prize %";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.orLabel.ForeColor = System.Drawing.Color.Blue;
            this.orLabel.Location = new System.Drawing.Point(241, 240);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(60, 37);
            this.orLabel.TabIndex = 25;
            this.orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.Blue;
            this.createPrizeButton.Location = new System.Drawing.Point(46, 416);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(293, 66);
            this.createPrizeButton.TabIndex = 27;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 530);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.palceNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.palceNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label palceNumberLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label palceNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}