using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsForm_Test_1
{
    public partial class Form1 : Form
    {
        static int barValue = 0;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();

            //   int barValue;
            //  barValue = 0;
            // комментарий разработчика 
        }

        public void BarValueChange()
        {
            if (barValue < 100)
            {
                barValue = barValue + 10;
                progressBar1.Value = barValue;
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Хорош!");
            }                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //  label1.Text = "EHF";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // label1.Text = dateTimePicker1.Text;
            label1.Text = dateTimePicker1.Text;
            // MessageBox.Show("Привет!"); 
            BarValueChange();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();             // .ToShortDateString();
            BarValueChange();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = "Это тестовая кнопка";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icons = MessageBoxIcon.Error;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icons);
            BarValueChange();
        }
              
        private void button3_Click(object sender, EventArgs e)
        {
            BarValueChange();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            statusStrip1.Text = DateTime.Now.ToLongDateString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog() ;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           // MessageBox.Show(openFileDialog1.FileName);
            listBox1.Items.Add(openFileDialog1.FileName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // openFileDialog1.OpenFile.listBox1_SelectedIndexChanged;

         //   string fileName = null;

           // using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
          //  {
               // openFileDialog1.InitialDirectory = "c:\\";
               // openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
               // openFileDialog1.FilterIndex = 2;
               // openFileDialog1.RestoreDirectory = true;
//
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
             //   {
             //       fileName = openFileDialog1.FileName;
            //    }
          //  }

          //  if (fileName != null)
           // {
                //Do something with the file, for example read text from it
                // string text = File.ReadAllText(fileName);
               // MessageBox.Show(File.ReadAllText(fileName));
         //   }

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is null)
            {
                MessageBox.Show("Путь не найден. Настройте список.", "Ошибка!");
            }
            else
            {
                string filePath = "";
                filePath = listBox1.SelectedItem.ToString();
                Process.Start(filePath);
            }

        }
    }
}
