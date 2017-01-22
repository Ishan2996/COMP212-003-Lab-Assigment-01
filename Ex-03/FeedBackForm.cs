using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_03
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Displaying Name
            string name = "Name : " + txtName.Text;

            string comm = "Commemt :" + txtcomm.Text;

            string email = "Email : " + textBox1.Text;

            //Displaying Checkboxes
            string a = "Things You Like : ";

            if (checkBox1.Checked)
            {

                a = a + checkBox1.Text + "\r\n";

            }

            if (checkBox2.Checked)
            {

                a = a + checkBox2.Text + "\r\n";

            }
            if (checkBox3.Checked)
            {

                a = a + checkBox3.Text + "\r\n";

            }

            if (checkBox4.Checked)
            {

                a = a + checkBox4.Text + "\r\n";

            }
            if (checkBox5.Checked)
            {

                a = a + checkBox5.Text + "\r\n";

            }



            //Displaying Radiobuttons
            string b = "How did you get to our Site? : ";

            if (radioButton1.Checked)
            {

                b = b + radioButton1.Text + "\r\n";

            }
            if (radioButton2.Checked)
            {

                b = b + radioButton2.Text + "\r\n";

            }
            if (radioButton3.Checked)
            {

                b = b + radioButton3.Text + "\r\n";

            }
            if (radioButton4.Checked)
            {

                b = b + radioButton4.Text + "\r\n";

            }
            if (radioButton5.Checked)
            {

                b = b + radioButton5.Text + "\r\n";

            }

            //Displaying combobox
            string c = "Rate :";
            string d = comboBox1.SelectedItem.ToString();
           
            MessageBox.Show(name + "\n" + comm + "\n" + email + "\n" + a + b + c + d);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtcomm.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }
    }
}
