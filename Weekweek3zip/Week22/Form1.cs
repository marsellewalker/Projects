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
using System.Media;// imort to  use sound files


/*marselle walker
 * csc202
 * 10/09/2022
 * 
 * This project should take me 5 hours
 * This project took 7 hours because i added to the exsiting project had to learn how to add a wave file 
 * 
 **/

namespace Week22
{
    public partial class Form1 : Form

    {
        // creates a new sound wav object with the location to the cat sound wav

        SoundPlayer player = new SoundPlayer(soundLocation:@"C:\Users\marse\Desktop\C# images\catsound.wav");

        public Form1()
        {
            InitializeComponent();
        }

        // string first function displays greeting and instructions for pto calculator
        public string menu()
        {
            string[] menu = new string[9];
                menu[0] = "Welcome to your PTO calculator \n";
                menu[1] = "To find how much PTO you have, put the number of days you have worked \n";
                menu[2] = "and I will display how may days you have accumulater.";
            string store = menu[0] + menu[1] + menu[2];
            return view1.Text = store;
        }

        // string second function displays greeting and instructions for pay calculator
        public string menu1()
        {
            string[] menu = new string[9];
            menu[0] = "Welcome to your Pay calculator \n";
            menu[1] = "To find how much Pay, put you hourly pay in the box below  \n";
            menu[2] = "and the number of hours you worked,and I will give you your weekly pay before taxes.";
            string store = menu[0] + menu[1] + menu[2];
            return view2.Text = store;
        }


        // string second function displays greeting and instructions for bonus calculator
        public string menu2()
        {
            string[] menu = new string[9];
            menu[0] = "Welcome to your bonus calculator \n";
            menu[1] = "To find how much your bonus will be \n";
            menu[2] = "in the text box below, put the number of jobs you have worked on.";
            string store = menu[0] + menu[1] + menu[2];
            return view3.Text = store;
        }



/*=======================================new code for sting functions above==============*/






        //methodn used to close application
        // Array string used to store one string to store a good bye string to users delivered through the message box.
        private void stop()
        {
            string[] bye = new string[1];
            bye[0] = "Thank you for using our benifet calculator";
            MessageBox.Show(bye[0]);
            this.Close();
           

        }

        //Array is added here
        //Pto method with array value being returned from key 1
        private int c1 (int a)
        {
            int[] consatants = new int[2];
            consatants [0] = 10;
            consatants[1] = a * consatants[0] / 24;
            return consatants[1];
        }

        /* =================Arrays added in the code above=============*/
        
        //Pto method       
        private void  class1()
        {
            try
            {
                
                int pto = int.Parse(text1.Text);
                int accum = c1(pto);
                view1.Text = "You have" + " " + accum.ToString() + " " + "days";
                text1.Text = "";
            }
            catch
            {
                MessageBox.Show("This is not a valid choice\nTry again");
                text1.Text = "";
            }

        }



        //Pay calculator methods with returns
        private int c2(int a, int b)
        {
            int accum = a * b;
            return accum;
        }

        private int c22(int a, int b)
        {
            int nhours = 40;
            int accum2 = a * nhours;

            int half = a / 2;
            int npay = half + a;
            int halft = b - 40;
            int timeh = halft * npay;
            int total = timeh + accum2;
            return total;
        }
        //Pay calculator
        private void class2()
        {
            try
            {

                int hours = int.Parse(text2.Text);
                int workh = int.Parse(text3.Text);
                int accum = c2(hours, workh);
                view2.Text = "Your hourly pay is" + " " + "$" + accum.ToString();

                if (workh > 40)
                {
                    int hour = int.Parse(text2.Text);
                    int work = int.Parse(text3.Text);

                    int total = c22(hour, work);

                    view2.Text = view2.Text = "Your hourly pay, with overtime is" + " " + "$" + total.ToString();
                    text2.Text = "";
                    text3.Text = "";

                }
            }
            catch
            {
                MessageBox.Show("This is not a valid choice\nTry again");
                text2.Text = "";
                text3.Text = "";
            }


        }




        // Bounus method with return
        private double c3(double a)
        {
            a = int.Parse(text4.Text);
            return a;
        }

        // Bounus method
        private void class3()
        {
            try
            {
                Random rnd = new Random();
                int Bn = rnd.Next(1000);
                double bounus = c3(int.Parse(text4.Text));
                if (bounus == 7)
                {
                    double per = Bn * .0010;
                    double total = per * 7;
                    view3.Text = "Your Bonus will be" + " " + "$" + total.ToString();
                    text4.Text = "";
                }
                if (bounus != 7)
                {
                    double per = Bn * .0010;
                    double total = per * bounus;
                    view3.Text = "Your Bonus will be" + " " + total.ToString();
                    text4.Text = "";
                }
                if (bounus > 7)
                {
                    MessageBox.Show("Integraty is a skill that many lack,\n please enter number of jobs you worked on ");
                    text4.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("This is not a valid choice\nTry again");
                text4.Text = "";
            }

            
        }

        // method to save data
        private void save(string a)
        {

            StreamWriter save;
            save = File.AppendText("save.txt");
            save.WriteLine(a);
            save.Close();
        }


        // event for nested method/function PTO
        private void button1_Click(object sender, EventArgs e)
        {
            class1();
          
        }
       
        
        // event  method/function for exite button
        private void exit_Click(object sender, EventArgs e)
        {
            stop();

        }





        //not used
        private void text3_TextChanged(object sender, EventArgs e)
        {

        }
        //not used
        private void label3_Click(object sender, EventArgs e)
        {

        }





        // event for nested method/function pay calulator
        private void cal2_Click(object sender, EventArgs e)
        {
            class2();
        }
        // event for nested method/function bonuses
        private void cal3_Click(object sender, EventArgs e)
        {
            class3();
        }


        //Button to save the data when save button is pressed
        private void save1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(name1.Text) == 1)
                {
                    save(view1.Text);
                    MessageBox.Show("PTO saved");


                }
                if (int.Parse(name1.Text) == 2)
                {
                    save(view2.Text);
                    MessageBox.Show("Pay calculator saved");

                }
                if (int.Parse(name1.Text) == 3)
                {
                    save(view3.Text);
                    MessageBox.Show("Bounus, saved");

                }
            }
            catch
            {
                MessageBox.Show("This did not save");
            }
        }


        // opens the file to show the data
        private void open1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader read = new StreamReader("save.txt");
                while (!read.EndOfStream)
                {
                    MessageBox.Show("opened:" + read.ReadLine());

                }
                read.Close();
            }
            catch
            {
                MessageBox.Show("This file Did not open");
            }
        }

        private void view1_Click(object sender, EventArgs e)
        {
           
                menu();
            player.Play();// plays soun of a cat when label used as a viewing window is clicked to display infomation

        }

        private void view2_Click(object sender, EventArgs e)
        {
            menu1();
            player.Play();// plays soun of a cat when label used as a viewing window is clicked to display infomation



        }

        private void view3_Click(object sender, EventArgs e)
        {
            menu2();
            player.Play();// plays soun of a cat when label used as a viewing window is clicked to display infomation



        }


    }



}

