using lab3_THI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        List<string> list = new List<string>() { "blade", "firearms", "highPrecisionWeapon" };
        private bool isOverwrite = false;
        private int index;
        public Form2(Form1 form1, AbstructWeapon abstructWeapon, int index) {
            InitializeComponent();
            this.form1 = form1;
            this.index = index;
            comboBox1.Items.AddRange(list.ToArray());
            
            comboBox1.Enabled = false;
            isOverwrite = true;
            if (abstructWeapon is BladedWeapon) {
                comboBox1.Text = list[0];
                comboBox1.SelectedIndex = 0;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "Lenght";
                label6.Visible = true;
                label6.Text = "HandCount";
                label7.Visible = false;
                label8.Visible = false;
                textBox1.Visible = true;
                textBox1.Text = (abstructWeapon as BladedWeapon).Name;
                textBox2.Visible = true;
                textBox2.Text = (abstructWeapon as BladedWeapon).Price.ToString();
                textBox3.Visible = true;
                textBox3.Text = (abstructWeapon as BladedWeapon).Size.ToString();
                textBox4.Visible = true;
                textBox4.Text = (abstructWeapon as BladedWeapon).Lenght.ToString();
                textBox5.Visible = true;
                textBox5.Text = (abstructWeapon as BladedWeapon).HandCount.ToString();
                textBox6.Visible = false;
                textBox7.Visible = false;
            }

            if (abstructWeapon is Firearms)
            {
                comboBox1.Text = list[1];
                comboBox1.SelectedIndex = 1;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "Calibre";
                label6.Visible = true;
                label6.Text = "NumberRounds";
                label7.Visible = true;
                label7.Text = "MaxRounds";
                label8.Visible = false;
                textBox1.Visible = true;
                textBox1.Text = (abstructWeapon as Firearms).Name;
                textBox2.Visible = true;
                textBox2.Text = (abstructWeapon as Firearms).Price.ToString();
                textBox3.Visible = true;
                textBox3.Text = (abstructWeapon as Firearms).Size.ToString();
                textBox4.Visible = true;
                textBox4.Text = (abstructWeapon as Firearms).Calibre.ToString();
                textBox5.Visible = true;
                textBox5.Text = (abstructWeapon as Firearms).NumberRounds.ToString();
                textBox6.Visible = true;
                textBox6.Text = (abstructWeapon as Firearms).MaxRounds.ToString();
                textBox7.Visible = false;
            }

            if (abstructWeapon is HighPrecisionWeapon)
            {
                comboBox1.Text = list[2];
                comboBox1.SelectedIndex = 2;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "Calibre";
                label6.Visible = true;
                label6.Text = "NumberRounds";
                label7.Visible = true;
                label7.Text = "MaxRounds";
                label8.Visible = true;
                label8.Text = "Accuracy";
                textBox1.Visible = true;
                textBox1.Text = (abstructWeapon as HighPrecisionWeapon).Name;
                textBox2.Visible = true;
                textBox2.Text = (abstructWeapon as HighPrecisionWeapon).Price.ToString();
                textBox3.Visible = true;
                textBox3.Text = (abstructWeapon as HighPrecisionWeapon).Size.ToString();
                textBox4.Visible = true;
                textBox4.Text = (abstructWeapon as HighPrecisionWeapon).Calibre.ToString();
                textBox5.Visible = true;
                textBox5.Text = (abstructWeapon as HighPrecisionWeapon).NumberRounds.ToString();
                textBox6.Visible = true;
                textBox6.Text = (abstructWeapon as HighPrecisionWeapon).MaxRounds.ToString();
                textBox7.Visible = true;
                textBox7.Text=(abstructWeapon as HighPrecisionWeapon).Accuracy.ToString();
            }

        }

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.form1 = f1;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false; 
            textBox2.Visible = false;
            textBox3.Visible = false; 
            textBox4.Visible = false;
            textBox5.Visible = false; 
            textBox6.Visible = false;
            textBox7.Visible = false;

            comboBox1.Items.AddRange(list.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "Lenght";
                label6.Visible = true;
                label6.Text = "HandCount";
                label7.Visible = false;
                label8.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "Calibre";
                label6.Visible = true;
                label6.Text = "NumberRounds";
                label7.Visible = true;
                label7.Text = "MaxRounds";
                label8.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "Calibre";
                label6.Visible = true;
                label6.Text = "NumberRounds";
                label7.Visible = true;
                label7.Text = "MaxRounds";
                label8.Visible = true;
                label8.Text = "Accuracy";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                BladedWeapon weapon = new BladedWeapon();
                if (textBox1.Text != "") { weapon.Name = textBox1.Text; } else {
                    ShowMessage();
                    return; }
                
                try
                {
                    weapon.Price =  float.Parse(textBox2.Text);
                    weapon.Size = int.Parse(textBox3.Text);
                    weapon.Lenght = float.Parse(textBox4.Text);
                    weapon.HandCount = int.Parse(textBox5.Text);
                    if (textBox5.Text!="1" && textBox5.Text !="2") {
                        ShowMessage();
                        return; }

                    if (isOverwrite) { form1.UpdateList(weapon, index); } else { form1.UpdateList(weapon);}
                    this.Close();
                }
                catch {
                    ShowMessage();
                    return;
                }

                
            }
         
            else if (comboBox1.SelectedIndex == 1)
            {
                Firearms firearms = new Firearms();
                if (textBox1.Text != "") { firearms.Name = textBox1.Text; } else {
                    ShowMessage();
                    return; }

                try
                {
                    firearms.Price = float.Parse(textBox2.Text);
                    firearms.Size = int.Parse(textBox3.Text);
                    firearms.Calibre = float.Parse(textBox4.Text);
                    firearms.NumberRounds = int.Parse(textBox5.Text);
                    firearms.MaxRounds = int.Parse(textBox6.Text);
                    if (isOverwrite) { form1.UpdateList(firearms, index); } else { form1.UpdateList(firearms); }
                    this.Close();
                }
                catch
                {
                    ShowMessage();
                    return;
                }

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                HighPrecisionWeapon highPrecisionWeapon = new HighPrecisionWeapon();
                if (textBox1.Text != "") { highPrecisionWeapon.Name = textBox1.Text; } else {
                    ShowMessage();
                    return; }

                try
                {
                    highPrecisionWeapon.Price = float.Parse(textBox2.Text);
                    highPrecisionWeapon.Size = int.Parse(textBox3.Text);
                    highPrecisionWeapon.Calibre = float.Parse(textBox4.Text);
                    highPrecisionWeapon.NumberRounds = int.Parse(textBox5.Text);
                    highPrecisionWeapon.MaxRounds = int.Parse(textBox6.Text);
                    highPrecisionWeapon.Accuracy = float.Parse(textBox7.Text);
                    if (isOverwrite) { form1.UpdateList(highPrecisionWeapon, index); } else { form1.UpdateList(highPrecisionWeapon); }
                    this.Close();
                }
                catch
                {
                    ShowMessage();
                    return;
                }
            }
        }

        private void ShowMessage() {
            string message = "You did not enter a server name";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
