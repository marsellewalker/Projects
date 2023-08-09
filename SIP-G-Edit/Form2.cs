using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// import to use file I/O


namespace SIP_G_Edit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // Opens files
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;

                StreamReader read = new StreamReader(fileName);

                try
                {
                    while (!read.EndOfStream)
                    {
                        open.Text = read.ReadToEnd();
                        // MessageBox.Show("opened:" + read.ReadLine());

                    }
                    read.Close();
                }
                catch
                {
                    MessageBox.Show("This file Did not open");
                }
            }
        }
       

        //Adds in a safty block
        public string InsertEntry(RichTextBox rtb)
        {
            var space = 0;
            var endTag = "T";
            var lineToAdd = "G90 G80 G40 D49 G17\nG20\nG30 G91 ZO\nG30 G91 X0Y0\n\n";

            return rtb.Text = rtb.Text.Insert(rtb.Text.IndexOf(endTag), lineToAdd);

        }



        // The radio button allows you to add the safty block.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            InsertEntry(open);
        }





        // Delete button, deletes the file
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            string fileName;
            fileName = dlg.FileName;
            MessageBox.Show(fileName);

            File.Delete(fileName);

            Console.WriteLine("Specified file has been deleted");
        }






        //find string in file
        private void find_Click(object sender, EventArgs e)
        {
            int index = 0;
            var temp = open.Text;
            open.Text = "";
            open.Text = temp;

            while (index < open.Text.LastIndexOf(TB2.Text))
            {
                open.Find(TB2.Text, index, open.TextLength, RichTextBoxFinds.None);
                open.SelectionBackColor = Color.Yellow;

                index = open.Text.IndexOf(TB2.Text, index) + 1;
            }
        }





        //replaces string in file
        public static string QuickReplace(RichTextBox rtb, String word, String word2)
        {

            return rtb.Text = rtb.Text.Replace(word, word2);

        }
        //the replaces string in file button
        private void replace_Click(object sender, EventArgs e)
        {
            QuickReplace(open, TB2.Text, TB1.Text);
        }



       

        // changes the end of the g code from m30 or m02 which both end the program but one restarts it.
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            

            string sub_end = "M30";
            string sub_end2 = "M02";
            string sub_end1 = "M99";

            QuickReplace(open, sub_end, sub_end1);
            QuickReplace(open, sub_end2, sub_end1);



        }
       
        
        
        
        
        
        // Save Buttom
        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

           
             string fileName;
             fileName = dlg.FileName;


            System.IO.File.WriteAllText(fileName, open.Text.Replace("\n", Environment.NewLine));
        }
    }
    
}


