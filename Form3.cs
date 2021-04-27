using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            Pen pn1 = new Pen(Color.Blue, 10);
            Rectangle rect1 = new Rectangle(80, 60, 100, 50);
            g1.DrawEllipse(pn1, rect1);

            Graphics g2 = e.Graphics;
            Pen pn2 = new Pen(Color.Red, 10);
            Rectangle rect2 = new Rectangle(80, 150, 100, 50);
            g2.DrawEllipse(pn2, rect2);
        }
    }
}
