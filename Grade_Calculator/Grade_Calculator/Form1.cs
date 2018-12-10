using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clearRbtn()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Eval = Convert.ToDouble(textBox1.Text);
            double Dev1 = Convert.ToDouble(textBox2.Text);
            double Dev2 = Convert.ToDouble(textBox3.Text);

            double Compo = Convert.ToDouble(textBox4.Text);
            double Result_Compo = Convert.ToDouble(Compo * 3);

            double Dev_Res = Convert.ToDouble((Eval + Dev1 + Dev2) / 3);
            double Final_dev_Result = Convert.ToDouble(Dev_Res * 2);

            double Fin_Result = Convert.ToDouble((Final_dev_Result + Result_Compo) / 5);

            textBox5.Text = (Fin_Result).ToString();
            textBox14.Text = "";

            if (textBox3.Text == "00")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                textBox5.Text = (X_res).ToString();
            }
            else
            {
                textBox5.Text = (Fin_Result).ToString();
            }
            if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                textBox13.Text != "" && textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != ""
                && textBox19.Text != "")
            {
                MessageBox.Show("جميع الحقول مملوءة الرجاء الضغط على زر المعدل العام من أجل استظهار النتيجة");
            }

            // Development
            if (textBox6.Text == "" && textBox7.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox6.Text = (X_res).ToString();
                }
                else
                textBox6.Text = (Fin_Result).ToString();
                textBox7.Text = "";
            }
            else if (textBox6.Text != "" && textBox7.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox7.Text = (X_res).ToString();
                }
                else
                textBox7.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox8.Text = (X_res).ToString();
                }
                else
                textBox8.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox9.Text = (X_res).ToString();
                }
                else
                textBox9.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox10.Text = (X_res).ToString();
                }
                else
                textBox10.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox11.Text = (X_res).ToString();
                }
                else
                textBox11.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text != "" && textBox12.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox12.Text = (X_res).ToString();
                }
                else
                textBox12.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox13.Text = (X_res).ToString();
                }
                else
                textBox13.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox16.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox16.Text = (X_res).ToString();
                }
                else
                    textBox16.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox16.Text != "" && textBox17.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox17.Text = (X_res).ToString();
                }
                else
                    textBox17.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox16.Text != "" && textBox17.Text != ""
                && textBox18.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox18.Text = (X_res).ToString();
                }
                else
                    textBox18.Text = (Fin_Result).ToString();
            }
            else if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != ""
                && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox16.Text != "" && textBox17.Text != ""
                && textBox18.Text != "" && textBox19.Text == "")
            {
                double X_res = Convert.ToDouble((Eval + Dev1 + Result_Compo) / 5);
                if (textBox3.Text == "00")
                {
                    textBox19.Text = (X_res).ToString();
                }
                else
                    textBox19.Text = (Fin_Result).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00"; 
            textBox2.Text = "00"; 
            textBox3.Text = "00"; 
            textBox4.Text = "00"; 
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double l_arab = Convert.ToDouble(textBox6.Text);
            double l_arab_Res = (l_arab * 5);

            double E_islam = Convert.ToDouble(textBox16.Text);
            double E_islam_Res = (E_islam * 2);

            double dessin = Convert.ToDouble(textBox17.Text);
            double dessin_Res = (dessin * 1);

            double mat = Convert.ToDouble(textBox7.Text);
            double mat_Res = (mat * 4);

            double hist = Convert.ToDouble(textBox8.Text);
            double hist_Res = (hist * 3);

            double franc = Convert.ToDouble(textBox9.Text);
            double franc_Res = (franc * 3);

            double angl = Convert.ToDouble(textBox10.Text);
            double angl_Res = (angl * 2);

            double physic = Convert.ToDouble(textBox11.Text);
            double physic_Res = (physic * 2);

            double scienc = Convert.ToDouble(textBox12.Text);
            double scienc_Res = (scienc * 2);

            double sport = Convert.ToDouble(textBox13.Text);
            double sport_Res = (sport * 1);

            double edu_civ = Convert.ToDouble(textBox18.Text);
            double edu_civ_Res = (edu_civ * 1);

            double inform = Convert.ToDouble(textBox19.Text);
            double inform_Res = (inform * 1);

            double Res_Final = (l_arab_Res + mat_Res + hist_Res + franc_Res + angl_Res + physic_Res + scienc_Res + sport_Res
                + E_islam_Res + dessin_Res + edu_civ_Res + inform_Res);
            textBox15.Text = (Res_Final).ToString();
            textBox5.Clear();

            double X_Final = (Res_Final / 27);
            double Sec_Final = ((Res_Final - sport_Res) / 26);

            double thrd_Result = ((Res_Final - inform_Res) / 26);
            double info_sport = (Res_Final - sport_Res - inform_Res);
            double inform_sport_Res = (info_sport / 25);

            textBox14.Text = (X_Final).ToString();
            if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != ""
                && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != ""
                && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != ""
                && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "")
            {
                textBox15.Text = (Res_Final).ToString();
                textBox14.Text = (X_Final).ToString();
            }
            if (textBox13.Text == "00")
            {
                textBox15.Text = (Res_Final - sport_Res).ToString();
                textBox14.Text = (Sec_Final).ToString();
            }
            if (textBox19.Text == "00")
            {
                textBox15.Text = (Res_Final - inform_Res).ToString();
                textBox14.Text = (thrd_Result).ToString();
            }
            if (textBox13.Text == "00" && textBox19.Text == "00")
            {
                textBox15.Text = (info_sport).ToString();
                textBox14.Text = (info_sport / 25).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clearRbtn();
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox16.Text = "";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox16.Text = "00";
            textBox17.Text = "";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox16.Text = "00";
            textBox17.Text = "00";
            textBox18.Text = "";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox16.Text = "00";
            textBox17.Text = "00";
            textBox18.Text = "00";
            textBox19.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel11.Show();
            button10.Hide();
            button8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel11.Hide();
            panel13.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel13.Show();
            button8.Show();
            button10.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button8.Show();
            panel11.Show();
            panel13.Hide();
            button10.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
