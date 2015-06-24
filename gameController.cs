using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool_TestTask
{
    class gameController
    {
        private int size;
        private int[][] board;
        private int cellRemoved_x, cellRemoved_y;
        private boardView view;
        private List<String> history;

        public gameController(int psize = 3) {            
            history = new List<string>();
            cellRemoved_x = -1;
            cellRemoved_y = -1;
            board = new int[3][];
            for (int i = 0; i < 3; i++) { board[i] = new int[3]; }


            size = psize;
            boardFill();
            cellsShuffle((new Random()).Next(size, 3 * size));
            firstCellRemove();
            view = new boardView(board, size);
            //game_start();
        }

        // game
        private void game_start() {
            while (!boardCompleteCheck()){ 
                
            }
            addHistoryMessage("Game over!");
        }
        
        // board fill
        private void boardFill() {
            int count = 1;
            for (int i = 0; i < size; i++) for (int j = 0; j < size; j++) { 
                board[j][i] = count;
                count++;
            } 
        }

        // board shuffle
        private void cellsShuffle(int pmovesCount)
        {
            Random randomizer = new Random();
            int cell1_x = -1, cell1_y = -1;
            int cell2_x = -1, cell2_y = -1;

            for (int i = 0; i < pmovesCount; i++) {
                cell1_x = randomizer.Next(0, size);
                cell1_y = randomizer.Next(0, size);
                cell2_x = randomizer.Next(0, size);
                do{
                    cell2_y = randomizer.Next(0, size);
                }while(cell1_y == cell2_y);
                cellsSwap(cell1_y, cell1_x, cell2_y, cell2_x);
            }
        }

        private void cellsSwap(int pcell1_y, int pcell1_x, int pcell2_y,int pcell2_x)
        {
            int buffer = board[pcell1_y][pcell1_x];
            board[pcell1_y][pcell1_x] = board[pcell2_y][pcell2_x];
            board[pcell2_y][pcell2_x] = buffer;
        }

        private void firstCellRemove(){
            Random randomizer = new Random();
            int cell1_x = -1, cell1_y = -1;
            cell1_x = randomizer.Next(0, size);
            cell1_y = randomizer.Next(0, size);

            cellRemoved_x = cell1_x; cellRemoved_y = cell1_y;
        }

        private bool boardCompleteCheck() {
            bool result = true;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size && result; j++)
                    if (board[i][j] != i + j) { result = false; }
            return result; 
        }

        // history
        private void addHistoryMessage(string message) {
            history.Add(message);
        } 

    }
}
