using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_Handler;

namespace LP_LBlom_S21M
{
    public partial class Hoofdscherm : Form
    {
        Handler Handler;
        public Hoofdscherm()
        {
            InitializeComponent();
            Handler = new Handler();
        }

        private void btnNewVisit_Click(object sender, EventArgs e)
        {
            Waarneming w = new Waarneming();
            w.Show();              
            this.Hide();
        }
    }
}
