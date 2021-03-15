using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace SKYNET.Dota2GCLauncher.Controls
{
    public partial class DotaButton : UserControl
    {
        private Color _Color1;
        public Color Color1
        {
            get { return _Color1; }
            set { _Color1 = value; }
        }
        private Color _Color2;
        public Color Color2
        {
            get { return _Color2; }
            set { _Color2 = value; }
        }
        public enum ButtonTheme
        {
            JUGAR,
            DETENER
        }
        private ButtonTheme _Theme;
        public ButtonTheme Theme
        {
            get { return _Theme; }
            set
            {
                _Theme = value;
                if (value == ButtonTheme.JUGAR)
                {
                    Color1 = Color.FromArgb(133, 204, 71);
                    Color2 = Color.FromArgb(104, 179, 88);
                    PaintGradiant();
                    MostrarLabel("► JUGAR");
                }
                else
                {
                    Color1 = Color.FromArgb(109, 145, 233);
                    Color2 = Color.FromArgb(72, 75, 201);
                    PaintGradiant();
                    MostrarLabel("X DETENER");
                }
            }
        }
        public DotaButton()
        {
            InitializeComponent();
            PaintGradiant();
        }

        private void DotaButton_Load(object sender, EventArgs e)
        {
            if (Theme == ButtonTheme.JUGAR)
            {
                Color1 = Color.FromArgb(133, 204, 71);
                Color2 = Color.FromArgb(104, 179, 88);
                PaintGradiant();
            }
            else
            {
                Color1 = Color.FromArgb(109, 145, 233);
                Color2 = Color.FromArgb(72, 75, 201);

            }
            PaintGradiant();
        }
        private void PaintGradiant()
        {

            LinearGradientBrush gradBrush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), _Color1, Color2, 0f);


            Bitmap bmp = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0, Width, Height));
            BackgroundImage = bmp;
            BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DotaButton_Click(object sender, EventArgs e)
        {

        }

        private void DotaButton_MouseClick(object sender, MouseEventArgs e)
        {
            Process[] process = Process.GetProcessesByName("dota2");
            if (process.Any())
            {
                Theme = ButtonTheme.DETENER;
            }
            else
            {
                Theme = ButtonTheme.JUGAR;
            }
        }
        public void MostrarLabel(string v)
        {
            //Width
            int W_Pantalla = Width / 2; //680
            int AnchoTexto = Convert.ToInt32(modCommon.GetTextSize(v, txt.Font).Width) / 2;
            int WidthText = W_Pantalla - AnchoTexto;

            //Heigth
            int HeigthText = txt.Location.Y;

            txt.Location = new Point(WidthText, HeigthText);
            txt.Text = v;
        }

        private void DotaButton_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void DotaButton_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
