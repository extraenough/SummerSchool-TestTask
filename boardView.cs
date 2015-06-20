using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool_TestTask
{
    class boardView
    {
        private int[][] board;
        private mainForm form;

        public boardView(int x = 3, int y = 3) {
            for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) { board[i][j] = i + j; }
            form = new mainForm();
        }



    }
}
