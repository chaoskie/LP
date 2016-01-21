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
    public partial class Waarneming : Form
    {
        Handler Handler;
        List<PointF> Punten = new List<PointF>();
        string code = "VA";

        public Waarneming()
        {
            InitializeComponent();
            Handler = new Handler();
            Handler.NewBezoek();
            cbVogelsoort.DataSource = Handler.VogelNamen;
            cbVogelsoort.SelectedIndex = 0;
            cbVogelSoortenZoeken.ComboBox.DataSource = Handler.VogelNamen;
            cbVogelSoortenZoeken.ComboBox.SelectedIndex = 0;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//plaatsen van markering
            {
                //Handler verwerkt input
                if (!Handler.NewWaarneming(e.X, e.Y, code, cbVogelsoort.SelectedIndex))
                {
                    MessageBox.Show("De opgegeven informatie is incorect.");
                    return;
                }

                //plaatsen van markering
                //locatie nodig
                int xmax = panel1.ClientRectangle.Width - 1; //max x definieren
                int ymax = panel1.ClientRectangle.Height - 1; //max y definieren

                float x = e.X; //select klik x
                float y = e.Y; //select klik y

                float newx = x / xmax; //instellen van waarde x tussen 0&1
                float newy = y / ymax; //instellen van waarde y tussen 0&1

                PointF punt = new PointF(newx, newy); //nieuwe klik punt
                Punten.Add(punt); //toevoegen van klik startpunt
                Refresh();
            }

            if (e.Button == MouseButtons.Right)//ophalen van gegevens
            {
                List<string> result = Handler.FindWaarnemingOnClick(e.X, e.Y);
                if (result.Count <= 0)
                {
                    MessageBox.Show("Geen markeringen kunnen vinden");
                    return;
                }
                lblResult.Text = string.Empty;

                foreach (string s in result)
                {
                    lblResult.Text += s + "\n";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //grafische tekeningen
            Graphics Grafisch = e.Graphics;

            //locaties van grafische floats
            float xMin = 0;
            float yMin = 0;

            float xMax = panel1.ClientRectangle.Width - 1;
            float yMax = panel1.ClientRectangle.Height - 1;

            float xMiddel = xMax / 2;
            float yMiddel = yMax / 2;

            //tekenen met klik
            int xMaxint = panel1.ClientRectangle.Width - 1;
            int yMaxint = panel1.ClientRectangle.Height - 1;

            int index = 0; //zet teken index van de size

            Pen black = new Pen(Color.Purple, (float)((xMax / 280) * 1));

            foreach (PointF Punt in Punten)
            {
                float x = (float)(Punt.X * xMaxint); //rekend nieuwe coordinaten na resize screen
                float y = (float)(Punt.Y * yMaxint); // rekend nieuwe coordinaten na resize screen

                Grafisch.DrawEllipse(black, (Punt.X * xMaxint) - (4 / 2), (Punt.Y * yMaxint) - (4 / 2), 5, 5); //tekent nieuwe figuren      

                index++;
            }
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            code = "VA";
            btnVA.Enabled = false;
            btnTI.Enabled = btnNI.Enabled = true;
        }

        private void btnTI_Click(object sender, EventArgs e)
        {
            code = "TI";
            btnTI.Enabled = false;
            btnVA.Enabled = btnNI.Enabled = true;
        }

        private void btnNI_Click(object sender, EventArgs e)
        {
            code = "NI";
            btnTI.Enabled = btnVA.Enabled = true;
            btnNI.Enabled = false;
        }

        private void exporterenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void berekenBroedpuntenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> broedpunten = Handler.berekenBroedpunten();
            string display = string.Empty;
            foreach (string s in broedpunten)
            {
                display += s + "\n";
            }
            MessageBox.Show(display);
        }


    }
}
