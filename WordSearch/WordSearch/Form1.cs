using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VirtualJudge
{
    public partial class Form1 : Form
    {
        string[] filePaths;
        

        public Form1()
        {
            InitializeComponent();
        }

        private bool searchWord(string s)
        {
            if (s.Contains(comboBox2.Text) && s.Contains(comboBox3.Text) && s.Contains(comboBox4.Text)) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                filePaths = Directory.GetFiles(@comboBox1.Text, "*",
                             SearchOption.AllDirectories);

                
                int index = 0;
                for (int i = 0; i < filePaths.Length;i++ )
                {
                    string text = File.ReadAllText(@filePaths[i], Encoding.UTF8);
                    if(searchWord(text))
                    {
                        index++;
                    }
                }
                //MessageBox.Show("done!");

                label1.Text = index.ToString() + " result found!";
                string[] newFound = new string[index];
                index = 0;
                for (int i = 0; i < filePaths.Length; i++)
                {
                    string text = File.ReadAllText(@filePaths[i], Encoding.UTF8);
                    if (searchWord(text))
                    {
                        newFound[index] = filePaths[i].ToString();
                        index++;
                    }
                }

                var bindableNames = from name in newFound
                                    select new { Names = name };
                dataGridView1.DataSource = bindableNames.ToList();
            }
            catch
            {

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                string value1 = dataGridView1.Rows[index].Cells[0].Value.ToString();
                System.Diagnostics.Process.Start(@value1);
            }
            catch
            {
                
            }
        }
    }
}
