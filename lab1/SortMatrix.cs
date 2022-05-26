using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class SortMatrix
    {
        public void SortingMatrix(Matrix matrix, bool order,  IBaseAlgorithm algorithm)
        {
            for (int i = 1; i < matrix.Rows; i++)
            {
                int key = algorithm.Handle(matrix[i]);
                int[] tempRow = matrix[i]; 
                int j = i - 1;

                while (j >= 0 && Order(order, algorithm.Handle(matrix[j]), key))
                {
                    matrix[j + 1] = matrix[j];
                    j = j - 1;
                }
                matrix[j + 1] = tempRow;
            }

        }

        private bool Order(bool order, int x1, int x2)
        {
            if (order)
            {
                return x1 > x2;
            }
            else
            {
                return x1 < x2;
            }
        }
    }
}
