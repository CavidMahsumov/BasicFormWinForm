using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketWinForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Human human = new Human();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            human.Adress = adresstextbox.Text;
            human.Name = NameTextBox.Text;
            FileNameBox.Text = $"{human.Name}.json";
            human.Surname = SurnametextBox.Text;
            human.Age = agetextBox.Text;
            human.dateTime = dateTimePicker1.Value;
            human.FatherName = fathernametextbox.Text;

            foreach (RadioButton c in Gender.Controls.OfType<RadioButton>())
            {
                if (c.Checked)
                {
                    human.Gender = c.Text;
                }
            }

            foreach (CheckBox c in Language.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    human.Language += c.Text;
                    human.Language += ",";
                }
            }
              human.Language += textBox6.Text;

            JsonFileHelper.JSONSerialization(human, FileNameBox.Text);
        }


    }
}
