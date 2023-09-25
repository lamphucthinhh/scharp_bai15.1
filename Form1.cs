using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace scharp_bai15._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picBig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBig, "Click me");
        }

        private void picSmall_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSmall, "Click me");
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtname.Text + " : " + txtmessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtmessage.Clear();
            txtname.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkvisible.Checked;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false; ;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
