using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jam.jaudio;

namespace jam
{
    public partial class BankEnvelopeEditor : UserControl
    {
        JInstrumentEnvelopev1 env;
        public int SelectedIndex = 0;

        public BankEnvelopeEditor(JInstrumentEnvelopev1 env)
        {
            InitializeComponent();
            this.env = env;
   
   
            
        }

        private void BankOscillatorEditor_Load(object sender, EventArgs e)
        {
            this.Paint += BankOscillatorEditor_Paint;
            this.DoubleBuffered = true;
        }


        private void BankOscillatorEditor_Paint(object? sender, PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            g.Clear(Color.LightSkyBlue);
            var prevPos = new Point(5, 5);
            var runningOffset = 0;
            var div = 1200f;

            for (int i = 0; i < env.points.Length; i++)
                runningOffset += env.points[i].Delay;

            if (runningOffset > div)
                div = runningOffset + 300f;
            runningOffset = 0;          
            for (int i=0; i< env.points.Length; i++)
            { 
                var cp = env.points[i];
                runningOffset += cp.Delay;
                var dp = new Point(5 + (int)(360f * ((float)runningOffset / div)), 5 + (int)(235f- (235f * (((float)cp.Value + 0.01f) / 32768f))));
                g.DrawLine(Pens.Black,prevPos,dp);
                var squareBrush = Brushes.Red;
                var sm = 5;
                if (i == SelectedIndex)
                {
                    if (Math.Sin(DateTime.Now.Millisecond / 10f) > 0.5f)
                        squareBrush = Brushes.Purple;
                    else
                        squareBrush = Brushes.White;
                    sm = 10;
                }
                g.FillRectangle(squareBrush, new Rectangle(dp, new Size(sm, sm)));
                g.DrawString($"EXTENTS {div}", SystemFonts.DefaultFont, Brushes.Red, new Point(260, 10));
                prevPos = dp;
                //this.Invalidate(false);
            }
        }

        private void repaintTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate(false);

        }
    }
}
