using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaproject
{
    class nqueen_solver
    {
        public List<int[]> solutions; // List to store solutions

        public List<int[]> SolveNQueens(int n)
        {
            solutions = new List<int[]>();
            int[] queensPositions = new int[n];
            PlaceQueens(0, n, queensPositions);
            return solutions;
        }

        private void PlaceQueens(int row, int n, int[] queensPositions)
        {
            if (row == n)
            {
                int[] solution = new int[n];
                Array.Copy(queensPositions, solution, n);
                solutions.Add(solution);
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsSafe(row, col, queensPositions))
                {
                    queensPositions[row] = col;
                    PlaceQueens(row + 1, n, queensPositions);
                }
            }
        }

        private bool IsSafe(int row, int col, int[] queensPositions)
        {
            for (int i = 0; i < row; i++)
            {
                if (queensPositions[i] == col || queensPositions[i] - i == col - row || queensPositions[i] + i == col + row)
                    return false;
            }
            return true;
        }
    }
}
