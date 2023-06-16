using System.Drawing;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace WF_GDI_1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
        }          
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Pen pen = new Pen(Color.Black, 5);


            Graphics g = e.Graphics;            
            Point[] points = 
            {
               new Point(160, 318),
               new Point(190, 258),
               new Point(171, 215),
               new Point(201, 160),
               new Point(218, 114),
               new Point(252, 91),
               new Point(300, 55)
            };
            e.Graphics.DrawLines(pen, points);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(161, 303, 40, 40, 40, 170);
            g.DrawPath(new Pen(Color.Black, 7), path);

            points = new[]
            {
               new Point(196, 334),
               new Point(203, 323)
            };
            e.Graphics.DrawLines(pen, points);
            points = new[]
             {
               new Point(198, 330),
               new Point(214, 306)
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
             {
               new Point(195, 335),
               new Point(205, 334),
               new Point(201, 323)
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
             {
               new Point(176, 342),
               new Point(197, 355),
               new Point(192, 337)
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 10), points);

            points = new[]
            {
               new Point(239, 135),
               new Point(230, 147),
               new Point(220, 175),
               new Point(207, 186),
               new Point(214, 204),
               new Point(216, 224),
               new Point(223, 202),
               new Point(232, 191),
               new Point(228, 180),
               new Point(229, 163),
               new Point(234, 143)               
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            //points = new[]
            //{
            //   new Point(225, 163),
            //   new Point(226, 191),
            //   new Point(219, 204),
            //   new Point(224, 174),
            //   new Point(212, 190),
            //   new Point(219, 194),
            //};
            //e.Graphics.DrawLines(new Pen(Color.Black, 10), points);

            points = new[]
           {
               new Point(236, 229),
               new Point(257, 204),
               new Point(312, 164),
               new Point(333, 141),
               new Point(318, 165),
               new Point(281, 203),
               new Point(290, 206),
               new Point(267, 236),
               new Point(247, 249),
               new Point(256, 232),
               new Point(257, 223),
               new Point(236, 229)              
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 3), points);

            points = new[]
            {
               new Point(321, 156),
               new Point(242, 224),
               new Point(310, 170)               
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 7), points);

            path.StartFigure();
            path.AddArc(280, 120, 100, 100, 40, -150);
            g.DrawPath(new Pen(Color.Black, 7), path);

            points = new[]
            {
               new Point(320, 120),
               new Point(300, 125)              
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
            {
               new Point(300, 125),
               new Point(275, 135)
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 3), points);

            points = new[]
            {
               new Point(397, 155),
               new Point(438, 160)
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);
            points = new[]
            {
               new Point(438, 160),
               new Point(464, 225),
               new Point(402, 331),
               new Point(377, 319),
               new Point(352, 321),
               new Point(328, 334)               
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 7), points);

            points = new[]
             {
               new Point(218, 367),
               new Point(227, 381),
               new Point(250, 387),
               new Point(288, 367)
             };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
             {
               new Point(234, 356),
               new Point(288, 341),               
             };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            path.StartFigure();
            path.AddArc(215, 278, 80, 80, 40, -110);
            g.DrawPath(new Pen(Color.Black, 7), path);

            points = new[]
             {
               new Point(251, 285),
               new Point(296, 273),
             };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
            {
               new Point(416, 61),
               new Point(475, 85),
               new Point(504, 114),
               new Point(535, 176),
               new Point(549, 265),
               new Point(539, 331),
               new Point(511, 406)               
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 7), points);

            points = new[]
            {
               new Point(304, 89),
               new Point(318, 61),
               new Point(318, 24),
               new Point(312, 9),
               new Point(310, 0),
               new Point(331, 0),
               new Point(357, 13),
               new Point(401, 59),             
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
            {
               new Point(330, 10),
               new Point(343, 22),
               new Point(355, 36),
               new Point(364, 89),
               new Point(380, 115),
               new Point(389, 100),
               new Point(393, 82),
               new Point(402, 68),
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
            {
               new Point(217, 99),
               new Point(207, 67),
               new Point(205, 43),
               new Point(210, 21),
               new Point(218, 34),
               new Point(233, 49),
               new Point(254, 59),
               new Point(272, 61),
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
            {
               new Point(303, 387),
               new Point(278, 437),
               new Point(328, 444),
               new Point(341, 454),               
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            points = new[]
            {
               new Point(444, 353),
               new Point(464, 392),
               new Point(489, 421),
               new Point(438, 446),
            };
            e.Graphics.DrawLines(new Pen(Color.Black, 5), points);

            //Graphics g = e.Graphics;

            Font f = new Font("Vivaldi", 36, FontStyle.Bold, (GraphicsUnit)FontStyle.Italic);
            g.DrawString("Fang & K' LTD", f, Brushes.DarkRed, 220, 450);
            g.Dispose();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"X =  { e.X } Y = { e.Y }";
        }
    }
}