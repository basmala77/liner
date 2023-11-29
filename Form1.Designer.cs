namespace WindowsFormsApp13
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
            this.textrows = new System.Windows.Forms.TextBox();
            this.textcolumns = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textrows
            // 
            this.textrows.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrows.Location = new System.Drawing.Point(81, 19);
            this.textrows.Name = "textrows";
            this.textrows.Size = new System.Drawing.Size(57, 23);
            this.textrows.TabIndex = 0;
            this.textrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textcolumns
            // 
            this.textcolumns.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcolumns.Location = new System.Drawing.Point(81, 61);
            this.textcolumns.Margin = new System.Windows.Forms.Padding(5);
            this.textcolumns.Name = "textcolumns";
            this.textcolumns.Size = new System.Drawing.Size(57, 23);
            this.textcolumns.TabIndex = 1;
            this.textcolumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(187, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Matrix : ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMatrix
            // 
            this.panelMatrix.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMatrix.Location = new System.Drawing.Point(268, 3);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(314, 145);
            this.panelMatrix.TabIndex = 3;
            this.panelMatrix.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMatrix_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Column";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(187, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Solve";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(119, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 104);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(57, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 49);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMatrix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textcolumns);
            this.Controls.Add(this.textrows);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textrows;
        private System.Windows.Forms.TextBox textcolumns;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

