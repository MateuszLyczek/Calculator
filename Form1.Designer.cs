namespace Calculator.WindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bComma = new System.Windows.Forms.Button();
            this.bDivision = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSubtract = new System.Windows.Forms.Button();
            this.bMultiplication = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bResult = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.b1.Location = new System.Drawing.Point(9, 68);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 60);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(75, 68);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(60, 60);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(141, 68);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 60);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(9, 134);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(60, 60);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b5.Location = new System.Drawing.Point(75, 134);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(60, 60);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b6.Location = new System.Drawing.Point(141, 134);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(60, 60);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b7.Location = new System.Drawing.Point(9, 200);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(60, 60);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b8.Location = new System.Drawing.Point(75, 200);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(60, 60);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b9.Location = new System.Drawing.Point(141, 200);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(60, 60);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b0.Location = new System.Drawing.Point(9, 266);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(126, 60);
            this.b0.TabIndex = 9;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // bComma
            // 
            this.bComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bComma.Location = new System.Drawing.Point(141, 266);
            this.bComma.Name = "bComma";
            this.bComma.Size = new System.Drawing.Size(60, 60);
            this.bComma.TabIndex = 10;
            this.bComma.Text = ",";
            this.bComma.UseVisualStyleBackColor = true;
            this.bComma.Click += new System.EventHandler(this.OnBtnNrClick);
            // 
            // bDivision
            // 
            this.bDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDivision.Location = new System.Drawing.Point(207, 68);
            this.bDivision.Name = "bDivision";
            this.bDivision.Size = new System.Drawing.Size(60, 60);
            this.bDivision.TabIndex = 11;
            this.bDivision.Text = "/";
            this.bDivision.UseVisualStyleBackColor = true;
            this.bDivision.ClientSizeChanged += new System.EventHandler(this.OnBtnOperationClick);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.Location = new System.Drawing.Point(273, 68);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(60, 126);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.OnBtnOperationClick);
            // 
            // bSubtract
            // 
            this.bSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSubtract.Location = new System.Drawing.Point(207, 134);
            this.bSubtract.Name = "bSubtract";
            this.bSubtract.Size = new System.Drawing.Size(60, 60);
            this.bSubtract.TabIndex = 13;
            this.bSubtract.Text = "-";
            this.bSubtract.UseVisualStyleBackColor = true;
            this.bSubtract.Click += new System.EventHandler(this.OnBtnOperationClick);
            // 
            // bMultiplication
            // 
            this.bMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMultiplication.Location = new System.Drawing.Point(207, 200);
            this.bMultiplication.Name = "bMultiplication";
            this.bMultiplication.Size = new System.Drawing.Size(60, 60);
            this.bMultiplication.TabIndex = 14;
            this.bMultiplication.Text = "*";
            this.bMultiplication.UseVisualStyleBackColor = true;
            this.bMultiplication.Click += new System.EventHandler(this.OnBtnOperationClick);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bClear.Location = new System.Drawing.Point(207, 266);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(60, 60);
            this.bClear.TabIndex = 15;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.OnBtnClearClick);
            // 
            // bResult
            // 
            this.bResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bResult.Location = new System.Drawing.Point(271, 200);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(60, 126);
            this.bResult.TabIndex = 16;
            this.bResult.Text = "=";
            this.bResult.UseVisualStyleBackColor = true;
            this.bResult.Click += new System.EventHandler(this.OnBtnResultClick);
            // 
            // screen
            // 
            this.screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.screen.Location = new System.Drawing.Point(9, 17);
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(324, 45);
            this.screen.TabIndex = 17;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.screen.UseWaitCursor = true;
            this.screen.TextChanged += new System.EventHandler(this.OnBtnNrClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 336);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bMultiplication);
            this.Controls.Add(this.bSubtract);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bDivision);
            this.Controls.Add(this.bComma);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bComma;
        private System.Windows.Forms.Button bDivision;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSubtract;
        private System.Windows.Forms.Button bMultiplication;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.TextBox screen;
    }
}
