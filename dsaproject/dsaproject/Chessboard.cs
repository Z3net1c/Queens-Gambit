using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaproject
{
    class Chessboard
    {
        
            private int[,] board; // 2D array to represent the chessboard
            private int boardSize; // Size of the board (e.g., 4 for a 4x4 board)

            // Constructor to initialize the chessboard
            public Chessboard(int size)
            {
                boardSize = size;
                board = new int[boardSize, boardSize];
                InitializeBoard();
            }

            // Method to initialize the board with all cells empty (0)
            private void InitializeBoard()
            {
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        board[i, j] = 0; // 0 represents an empty cell
                    }
                }
            }

            // Method to place a queen on the board at a specified position
            public bool PlaceQueen(int row, int col)
            {
                // Check if the cell is empty and within bounds
                if (row < 0 || row >= boardSize || col < 0 || col >= boardSize || board[row, col] != 0)
                {
                    return false; // Queen cannot be placed here
                }

                // Place the queen
                board[row, col] = 1; // 1 represents a queen
                return true;
            }

            // Method to remove a queen from the board at a specified position
            public bool RemoveQueen(int row, int col)
            {
                // Check if the cell contains a queen
                if (row < 0 || row >= boardSize || col < 0 || col >= boardSize || board[row, col] != 1)
                {
                    return false; // No queen to remove
                }

                // Remove the queen
                board[row, col] = 0; // Set the cell as empty
                return true;
            }

            // Method to retrieve the current state of the board
            public int[,] GetBoardState()
            {
                return board;
            }
        
    }
}
