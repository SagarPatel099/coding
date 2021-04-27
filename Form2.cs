using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(50, 30, 100, 80); 
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);  
            g.FillRectangle(lBrush, rect);

            Graphics g1 = e.Graphics;
            Rectangle rect1 = new Rectangle(150, 110, 100, 80);
            LinearGradientBrush lBrush1 = new LinearGradientBrush(rect, Color.Pink, Color.Blue, LinearGradientMode.ForwardDiagonal); 
            g1.FillRectangle(lBrush1, rect1);

            Graphics g2 = e.Graphics;
            Rectangle rect2 = new Rectangle(200, 280, 120, 100); 
            LinearGradientBrush lBrush2 = new LinearGradientBrush(rect2, Color.Green, Color.GreenYellow, LinearGradientMode.BackwardDiagonal);   
            g.FillRectangle(lBrush, rect2);

            Graphics g3 = e.Graphics;
            Rectangle rect3 = new Rectangle(390, 400, 120, 120);
            LinearGradientBrush lBrush3 = new LinearGradientBrush(rect2, Color.Pink, Color.Blue, LinearGradientMode.ForwardDiagonal); //(Upper Left to Bottom Right)
            g1.FillRectangle(lBrush1, rect3);

        }
    }
}
