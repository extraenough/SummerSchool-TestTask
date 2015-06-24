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

        private int boardSize;
        private double marginLeft;
        private double marginTop;
        private double cellSize;
        private Point[] cellsClicked;
        private int[][] board;
        private Point[][] cellCorners;

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
            
            boardSize = 0;
            marginLeft = 0.0;
            marginTop = 0.0;
            cellSize = 0.0;
            cellsClicked = new Point[2];
            for (int i = 0; i < 2; i++) cellsClicked[i] = new Point(-1, -1);
        }

        private void statusChange(string pstatus) { tlstrpStatus.Text = pstatus; }

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
            boardSize = psize;
            board = pboard;
            cellSize = pbxCanvas.Width / (boardSize + 1);
            marginLeft = pbxCanvas.Width / (boardSize + 1) / (boardSize + 1);
            marginTop = pbxCanvas.Height / (boardSize + 1) / (boardSize + 1);
            cellCorners = new Point[boardSize][];
            for (int i = 0; i < boardSize; i++){
                cellCorners[i] = new Point[boardSize];
                for(int j=0; j<boardSize; j++){
                    cellCorners[i][j] = new Point();
                    cellCorners[i][j].X = (int)(i * (cellSize + marginLeft));
                    cellCorners[i][j].Y = (int)(j * (cellSize + marginTop));
                }
            }
            pbxCanvas.Invalidate();
        }

        private void numberBorderDraw(Graphics pgraphics, int px, int py) {
            pgraphics.DrawRectangle(new Pen(Brushes.Green), px, py, 25, 25);
        }

        private void pbxCanvas_Paint(object sender, PaintEventArgs e)
        {
            //boardDraw(e.Graphics);
            //statusChange("Отрисовано");
            int psize = boardSize;
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.Aquamarine);
            for (int i = 0; i < psize; i++)
                for (int j = 0; j < psize; j++)
                {
                    graphics.DrawRectangle(new Pen(Brushes.Black), cellCorners[j][i].X, cellCorners[j][i].Y, (float)cellSize, (float)cellSize);
                    numberDraw(graphics, board[i][j], cellCorners[j][i].X, cellCorners[j][i].Y);
                }
            //pbxCanvas.Invalidate();
        }

        private void numberDraw(Graphics pgraphics, int pnum, int px, int py) {
            pgraphics.DrawString(Convert.ToString(pnum), new Font("Comic Sans MS", (float)(cellSize / 3), FontStyle.Bold, GraphicsUnit.Pixel),
                Brushes.Black, new PointF((float)(px + cellSize / 3), (float)(py + cellSize / 3)));
        }

        //private bool checkCellClicked(int px, int py) {
        //    bool result = false;
        //    for (int i = 0; i < boardSize; i++)
        //        for (int j = 0; j < boardSize; j++)
        //            if ((px - cellCorners[j][i].X <= cellSize)
        //                && (py - cellCorners[j][i].Y <= cellSize))
        //                result = true;
        //    return result;
        //}

        private void paintCellClicked(Graphics pgraphics, Point pCorner) {
            pgraphics.FillRectangle(new SolidBrush(Color.FromArgb(250 / 100 * 25, 255, 0, 0 )), pCorner.X + 1, pCorner.Y + 1, (int)(cellSize - 1), (int)(cellSize - 1));
            numberDraw(pgraphics, getCellClickedNumber(pCorner.X, pCorner.Y), pCorner.X, pCorner.Y);
        }

        private void clearCellClicked(Graphics pgraphics, Point pCorner){
            pgraphics.FillRectangle(Brushes.Aquamarine, pCorner.X + 1, pCorner.Y + 1, (int)(cellSize - 1), (int)(cellSize - 1));
            numberDraw(pgraphics, getCellClickedNumber(pCorner.X, pCorner.Y), pCorner.X, pCorner.Y);            
        }

        private Point getCellClicked(int px, int py) {
            int x = -1, y = -1;
            for (int i = 0; i < boardSize; i++)
                for (int j = 0; j < boardSize; j++)
                    if ((px - cellCorners[j][i].X <= cellSize)
                        && (py - cellCorners[j][i].Y <= cellSize)
                        && (px >= cellCorners[j][i].X)
                        && (py >= cellCorners[j][i].Y)){
                            x = cellCorners[j][i].X;
                            y = cellCorners[j][i].Y;
                    }
            return new Point(x,y);
        }

        private int getCellClickedNumber(int px, int py) { 
            int x = -1, y = -1;
            for (int i = 0; i < boardSize; i++)
                for (int j = 0; j < boardSize; j++)
                    if ((px - cellCorners[j][i].X <= cellSize)
                        && (py - cellCorners[j][i].Y <= cellSize)
                        && (px >= cellCorners[j][i].X)
                        && (py >= cellCorners[j][i].Y)){
                            x = j;
                            y = i;
                            break;
                    }
            if (x != -1 && y != -1){
                return board[y][x];
            } else return -1;
        }

        private Point getCellClickedIndexes(int px, int py)
        {
            Point result = new Point(-1, -1);
            for (int i = 0; i < boardSize; i++)
                for (int j = 0; j < boardSize; j++)
                    if ((px - cellCorners[j][i].X <= cellSize)
                        && (py - cellCorners[j][i].Y <= cellSize)
                        && (px >= cellCorners[j][i].X)
                        && (py >= cellCorners[j][i].Y))
                    {
                        result.X = i;
                        result.Y = j;
                        break;
                    }
            return result;
        }

        private bool checkCellsClickedAvailable(int px, int py) {
            bool result = true;

            if (cellsClicked[0].X == -1 && cellsClicked[0].Y == -1)
            {
                cellsClicked[0].X = px;
                cellsClicked[0].Y = py;
            }
            else if (cellsClicked[1].X == -1 && cellsClicked[1].Y == -1)
            {
                cellsClicked[1].X = px;
                cellsClicked[1].Y = py;
            }
            else result = false;

            return result;
        }

        private void cellsSwap(Point pfirst, Point psecond) {
            int buffer = board[pfirst.Y][pfirst.X];
            board[pfirst.Y][pfirst.X] = board[psecond.Y][psecond.X];
            board[psecond.Y][psecond.X] = buffer;
        }

        private bool cellClickedOperate(int px, int py) {
            bool result = true;
            if (checkCellsClickedAvailable(px, py)){
                if (cellsClicked[0].X != -1 && cellsClicked[0].Y != -1 && cellsClicked[1].X != -1 && cellsClicked[1].Y != -1) {
                    Point first = getCellClickedIndexes(cellsClicked[0].X, cellsClicked[0].Y);
                    Point second = getCellClickedIndexes(cellsClicked[1].X, cellsClicked[1].Y);
                    if (
                        ((first.X - second.X <= 1) && (first.Y - second.Y <= 1)) ||
                        ((second.X - first.X <= 1) && (second.Y - first.Y <= 1))
                      ) {
                          if (!(
                              ((first.X - second.X == 1) && (first.Y - second.Y == 1)) ||
                              ((second.X - first.X == 1) && (second.Y - first.Y == 1)) ||
                              ((first.X - second.X == 1) && (second.Y - first.Y == 1)) ||
                              ((second.X - first.X == 1) && (first.Y - second.Y == 1))
                            )) {
                                if (!((first.X == second.X) && (first.Y == second.Y)))
                                {
                                    // функция обмена местами двух цифр
                                    cellsSwap(first, second);
                                    pbxCanvas.Invalidate();
                                }
                                else {
                                    // функция возврата цвета ячейке
                                    clearCellClicked(pbxCanvas.CreateGraphics(), cellCorners[first.X][first.Y]);
                                    result = false; 
                                }
                          }
                          else result = false;
                    }
                }
            }
            else result = false;
            return result;
        }

        private void pbxCanvas_MouseClick(object sender, MouseEventArgs e){
            Point p = getCellClicked(e.X, e.Y);
            if(p.X != -1 && p.Y != -1){
                paintCellClicked(pbxCanvas.CreateGraphics(), p);
            }
        }
    }
}
