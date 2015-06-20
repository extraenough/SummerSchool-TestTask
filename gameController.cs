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
            view = new boardView();
            history = new List<string>();
            cellRemoved_x = -1;
            cellRemoved_y = -1;

            size = psize;
            boardFill();
            boardShuffle((new Random()).Next(size, 3*size));
            firstCellRemove();
            game_start();
        }

        // game
        private void game_start() {
            while (!boardCompleteCheck()){ 
                
            }
            addHistoryMessage("Game over!");
        }
        
        // board fill
        private void boardFill() { for (int i = 0; i < size; i++) for (int j = 0; j < size; j++) { board[i][j] = i + j; } }

        // board shuffle
        private void boardShuffle(int pmovesCount) {
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
                cellsSwap(cell1_x, cell1_y, cell2_x, cell2_y);
            }
        }

        private void cellsSwap(int pcell1_x, int pcell1_y, int pcell2_x, int pcell2_y){
            board[pcell1_x][pcell1_y] += board[pcell2_x][pcell2_y];
            board[pcell2_x][pcell2_y] = board[pcell1_x][pcell1_y] - board[pcell2_x][pcell2_y];
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
