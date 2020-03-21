using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixOperations
{
    public partial class Form1 : Form
    {
        const int nMax = 100;
        const int mMax = 8;
        int n, m, k;
        int[,] arr1 = new int[nMax, mMax];
        int[,] arr2 = new int[nMax, mMax];

        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr1[i, j] = r.Next(-10, 10);
                    dataGridView1[j, i].Value = arr1[i, j];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr2[i, j] = r.Next(-10, 10);
                    dataGridView2[j, i].Value = arr2[i,j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(k)
            {
                case 0:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            dataGridView3.Rows.Add();
                            for (int j = 0; j < m; j++)
                                dataGridView3[j, i].Value = arr1[i, j] + arr2[i, j];
                        }
                    }
                    break;
                case 1:
                    {
                        int q = Convert.ToInt16(textBox3.Text);
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < m; j++)
                                dataGridView2[j, i].Value = arr1[i, j] * q;
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            dataGridView3.Rows.Add();
                            for (int j = 0; j < m; j++)
                                dataGridView3[j, i].Value = arr1[i, j] * arr2[i, j];
                        }
                    }
                    break;
                case 3:
                    {
                        for(int i=0; i<n; i++)
                            for(int j=0; j<m; j++)
                            {
                                arr2[i, j] = arr1[j, i];
                                dataGridView2[j, i].Value = arr2[i, j];
                            }
                    }
                    break;
                case 4:
                    {
                        int q = Convert.ToInt16(textBox3.Text);
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < m; j++)
                                dataGridView2[j, i].Value = Math.Pow(arr1[i, j], q);
                    }
                    break;
                        default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            textBox3.Visible = false;
            label5.Visible = false;
            k = comboBox1.SelectedIndex;
            switch (k)
            {
                case 0:
                    dataGridView3.Visible = true;
                    break;
                case 1:
                    textBox3.Visible = true;
                    label5.Visible = true;
                    break;
                case 2:
                    dataGridView3.Visible = true;
                    break;
                case 4:
                    textBox3.Visible = true;
                    label5.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(textBox1.Text);
            m = Convert.ToInt16(textBox2.Text);
            for(int i=0; i<n; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
            }
            button1.Enabled = false;
        }
    }
}
