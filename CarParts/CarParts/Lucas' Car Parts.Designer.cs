namespace CarParts
{
    partial class frmCarParts
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
            this.btnCalculateDefault = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalDollars = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblCarPart = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.btnCalculateOverloaded = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.rdbCarParts = new System.Windows.Forms.RadioButton();
            this.rdbAdditional = new System.Windows.Forms.RadioButton();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculateDefault
            // 
            this.btnCalculateDefault.Location = new System.Drawing.Point(29, 273);
            this.btnCalculateDefault.Name = "btnCalculateDefault";
            this.btnCalculateDefault.Size = new System.Drawing.Size(117, 23);
            this.btnCalculateDefault.TabIndex = 14;
            this.btnCalculateDefault.Text = "Calculate &Default";
            this.btnCalculateDefault.UseVisualStyleBackColor = true;
            this.btnCalculateDefault.Click += new System.EventHandler(this.btnCalculateDefault_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(29, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalDollars
            // 
            this.lblTotalDollars.AutoSize = true;
            this.lblTotalDollars.Location = new System.Drawing.Point(97, 204);
            this.lblTotalDollars.Name = "lblTotalDollars";
            this.lblTotalDollars.Size = new System.Drawing.Size(0, 13);
            this.lblTotalDollars.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(66, 204);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(81, 89);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(133, 86);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(99, 20);
            this.txtQty.TabIndex = 4;
            this.txtQty.Text = "0";
            // 
            // lblCarPart
            // 
            this.lblCarPart.AutoSize = true;
            this.lblCarPart.Location = new System.Drawing.Point(81, 19);
            this.lblCarPart.Name = "lblCarPart";
            this.lblCarPart.Size = new System.Drawing.Size(45, 13);
            this.lblCarPart.TabIndex = 1;
            this.lblCarPart.Text = "Car Part";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(87, 52);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price    $";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(133, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 20);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "0.00";
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(132, 12);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(100, 20);
            this.txtPart.TabIndex = 0;
            // 
            // btnCalculateOverloaded
            // 
            this.btnCalculateOverloaded.Location = new System.Drawing.Point(168, 272);
            this.btnCalculateOverloaded.Name = "btnCalculateOverloaded";
            this.btnCalculateOverloaded.Size = new System.Drawing.Size(117, 23);
            this.btnCalculateOverloaded.TabIndex = 15;
            this.btnCalculateOverloaded.Text = "Calculate &Overloaded";
            this.btnCalculateOverloaded.UseVisualStyleBackColor = true;
            this.btnCalculateOverloaded.Click += new System.EventHandler(this.btnCalculateOverloaded_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(71, 128);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(55, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Car Model";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(132, 121);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            // 
            // rdbCarParts
            // 
            this.rdbCarParts.AutoSize = true;
            this.rdbCarParts.Location = new System.Drawing.Point(29, 236);
            this.rdbCarParts.Name = "rdbCarParts";
            this.rdbCarParts.Size = new System.Drawing.Size(68, 17);
            this.rdbCarParts.TabIndex = 12;
            this.rdbCarParts.TabStop = true;
            this.rdbCarParts.Text = "Car Parts";
            this.rdbCarParts.UseVisualStyleBackColor = true;
            this.rdbCarParts.CheckedChanged += new System.EventHandler(this.rdbCarParts_CheckedChanged);
            // 
            // rdbAdditional
            // 
            this.rdbAdditional.AutoSize = true;
            this.rdbAdditional.Location = new System.Drawing.Point(168, 236);
            this.rdbAdditional.Name = "rdbAdditional";
            this.rdbAdditional.Size = new System.Drawing.Size(117, 17);
            this.rdbAdditional.TabIndex = 13;
            this.rdbAdditional.TabStop = true;
            this.rdbAdditional.Text = "Additional Car Parts";
            this.rdbAdditional.UseVisualStyleBackColor = true;
            this.rdbAdditional.CheckedChanged += new System.EventHandler(this.rdbAdditional_CheckedChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(97, 163);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(133, 156);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 8;
            // 
            // frmCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 341);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.rdbAdditional);
            this.Controls.Add(this.rdbCarParts);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.btnCalculateOverloaded);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotalDollars);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblCarPart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateDefault);
            this.Name = "frmCarParts";
            this.Text = "Lucas\' Honest Car Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateDefault;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalDollars;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblCarPart;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Button btnCalculateOverloaded;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.RadioButton rdbCarParts;
        private System.Windows.Forms.RadioButton rdbAdditional;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;

    }
}

