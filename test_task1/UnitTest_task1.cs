using NUnit.Framework;
using lab1_task2;
using lab1;

namespace tests
{
    public class Tests
    {

        [Test]
        public void MatrixSortingMaxElTest()
        {
            int res = 5;
            int[] arr = new int[] { 0, 5, 0 };

            SortByMaxElement sortByMaxElement = new SortByMaxElement();
            Assert.AreEqual(res, sortByMaxElement.Handle(arr));
        }

        [Test]
        public void MatrixSortingMinElTest()
        {
            int res = 0;
            int[] arr = new int[] { 1, 5, 0 };

            SortByMinElement sortByMinElement = new SortByMinElement();
            Assert.AreEqual(res, sortByMinElement.Handle(arr));
        }

        [Test]
        public void MatrixSortingSumTest()
        {
            int res = 6;
            int[] arr = new int[] { 1, 2, 3 };

            SortBySum sortBySum = new SortBySum();
            Assert.AreEqual(res, sortBySum.Handle(arr));
        }

        [Test]
        public void MatrixSortingSumUpTest()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 2, 2, 2 },
            new int[] { 0, 0, 0},
            new int[] { 1, 1, 1}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 0, 0, 0 },
                new int[] { 1, 1, 1 },
                new int[] { 2, 2, 2 }
                };

            sortMatrix.SortingMatrix(matrix, true, new SortBySum());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void MatrixSortingSumDownTest()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 2, 2, 2 },
            new int[] { 0, 0, 0},
            new int[] { 1, 1, 1}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 2, 2, 2 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 0, 0}
                };

            sortMatrix.SortingMatrix(matrix, false, new SortBySum());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void MatrixSortingMaxUpTest()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 5, 7, 6 },
            new int[] { 1, 2, 3},
            new int[] { 0, 0, 0}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 0, 0, 0 },
                new int[] { 1, 2, 3 },
                new int[] { 5, 7, 6}
                };

            sortMatrix.SortingMatrix(matrix, true, new SortByMaxElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void MatrixSortingMaxDownTest()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 0, 0, 0 },
                new int[] { 1, 2, 3 },
                new int[] { 5, 7, 6}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 5, 7, 6 },
            new int[] { 1, 2, 3},
            new int[] { 0, 0, 0}
                };

            sortMatrix.SortingMatrix(matrix, false, new SortByMaxElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }


        [Test]
        public void MatrixSortingMinUpTest()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 0, 6, 2 },
            new int[] { 3, 3, 3},
            new int[] { 1, 1, 1}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {

                new int[] { 0, 6, 2 },
                new int[] { 1, 1, 1},
                new int[] { 3, 3, 3}
                };

            sortMatrix.SortingMatrix(matrix, true, new SortByMinElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void MatrixSortingMinDownTest()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 0, 6, 2 },
            new int[] { 1, 1, 1},
            new int[] { 3, 3, 3}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 3, 3, 3 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 6, 2}
                };

            sortMatrix.SortingMatrix(matrix, false, new SortByMinElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matrix[i][j]);
                }
            }
        }
    }
}