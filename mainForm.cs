using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummerSchool_TestTask
{
    public partial class mainForm : Form
    {

        private int size;
        private int[][] board;
        private Point[][] cellCenters;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //statusChange("Готово");
            //boardDraw(10); 
            //statusChange("Отрисовано");
            //pbxCanvas.Invalidate();
        }

        private void statusChange(string pstatus){ tlstrpStatus.Text = "Готово"; }

        //public void boardDraw(Graphics pgraphics, int[][] pboard, int psize){           
        //    for(int i=0; i<psize; i++)
        //        for (int j = 0; j < psize; j++) {
        //            numberDraw(pgraphics, pboard[i][j], i * (pbxCanvas.Width / psize), j * (pbxCanvas.Height / psize));
        //        }
        //    pbxCanvas.Invalidate();
        //}

        //public void boardDraw(int[][] pboard, int psize) {
        //    Graphics graphics = pbxCanvas.CreateGraphics();
        //    for (int i = 0; i < psize; i++)
        //        for (int j = 0; j < psize; j++)
        //        {
        //            numberDraw(graphics, pboard[i][j], i * (pbxCanvas.Width / psize), j * (pbxCanvas.Height / psize));
        //        }
        //    pbxCanvas.Invalidate();
        //}

        public void boardDraw(int[][] pboard, int psize) {
            size = psize;
            board = pboard;
            cellCenters = new Point[size][];
            for(int i=0; i<size; i++) cellCenters[i] = new Point[size];
            pbxCanvas.Invalidate();
        }

        private void pbxCanvas_Click(object sender, EventArgs e)
        {
            numberBorderDraw(pbxCanvas.CreateGraphics(), 5,5);
            // pbxCanvas.Invalidate();
        }

        private void numberBorderDraw(Graphics pgraphics, int px, int py) {
            pgraphics.DrawRectangle(new Pen(Brushes.Green), px, py, 25, 25);
        }

        private void pbxCanvas_Paint(object sender, PaintEventArgs e)
        {
            //boardDraw(e.Graphics);
            //statusChange("Отрисовано");
            int psize = size;
            Graphics pgraphics = e.Graphics;
            for (int i = 0; i < psize; i++)
                for (int j = 0; j < psize; j++)
                {
                    cellCenters[j][i].X = i * (pbxCanvas.Width / psize);
                    cellCenters[j][i].Y = j * (pbxCanvas.Height / psize);
                    numberDraw(pgraphics, board[i][j], cellCenters[j][i].X, cellCenters[j][i].Y);
                }
            //pbxCanvas.Invalidate();
        }

        private void numberDraw(Graphics pgraphics, int pnum, int px, int py) {
            pgraphics.DrawString(Convert.ToString(pnum), new Font("Times New Roman", 24, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, new PointF(px, py));
        }
    }
}
