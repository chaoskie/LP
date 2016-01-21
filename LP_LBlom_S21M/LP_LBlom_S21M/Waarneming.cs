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

        public Waarneming()
        {
            InitializeComponent();
            Handler = new Handler();
            Handler.NewBezoek();
            cbVogelsoort.DataSource = Handler.VogelNamen;
            cbVogelsoort.DisplayMember = "Name";
            cbVogelSoortenZoeken.ComboBox.DataSource = Handler.VogelNamen;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
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

            //handler create method
            //place tag VA, TI, NI
            //selecteer dier
            //plaats markering
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //TODO

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
    }
}
