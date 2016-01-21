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
            comboBox1.Enabled = false;
            comboBox1.Text = "Aabroeken";
        }

        private void btnNewVisit_Click(object sender, EventArgs e)
        {
            Waarneming w = new Waarneming();
            w.Show();              
            this.Hide();
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            try
            {
                throw new GUI_Handler.ExportException("Er is niet voldaan aan de eisen om te exporteren.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
