using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }
        bool isFocused = false;
        private string text = "";
        private bool pass = false;
        public string customText
        {
            get { return text; }
            set
            {
                text = value;
                this.Invalidate();           }
        }
        public bool password
        {
            get { return pass; }
            set
            {
                pass = value;
                this.Invalidate();
            }
        }


        private void customTextBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = customText;
        }
        private void customTextBox_Load(object sender, EventArgs e)
        {
            if(password == true)
            {
                textBox1.UseSystemPasswordChar=true;
            }
        }
        private void labelTime_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;
            if (isFocused == false)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y <=2)
                {
                    isFocused = true;
                    labelTime.Stop();
                    label1.Font = new Font("Microsoft Sans Serif", 10);
                    y = 0;
                    label1.ForeColor = Color.Silver;

                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 10 )
                {
                    isFocused = false;
                    labelTime.Stop();
                    label1.Font = new Font("Microsoft Sans Serif", 13);
                    y = 10;
                    label1.ForeColor = Color.Black;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                labelTime.Start();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTime.Start();
            }
        }

       
    }
}
