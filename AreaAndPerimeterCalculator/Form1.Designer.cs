namespace AreaAndPerimeterCalculator
{
    partial class frmCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.btnCalculateAreaPerimeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(106, 13);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(44, 15);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(111, 60);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(39, 15);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(119, 108);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(31, 15);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perimeter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(156, 13);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 23);
            this.txtLength.TabIndex = 1;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(156, 60);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 23);
            this.txtWidth.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(156, 108);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 23);
            this.txtArea.TabIndex = 6;
            this.txtArea.TabStop = false;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(156, 155);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(100, 23);
            this.txtPerimeter.TabIndex = 7;
            this.txtPerimeter.TabStop = false;
            // 
            // btnCalculateAreaPerimeter
            // 
            this.btnCalculateAreaPerimeter.Location = new System.Drawing.Point(92, 201);
            this.btnCalculateAreaPerimeter.Name = "btnCalculateAreaPerimeter";
            this.btnCalculateAreaPerimeter.Size = new System.Drawing.Size(164, 87);
            this.btnCalculateAreaPerimeter.TabIndex = 3;
            this.btnCalculateAreaPerimeter.Text = "Calculate Area and Perimeter";
            this.btnCalculateAreaPerimeter.UseVisualStyleBackColor = true;
            this.btnCalculateAreaPerimeter.Click += new System.EventHandler(this.btnCalculateAreaPerimeter_Click);
            // 
            // frmCalc
            // 
            this.AcceptButton = this.btnCalculateAreaPerimeter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 322);
            this.Controls.Add(this.btnCalculateAreaPerimeter);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmCalc";
            this.Text = "Area and Perimeter Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private Label lblArea;
        private Label label4;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Button btnCalculateAreaPerimeter;
    }
}