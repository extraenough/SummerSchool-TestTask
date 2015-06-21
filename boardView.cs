using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool_TestTask
{
    class boardView
    {
        public mainForm form;

        public boardView(int[][] pboard, int psize) {
            form = new mainForm();
            form.Show();
            form.boardDraw(pboard, psize);
        }



    }
}
