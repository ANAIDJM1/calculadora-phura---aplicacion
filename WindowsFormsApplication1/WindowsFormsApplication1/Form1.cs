using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       
       private String t = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && listBox1.SelectedItem!=null)
            { listBox1.Items.RemoveAt(listBox1.SelectedIndex); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bag in Box");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Equipo Transparente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Recarga");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Equipo Azul");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bidon Vacio");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("2Lt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1Lt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("700 ml");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("500 ml");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("350 ml");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("360 ml S/G - vidrio");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("360 ml C/G - vidrio");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bidon con Caño");
        }

        private void button14_Click(object sender, EventArgs e)
        {
           //suma todos los elementos del listBox
                //convierte elementos del listbox a precio
            double sum = 0;
                //sum todo
           // String a = textBox1.Text;

            for (int i = 0; i < listBox1.Items.Count ; i++)
            {
                t = listBox1.Items[i].ToString();
                
                switch(t)
                    {
                    case "Bag in Box":
                            sum += 19.50;
                            break;
                    case "Equipo Transparente":
                            sum += 56;
                            break;
                    case "Recarga":
                            sum += 11;
                            break;
                    case "Equipo Azul":
                            sum += 51;
                            break;
                    case "Bidon Vacio":
                            sum += 22;
                            break;
                    case "2Lt":
                            sum += 10.50;
                            break;
                    case "1Lt":
                            sum += 17;
                            break;
                    case "700 ml":
                            sum += 10;
                            break;
                    case "500 ml":
                            sum += 9.50;
                            break;
                    case "350 ml":
                            sum += 7.50;
                            break;
                    case "360 ml S/G - vidrio":
                            sum += 15;
                            break;
                    case "360 ml C/G - vidrio":
                            sum += 16.50;
                            break;
                    case "Bidon con Caño":
                            sum += 35;
                            break;
                     default:
                           
                                sum += 0;
                                break;
                            
                    }


            }
                //muestra resultados
            label2.Text = sum.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = "0.00";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }
    }
}
