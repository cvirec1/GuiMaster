using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIMaster
{
    public partial class Form1 : Form
    {
        int count = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            lblNumber.Text = txtText.TextLength.ToString();
        }
                

        private void rbSerif_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void rbArial_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Arial", 10);
        }

        private void rbComic_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Comic Sans", 8);
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            float size;
            bool success = float.TryParse(txtNumber.Text, out size);
            if (success)
            {
                txtText.Font = new Font(txtText.Font.Name,size);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = comboBox1.SelectedIndex;
            switch (value)
            {
                case 0:
                    {
                        txtText.ForeColor = Color.Blue;
                        break;
                    }
                case 1:
                    {
                        txtText.ForeColor = Color.Red;
                        break;
                    }
                case 2:
                    {
                        txtText.ForeColor = Color.Green;
                        break;
                    }
                case 3:
                    {
                        txtText.ForeColor = Color.Yellow;
                        break;
                    }
                case 4:
                    {
                        txtText.ForeColor = Color.Gray;
                        break;
                    }
            }
                
        }

        private void chbRead_CheckedChanged(object sender, EventArgs e)
        {
            if(chbRead.Checked)
            {
                txtText.ReadOnly = true;
            }
            else
            {
                txtText.ReadOnly = false;
            }
        }

        private void chbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEnabled.Checked)
            {
                txtText.Enabled = false;
                txtNumber.Enabled = false;
                comboBox1.Enabled = false;
                rbArial.Enabled = false;
                rbComic.Enabled = false;
                rbSerif.Enabled = false;
                chbRead.Enabled = false;
                lblNumber.Enabled = false;

            }
            else
            {
                txtText.ReadOnly = true;
                txtNumber.Enabled = true;
                comboBox1.Enabled = true;
                rbArial.Enabled = true;
                rbComic.Enabled = true;
                rbSerif.Enabled = true;
                chbRead.Enabled = true;
                lblNumber.Enabled = true;
            }
        }

        private void rbLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLeft.Checked)
            {
                txtText.Dock = DockStyle.Left;
            }
            else
            {
                txtText.Dock = DockStyle.None;
            }
        }

        private void rbRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRight.Checked)
            {
                txtText.Dock = DockStyle.Right;
            }
            else
            {
                txtText.Dock = DockStyle.None;
            }
        }

        private void rbTop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTop.Checked)
            {
                txtText.Dock = DockStyle.Top;
            }
            else
            {
                txtText.Dock = DockStyle.None;
            }
        }

        private void rbBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBottom.Checked)
            {
                txtText.Dock = DockStyle.Bottom;
            }
            else
            {
                txtText.Dock = DockStyle.None;
            }
        }

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNone.Checked)
            {
                txtText.Dock = DockStyle.None;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (count % 2 == 1)
            {
                pictureBox1.Image = GUIMaster.Properties.Resources.images;
                count++;
            }
            else
            {
                pictureBox1.Image = GUIMaster.Properties.Resources.stiahnuť;
                count++;
            }
            
        }
    }
}
