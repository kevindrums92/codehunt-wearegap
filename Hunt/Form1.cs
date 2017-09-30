using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunt
{
    public partial class Form1 : Form
    {
        public List<string[]> ListLines { get; set; }
        int rowLenght;
        int colLenght;
        GarayDev.MazeAgent maze;
        int[,] maze2DArray;
        int cellSize = 9;
        int houndX = 59, houndY = 82;
        int iPreyX = 17, iPreyY = 25;

        public Form1()
        {
            InitializeComponent();
            InitializeMaze();
        }

        void InitializeMaze()
        {
            lbHoundPosition.Text = string.Format("[{0},{1}]", houndX, houndY);
            lbPreyPosition.Text = string.Format("[{0},{1}]", iPreyX, iPreyY);

            ListLines = new List<string[]>();
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string xslLocation = Path.Combine(executableLocation, "Hound Maze(tsv).txt");

            using (StreamReader reader = new StreamReader(xslLocation))
            {
                int lineNumber = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');
                    ListLines.Add(parts);
                    lineNumber += 1;
                }

                if (ListLines.Count > 0) {
                    colLenght = ListLines.Max(z => z.Length);
                    rowLenght = ListLines.Count;
                    maze = new GarayDev.MazeAgent(rowLenght, colLenght);
                    maze2DArray = maze.GetMaze;
                    SetWalls();
                    FindPath();
                    this.pcMaze.Size = new System.Drawing.Size(colLenght * cellSize + 3, rowLenght * cellSize + 3);
                    
                }
            }
        }

        private void SetWalls()
        {
            var row = 0;
            foreach (string[] thisRow in ListLines)
            {
                for (var col = 0; col < thisRow.Length; col++) {
                    if(thisRow[col] != "F")
                    {
                        maze2DArray[row, col] = 1;
                    }
                }
                row++;
            }
        }

        void FindPath()
        {
            int[,] iSolvedMaze = maze.FindPath(houndY, houndX, iPreyY, iPreyX);
            if (iSolvedMaze != null)
            {
                maze2DArray = iSolvedMaze;
                for (int i = 0; i < rowLenght; i++)
                    for (int j = 0; j < colLenght; j++)
                    {
                        if (maze2DArray[i, j] == 100)
                        {
                            txtSolutionPath.Text += string.Format("[{0},{1}], ",j,i);
                        }
                    }
            }
        }

        private void pcMaze_MouseMove(object sender, MouseEventArgs e)
        {
            int iY = e.Y / cellSize;
            int iX = e.X / cellSize;
            if (iX < colLenght && iX >= 0 && iY < rowLenght && iY >= 0)
            {
                this.lbCurrentPosition.Text = string.Format("X: {0}, Y: {1}", iX, iY);
            }
        }

        public static IEnumerable<T[]> Filter<T>(T[,] source, Func<T[], bool> predicate)
        {
            for (int i = 0; i < source.GetLength(0); ++i)
            {
                T[] values = new T[source.GetLength(1)];
                for (int j = 0; j < values.Length; ++j)
                {
                    values[j] = source[i, j];
                }
                if (predicate(values))
                {
                    yield return values;
                }
            }
        }

        private void pcMaze_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            for (int i = 0; i < rowLenght; i++)
                for (int j = 0; j < colLenght; j++)
                {
                    if (maze2DArray[i, j] == 1)
                        myGraphics.FillRectangle(new SolidBrush(Color.DarkGray), j * cellSize + 1, i * cellSize + 1, cellSize - 1, cellSize - 1);
     
                    if (maze2DArray[i, j] == 100)
                        myGraphics.FillRectangle(new SolidBrush(Color.LightGreen), j * cellSize + 1, i * cellSize + 1, cellSize - 1, cellSize - 1);
                }
            

            myGraphics.FillEllipse(new SolidBrush(Color.DarkBlue), this.houndX * cellSize + (cellSize / 4),
                this.houndY * cellSize + 2, cellSize - (cellSize / 2), cellSize - (cellSize / 2));
            myGraphics.FillEllipse(new SolidBrush(Color.DarkOrange), this.iPreyX * cellSize + (cellSize / 4),
                this.iPreyY * cellSize + 2, cellSize - (cellSize / 2), cellSize - (cellSize / 2));
        }
    }
}
