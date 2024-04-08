using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu1
{
    public partial class tetris : Form
    {
        Shape currentShape;
        int size;
        int[,] map = new int[16, 8];
        int linesRemoved;
        int score;
        int Interval;
        
        public tetris()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(keyFunc);
            Init();
        }

        public void Init()
        {
            size = 25;
            score = 0;
            linesRemoved = 0;
            currentShape = new Shape(3, 0);
            Interval = 300;
            label1.Text = "Резултат: " + score;
            label2.Text = "Ниво: " + linesRemoved;



            timer1.Interval = Interval;
            timer1.Tick += new EventHandler(update);
            timer1.Start();


            Invalidate();
        }

        private void keyFunc(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (!IsIntersects())
                    {
                        ResetArea();
                        currentShape.RotateShape();
                        Merge();
                        Invalidate();
                    }
                    break;
                case Keys.Space:
                    timer1.Interval = 10;
                    break;
                case Keys.Right:
                    if (!CollideHor(1))
                    {
                        ResetArea();
                        currentShape.MoveRight();
                        Merge();
                        Invalidate();
                    }
                    break;
                case Keys.Left:
                    if (!CollideHor(-1))
                    {
                        ResetArea();
                        currentShape.MoveLeft();
                        Merge();
                        Invalidate();
                    }
                    break;
            }
        }
        public void ShowNextShape(Graphics e)
        {
            for (int i = 0; i < currentShape.sizeNextMatrix; i++)
            {
                for (int j = 0; j < currentShape.sizeNextMatrix; j++)
                {
                    if (currentShape.nextMatrix[i, j] == 1)
                    {
                        e.FillRectangle(Brushes.Red, new Rectangle(300 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (currentShape.nextMatrix[i, j] == 2)
                    {
                        e.FillRectangle(Brushes.Yellow, new Rectangle(300 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (currentShape.nextMatrix[i, j] == 3)
                    {
                        e.FillRectangle(Brushes.Green, new Rectangle(300 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (currentShape.nextMatrix[i, j] == 4)
                    {
                        e.FillRectangle(Brushes.Blue, new Rectangle(300 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (currentShape.nextMatrix[i, j] == 5)
                    {
                        e.FillRectangle(Brushes.Purple, new Rectangle(300 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                }
            }
        }

        private void update(object sender, EventArgs e)
        {
            ResetArea();
            if (!Collide())
            {
                currentShape.MoveDown();
            }
            else
            {
                Merge();
                SliceMap();
                timer1.Interval = Interval;
                currentShape.ResetShape(3, 0);
                if (Collide())
                {
                    for (int i = 0; i < 16; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            map[i, j] = 0;
                        }
                    }
                    timer1.Tick -= new EventHandler(update);
                    timer1.Stop();
                    Init();
                }
            }
            Merge();
            Invalidate();
        }

        public void SliceMap()
        {
            int count = 0;
            int curRemovedLines = 0;
            for (int i = 0; i < 16; i++)
            {
                count = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (map[i, j] != 0)
                        count++;
                }
                if (count == 8)
                {
                    curRemovedLines++;
                    for (int k = i; k >= 1; k--)
                    {
                        for (int o = 0; o < 8; o++)
                        {
                            map[k, o] = map[k - 1, o];
                        }
                    }
                }
            }
            for (int i = 0; i < curRemovedLines; i++)
            {
                score += 10 * (i + 1);
            }
            linesRemoved += curRemovedLines;

            if (linesRemoved % 5 == 0)
            {
                if (Interval > 60)
                    Interval -= 10;
            }

            label1.Text = "Резултат: " + score;
            label2.Text = "Ниво: " + linesRemoved;
        }

        public bool IsIntersects()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (j >= 0 && j <= 7)
                    {
                        if (map[i, j] != 0 && currentShape.matrix[i - currentShape.y, j - currentShape.x] == 0)
                            return true;
                    }
                }
            }
            return false;
        }

        public void Merge()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                        map[i, j] = currentShape.matrix[i - currentShape.y, j - currentShape.x];
                }
            }
        }

        public bool Collide()
        {
            for (int i = currentShape.y + currentShape.sizeMatrix - 1; i >= currentShape.y; i--)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                    {
                        if (i + 1 == 16)
                            return true;
                        if (map[i + 1, j] != 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool CollideHor(int dir)
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                    {
                        if (j + 1 * dir > 7 || j + 1 * dir < 0)
                            return true;

                        if (map[i, j + 1 * dir] != 0)
                        {
                            if (j - currentShape.x + 1 * dir >= currentShape.sizeMatrix || j - currentShape.x + 1 * dir < 0)
                            {
                                return true;
                            }
                            if (currentShape.matrix[i - currentShape.y, j - currentShape.x + 1 * dir] == 0)
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        public void ResetArea()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (i >= 0 && j >= 0 && i < 16 && j < 8)
                    {
                        if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                        {
                            map[i, j] = 0;
                        }
                    }
                }
            }
        }

        public void DrawMap(Graphics e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (map[i, j] == 1)
                    {
                        e.FillRectangle(Brushes.Red, new Rectangle(50 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 2)
                    {
                        e.FillRectangle(Brushes.Yellow, new Rectangle(50 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 3)
                    {
                        e.FillRectangle(Brushes.Green, new Rectangle(50 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 4)
                    {
                        e.FillRectangle(Brushes.Blue, new Rectangle(50 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 5)
                    {
                        e.FillRectangle(Brushes.Purple, new Rectangle(50 + j * (size) + 1, 50 + i * (size) + 1, size - 1, size - 1));
                    }
                }
            }
        }
        public void DrawGrid(Graphics g)
        {
            for (int i = 0; i <= 16; i++)
            {
                g.DrawLine(Pens.Black, new Point(50, 50 + i * size), new Point(50 + 8 * size, 50 + i * size));
            }
            for (int i = 0; i <= 8; i++)
            {
                g.DrawLine(Pens.Black, new Point(50 + i * size, 50), new Point(50 + i * size, 50 + 16 * size));
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
            DrawMap(e.Graphics);
            ShowNextShape(e.Graphics);
        }

        public class Shape
        {
            public int x;
            public int y;
            public int[,] matrix;
            public int[,] nextMatrix;
            public int sizeMatrix;
            public int sizeNextMatrix;

            public int[,] tetr1 = new int[4, 4]{
            {0,0,1,0  },
            {0,0,1,0  },
            {0,0,1,0  },
            {0,0,1,0  },
        };

            public int[,] tetr2 = new int[3, 3]{
            {0,2,0  },
            {0,2,2 },
            {0,0,2 },
        };

            public int[,] tetr3 = new int[3, 3]{
            {0,0,0  },
            {3,3,3 },
            {0,3,0 },
        };

            public int[,] tetr4 = new int[3, 3]{
            { 4,0,0  },
            {4,0,0 },
            {4,4,0 },
        };
            public int[,] tetr5 = new int[2, 2]{
            { 5,5  },
            {5,5 },
        };


            public Shape(int _x, int _y)
            {
                x = _x;
                y = _y;
                matrix = GenerateMatrix();
                sizeMatrix = (int)Math.Sqrt(matrix.Length);
                nextMatrix = GenerateMatrix();
                sizeNextMatrix = (int)Math.Sqrt(nextMatrix.Length);
            }

            public void ResetShape(int _x, int _y)
            {
                x = _x;
                y = _y;
                matrix = nextMatrix;
                sizeMatrix = (int)Math.Sqrt(matrix.Length);
                nextMatrix = GenerateMatrix();
                sizeNextMatrix = (int)Math.Sqrt(nextMatrix.Length);
            }

            public int[,] GenerateMatrix()
            {
                int[,] _matrix = tetr1;
                Random r = new Random();
                switch (r.Next(1, 6))
                {
                    case 1:
                        _matrix = tetr1;
                        break;
                    case 2:
                        _matrix = tetr2;
                        break;
                    case 3:
                        _matrix = tetr3;
                        break;
                    case 4:
                        _matrix = tetr4;
                        break;
                    case 5:
                        _matrix = tetr5;
                        break;
                }
                return _matrix;
            }

            public void RotateShape()
            {
                int[,] tempMatrix = new int[sizeMatrix, sizeMatrix];
                for (int i = 0; i < sizeMatrix; i++)
                {
                    for (int j = 0; j < sizeMatrix; j++)
                    {
                        tempMatrix[i, j] = matrix[j, (sizeMatrix - 1) - i];
                    }
                }
                matrix = tempMatrix;
                int offset1 = (8 - (x + sizeMatrix));
                if (offset1 < 0)
                {
                    for (int i = 0; i < Math.Abs(offset1); i++)
                        MoveLeft();
                }

                if (x < 0)
                {
                    for (int i = 0; i < Math.Abs(x) + 1; i++)
                        MoveRight();
                }

            }

            public void MoveDown()
            {
                y++;
            }
            public void MoveRight()
            {
                x++;
            }
            public void MoveLeft()
            {
                x--;
            }
        }

        private void tetris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Menu option = new Game_Menu();
            option.ShowDialog();
        }

        private void tetris_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Game_Menu option = new Game_Menu();
            option.ShowDialog();
        }

        private void tetris_Load_1(object sender, EventArgs e)
        {

        }
    }
}