using lab3_THI;
using logic;
using System;

using System.Windows.Forms;

namespace UserInterface
{
    
    public partial class Form1 : Form
    { 
        private Division division = DivisionFactory.CreateDivision();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) {
                division.weaponList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                for (int i = 0; i < division.weaponList.Count; i++)
                {
                    listBox1.Items.Add(division.weaponList[i].Name);
                }
            }
            ChangeLable();
        }


        private void ChangeLable() { 
            
            label1.Text = DivisionPrizeColculatorFactory.CreateDivisionPrizeColculator(division).Colculate().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }

        public void UpdateList(AbstructWeapon w)
        {
            division.weaponList.Add(w);

                listBox1.Items.Clear();
                for (int i = 0; i < division.weaponList.Count; i++)
                {
                    listBox1.Items.Add(division.weaponList[i].Name);
                }
            ChangeLable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) { return; }
            Form2 frm = new Form2(this, division.weaponList[listBox1.SelectedIndex], listBox1.SelectedIndex);
            frm.Show();
            ChangeLable();
        }

        public void UpdateList(AbstructWeapon w, int index )
        {
            division.weaponList[index] = w;

            listBox1.Items.Clear();
            for (int i = 0; i < division.weaponList.Count; i++)
            {
                listBox1.Items.Add(division.weaponList[i].Name);
            }
            ChangeLable();
        }
    }
}
