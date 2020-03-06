using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox14.Items.Add("/");
            comboBox14.Items.Add("0");
            comboBox14.Items.Add("L");
            comboBox14.Items.Add("S");
            comboBox14.Items.Add("A");


            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;


            comboBox15.Items.Add("/ - present");
            comboBox15.Items.Add("0 - Absent");
            comboBox15.Items.Add("S - Sick");
            comboBox15.Items.Add("L - Late");
            comboBox15.Items.Add("A - Authorised");


            comboBox1.Items.Add("/ - present");
            comboBox1.Items.Add("0 - Absent");
            comboBox1.Items.Add("S - Sick");
            comboBox1.Items.Add("L - Late");
            comboBox1.Items.Add("A - Authorised");


            comboBox2.Items.Add("/ - present");
            comboBox2.Items.Add("0 - Absent");
            comboBox2.Items.Add("S - Sick");
            comboBox2.Items.Add("L - Late");
            comboBox2.Items.Add("A - Authorised");


            comboBox3.Items.Add("/ - present");
            comboBox3.Items.Add("0 - Absent");
            comboBox3.Items.Add("S - Sick");
            comboBox3.Items.Add("L - Late");
            comboBox3.Items.Add("A - Authorised");


            comboBox4.Items.Add("/ - present");
            comboBox4.Items.Add("0 - Absent");
            comboBox4.Items.Add("S - Sick");
            comboBox4.Items.Add("L - Late");
            comboBox4.Items.Add("A - Authorised");


            comboBox5.Items.Add("/ - present");
            comboBox5.Items.Add("0 - Absent");
            comboBox5.Items.Add("S - Sick");
            comboBox5.Items.Add("L - Late");
            comboBox5.Items.Add("A - Authorised");


            comboBox6.Items.Add("/ - present");
            comboBox6.Items.Add("0 - Absent");
            comboBox6.Items.Add("S - Sick");
            comboBox6.Items.Add("L - Late");
            comboBox6.Items.Add("A - Authorised");


            comboBox7.Items.Add("/ - present");
            comboBox7.Items.Add("0 - Absent");
            comboBox7.Items.Add("S - Sick");
            comboBox7.Items.Add("L - Late");
            comboBox7.Items.Add("A - Authorised");


            comboBox8.Items.Add("/ - present");
            comboBox8.Items.Add("0 - Absent");
            comboBox8.Items.Add("S - Sick");
            comboBox8.Items.Add("L - Late");
            comboBox8.Items.Add("A - Authorised");


            comboBox9.Items.Add("/ - present");
            comboBox9.Items.Add("0 - Absent");
            comboBox9.Items.Add("S - Sick");
            comboBox9.Items.Add("L - Late");
            comboBox9.Items.Add("A - Authorised");


            comboBox10.Items.Add("/ - present");
            comboBox10.Items.Add("0 - Absent");
            comboBox10.Items.Add("S - Sick");
            comboBox10.Items.Add("L - Late");
            comboBox10.Items.Add("A - Authorised");


            comboBox11.Items.Add("/ - present");
            comboBox11.Items.Add("0 - Absent");
            comboBox11.Items.Add("S - Sick");
            comboBox11.Items.Add("L - Late");
            comboBox11.Items.Add("A - Authorised");


            comboBox12.Items.Add("/ - present");
            comboBox12.Items.Add("0 - Absent");
            comboBox12.Items.Add("S - Sick");
            comboBox12.Items.Add("L - Late");
            comboBox12.Items.Add("A - Authorised");


            comboBox13.Items.Add("/ - present");
            comboBox13.Items.Add("0 - Absent");
            comboBox13.Items.Add("S - Sick");
            comboBox13.Items.Add("L - Late");
            comboBox13.Items.Add("A - Authorised");

/*
            comboBox14.Items.Add("/ - present");
            comboBox14.Items.Add("0 - Absent");
            comboBox14.Items.Add("S - Sick");
            comboBox14.Items.Add("L - Late");
            comboBox14.Items.Add("A - Authorised");


            comboBox15.Items.Add("/ - present");
            comboBox15.Items.Add("0 - Absent");
            comboBox15.Items.Add("S - Sick");
            comboBox15.Items.Add("L - Late");
            comboBox15.Items.Add("A - Authorised");
  */


















            


        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox14.Text == "/")
            {
                comboBox15.Text = "/ - present";
                comboBox1.Text = "/ - present";
                comboBox2.Text = "/ - present";
                comboBox3.Text = "/ - present";
                comboBox4.Text = "/ - present";
                comboBox5.Text = "/ - present";
                comboBox6.Text = "/ - present";
                comboBox7.Text = "/ - present";
                comboBox8.Text = "/ - present";
                comboBox9.Text = "/ - present";
                comboBox10.Text = "/ - present";
                comboBox11.Text = "/ - present";
                comboBox12.Text = "/ - present";
                comboBox13.Text = "/ - present";
            }
            else
                if (comboBox14.Text == "0")
                {
                    comboBox15.Text = "0 - Absent";
                    comboBox1.Text = "0 - Absent";
                    comboBox2.Text = "0 - Absent";
                    comboBox3.Text = "0 - Absent";
                    comboBox4.Text = "0 - Absent";
                    comboBox5.Text = "0 - Absent";
                    comboBox6.Text = "0 - Absent";
                    comboBox7.Text = "0 - Absent";
                    comboBox8.Text = "0 - Absent";
                    comboBox9.Text = "0 - Absent";
                    comboBox10.Text = "0 - Absent";
                    comboBox11.Text = "0 - Absent";
                    comboBox12.Text = "0 - Absent";
                    comboBox13.Text = "0 - Absent";
                }
                else
                    if (comboBox14.Text == "S")
                    {
                        comboBox15.Text = "S - Sick";
                        comboBox1.Text = "S - Sick";
                        comboBox2.Text = "S - Sick";
                        comboBox3.Text = "S - Sick";
                        comboBox4.Text = "S - Sick";
                        comboBox5.Text = "S - Sick";
                        comboBox6.Text = "S - Sick";
                        comboBox7.Text = "S - Sick";
                        comboBox8.Text = "S - Sick";
                        comboBox9.Text = "S - Sick";
                        comboBox10.Text = "S - Sick";
                        comboBox11.Text = "S - Sick";
                        comboBox12.Text = "S - Sick";
                        comboBox13.Text = "S - Sick";
                    }
            else
                        if (comboBox14.Text == "L")
                        {
                            comboBox15.Text = "L - Late";
                            comboBox1.Text = "L - Late";
                            comboBox2.Text = "L - Late";
                            comboBox3.Text = "L - Late";
                            comboBox4.Text = "L - Late";
                            comboBox5.Text = "L - Late";
                            comboBox6.Text = "L - Late";
                            comboBox7.Text = "L - Late";
                            comboBox8.Text = "L - Late";
                            comboBox9.Text = "L - Late";
                            comboBox10.Text = "L - Late";
                            comboBox11.Text = "L - Late";
                            comboBox12.Text = "L - Late";
                            comboBox13.Text = "L - Late";
                        }
                        else
                            if (comboBox14.Text == "A")
                            {
                                comboBox15.Text = "A - Authorised";
                                comboBox1.Text = "A - Authorised";
                                comboBox2.Text = "A - Authorised";
                                comboBox3.Text = "A - Authorised";
                                comboBox4.Text = "A - Authorised";
                                comboBox5.Text = "A - Authorised";
                                comboBox6.Text = "A - Authorised";
                                comboBox7.Text = "A - Authorised";
                                comboBox8.Text = "A - Authorised";
                                comboBox9.Text = "A - Authorised";
                                comboBox10.Text = "A - Authorised";
                                comboBox11.Text = "A - Authorised";
                                comboBox12.Text = "A - Authorised";
                                comboBox13.Text = "A - Authorised";
                            }
                           
                             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label63.Text = "Students Attendance Register";
            label64.Text = "Register- Number : 2018/240";

            int count;
            count = 0;

            textBox1.Text = comboBox15.Text;
            textBox2.Text = comboBox1.Text;
            textBox3.Text = comboBox2.Text;
            textBox4.Text = comboBox3.Text;
            textBox5.Text = comboBox4.Text;
            textBox6.Text = comboBox5.Text;
            textBox7.Text = comboBox6.Text;
            textBox8.Text = comboBox7.Text;
            textBox9.Text = comboBox8.Text;
            textBox10.Text = comboBox9.Text;
            textBox11.Text = comboBox10.Text;
            textBox12.Text = comboBox11.Text;
            textBox13.Text = comboBox12.Text;
            textBox14.Text = comboBox13.Text;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;


            comboBox15.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false;
            comboBox13.Visible = false;


            if ((textBox1.Text == null) ||
                (textBox2.Text == null) ||
                (textBox3.Text == null) ||
                (textBox4.Text == null) ||
                (textBox5.Text == null) ||
                (textBox6.Text == null) ||
                (textBox7.Text == null) ||
                (textBox8.Text == null) ||
                (textBox9.Text == null) ||
                (textBox10.Text == null) ||
                (textBox11.Text == null) ||
                (textBox12.Text == null) ||
                (textBox13.Text == null))
            {
                MessageBox.Show("No Marks on register");

                textBox1.Text = "";
                comboBox15.Text = "";
                textBox1.Visible = false;
                comboBox15.Visible = true;

                textBox2.Text = "";
                comboBox1.Text = "";
                textBox2.Visible = false;
                comboBox1.Visible = true;

                textBox3.Text = "";
                comboBox2.Text = "";
                textBox3.Visible = false;
                comboBox2.Visible = true;

                textBox4.Text = "";
                comboBox3.Text = "";
                textBox4.Visible = false;
                comboBox3.Visible = true;

                textBox5.Text = "";
                comboBox4.Text = "";
                textBox5.Visible = false;
                comboBox4.Visible = true;

                textBox6.Text = "";
                comboBox5.Text = "";
                textBox6.Visible = false;
                comboBox5.Visible = true;

                textBox7.Text = "";
                comboBox6.Text = "";
                textBox7.Visible = false;
                comboBox6.Visible = true;

                textBox8.Text = "";
                comboBox7.Text = "";
                textBox8.Visible = false;
                comboBox7.Visible = true;

                textBox9.Text = "";
                comboBox8.Text = "";
                textBox9.Visible = false;
                comboBox8.Visible = true;

                textBox10.Text = "";
                comboBox9.Text = "";
                textBox10.Visible = false;
                comboBox9.Visible = true;

                textBox11.Text = "";
                comboBox10.Text = "";
                textBox11.Visible = false;
                comboBox10.Visible = true;

                textBox12.Text = "";
                comboBox11.Text = "";
                textBox12.Visible = false;
                comboBox11.Visible = true;

                textBox13.Text = "";
                comboBox12.Text = "";
                textBox13.Visible = false;
                comboBox12.Visible = true;

                textBox14.Text = "";
                comboBox13.Text = "";
                textBox14.Visible = false;
                comboBox13.Visible = true;

                comboBox14.Text = "";

            }
            if (textBox1.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox2.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox3.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox4.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox5.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox6.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox7.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox8.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox9.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox10.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox11.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox12.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox13.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

            if (textBox14.Text == "/ - present")
            {
                count = count + 1;
                label62.Text = Convert.ToString(count);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox14.Text = "";
            label62.Text = "";
            //pictureBox.image

            label59.Text = "";
            label58.Text = "";


            label63.Text = "Students Attendance Register";
            label64.Text = "Number : 2018/240";



            textBox1.Text = "";
            comboBox15.Text = "";
            textBox1.Visible = false;
            comboBox15.Visible = true;


            textBox2.Text = "";
            comboBox1.Text = "";
            textBox2.Visible = false;
            comboBox1.Visible = true;


            textBox3.Text = "";
            comboBox2.Text = "";
            textBox3.Visible = false;
            comboBox2.Visible = true;

            textBox4.Text = "";
            comboBox3.Text = "";
            textBox4.Visible = false;
            comboBox3.Visible = true;

            textBox5.Text = "";
            comboBox4.Text = "";
            textBox5.Visible = false;
            comboBox4.Visible = true;

            textBox6.Text = "";
            comboBox5.Text = "";
            textBox6.Visible = false;
            comboBox5.Visible = true;

            textBox7.Text = "";
            comboBox6.Text = "";
            textBox7.Visible = false;
            comboBox6.Visible = true;

            textBox8.Text = "";
            comboBox7.Text = "";
            textBox8.Visible = false;
            comboBox7.Visible = true;

            textBox9.Text = "";
            comboBox8.Text = "";
            textBox9.Visible = false;
            comboBox8.Visible = true;

            textBox10.Text = "";
            comboBox9.Text = "";
            textBox10.Visible = false;
            comboBox9.Visible = true;

            textBox11.Text = "";
            comboBox10.Text = "";
            textBox11.Visible = false;
            comboBox10.Visible = true;

            textBox12.Text = "";
            comboBox11.Text = "";
            textBox12.Visible = false;
            comboBox11.Visible = true;

            textBox13.Text = "";
            comboBox12.Text = "";
            textBox13.Visible = false;
            comboBox12.Visible = true;

            textBox14.Text = "";
            comboBox13.Text = "";
            textBox14.Visible = false;
            comboBox13.Visible = true;















        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int StdNo = 21243;
            label2.Text = Convert.ToString(StdNo + 10);
            label7.Text = Convert.ToString(StdNo + 20);
            label11.Text = Convert.ToString(StdNo + 30);
            label15.Text = Convert.ToString(StdNo + 40);
            label19.Text = Convert.ToString(StdNo + 50);
            label23.Text = Convert.ToString(StdNo + 60);
            label27.Text = Convert.ToString(StdNo + 70);
            label31.Text = Convert.ToString(StdNo + 80);
            label35.Text = Convert.ToString(StdNo + 90);
            label39.Text = Convert.ToString(StdNo + 100);
            label43.Text = Convert.ToString(StdNo + 110);
            label47.Text = Convert.ToString(StdNo + 120);
            label51.Text = Convert.ToString(StdNo + 130);
            label55.Text = Convert.ToString(StdNo + 140);

            label4.Text = Convert.ToString(5521);
            label5.Text = Convert.ToString(5521);
            label9.Text = Convert.ToString(5521);
            label13.Text = Convert.ToString(5521);
            label17.Text = Convert.ToString(5521);
            label21.Text = Convert.ToString(5521);
            label25.Text = Convert.ToString(5521);
            label29.Text = Convert.ToString(5521);
            label33.Text = Convert.ToString(5521);
            label37.Text = Convert.ToString(5521);
            label41.Text = Convert.ToString(5521);
            label45.Text = Convert.ToString(5521);
            label49.Text = Convert.ToString(5521);
            label53.Text = Convert.ToString(5521);


            label3.Text = "Omda mohammed Omda";
            label6.Text = "Mazen Ahmedean";
            label10.Text = "Abdolkhader Adm";
            label14.Text = "Mustafa Musa";
            label18.Text = "Mohammed IBrahim";
            label22.Text = "Nasor Mohammed Nasor";
            label26.Text = "Zr Alrezig";
            label30.Text = "Musab Nasor";
            label34.Text = "AlHadi Adm";
            label38.Text = "Houzaifa Abdullah";
            label42.Text = "Ahmed Abdo";
            label46.Text = "Mahjoub Mohammed";
            label50.Text = "Ahmed Omer";
            label54.Text = "Mujib Ali";



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = imageList1.Images[0];
        }
    }
}




















       
    
