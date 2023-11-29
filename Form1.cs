using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        private int row;
        private int col;
        private double[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            row = int.Parse(textrows.Text);
            col = int.Parse(textcolumns.Text);
            matrix = new double[row, col];
            CreateMatrixInputs();
        }
        private void CreateMatrixInputs()
        {
            panelMatrix.Controls.Clear();
            int x = 20;
            int y = 20;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    TextBox txtBox = new TextBox();
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = $"X{j}";
                    if (j == col - 1)
                        label.Text = $"B";
                    label.Location = new System.Drawing.Point(x, 0);
                    label.Size = new System.Drawing.Size(40, 20);
                    txtBox.Name = "txtMatrix_" + i + "_" + j;
                    txtBox.Location = new System.Drawing.Point(x, y);
                    txtBox.Size = new System.Drawing.Size(40, 20);
                    panelMatrix.Controls.Add(txtBox);
                    panelMatrix.Controls.Add(label);
                    x += 50;
                }
                x = 20; y += 30;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ReadMatrixValues();
            void ReadMatrixValues()
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        TextBox txtBox = (TextBox)panelMatrix.Controls["txtMatrix_" + i + "_" + j];
                        matrix[i, j] = double.Parse(txtBox.Text);
                    }
                }
            }
            for (int i1 = 0; i1 < row; i1++)
            {

                int maxRow = 0;
                for (int j = i1 + 1; j < row; j++)
                {
                    if (matrix[i1, i1] == 0)
                    {
                        maxRow = j;
                        break;
                    }
                }

                double[] temp = new double[row + 1];
                for (int k = 0; k < row + 1; k++)
                {
                    temp[k] = matrix[i1, k];
                    matrix[i1, k] = matrix[maxRow, k];
                    matrix[maxRow, k] = temp[k];
                }

                for (int i = 0; i < row; i++)
                {
                    

                    for (int j = i + 1; j < row; j++)
                    {
                        double d = matrix[i, i] * matrix[j, j] - matrix[i, j] * matrix[j, i];
                        if (d == 0)
                        {
                            MessageBox.Show("The system has many solution.");
                            return;
                        }
                        double factor = -matrix[j, i] / matrix[i, i];
                        for (int k = i; k < col; k++)
                        {
                            matrix[j, k] += factor * matrix[i, k];
                        }
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    double x1 = matrix[i, i];
                    for (int j = 0; j < col; j++)
                    {
                        matrix[i, j] = matrix[i, j] / x1;
                    }
                }
                int x = 20; int y = 20;

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        TextBox txtBox = new TextBox();
                        txtBox.Name = "txtMatrix_" + i + "_" + j;
                        txtBox.Location = new System.Drawing.Point(x, y);
                        txtBox.Size = new System.Drawing.Size(40, 20);
                        Label label = new Label();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Text = $"X{j}";
                        if (j == col - 1)
                            label.Text = $"B";
                        label.Location = new System.Drawing.Point(x, 0);
                        label.Size = new System.Drawing.Size(40, 20);
                        panel1.Controls.Add(txtBox);
                        panel1.Controls.Add(label);
                        txtBox.Text = $"{matrix[i, j]}";
                        x += 50;
                    }
                    x = 20; y += 30;
                }

                double[] solutionn = new double[row];
                for (int i = row - 1; i >= 0; i--)
                {
                    solutionn[i] = matrix[i, row] / matrix[i, i];
                    for (int k = i - 1; k >= 0; k--)
                        matrix[k, row] -= matrix[k, i] * solutionn[i];
                }

                int c = 20;
                for (int i = 0; i < row; i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(c, 20);
                    textBox.Size = new System.Drawing.Size(70, 40);
                    panel2.Controls.Add(textBox);
                    c += 70;
                }

                for (int i = 0; i < row; i++)
                {
                    TextBox textBox = (TextBox)panel2.Controls[i];
                    textBox.Text = $" X{i + 1} = {solutionn[i]}";
                }
            }
        }
        private void panelMatrix_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
       
    

