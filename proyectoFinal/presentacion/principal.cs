using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal.presentacion
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 263)
            {
                menuVertical.Width = 77;
            }
            else
            {
                menuVertical.Width = 263;
            }
            if (menuVertical.Width == 77)
            {
                menu2.Width = 909;
            }
            else
            {
                menu2.Width = 832;
            }
        }
    }
}
