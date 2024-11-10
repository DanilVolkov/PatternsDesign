using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace VisualizationMatrices
{
    public partial class Form1 : Form
    {

        IDrawer drawer;
        GraphicsDrawer graphicsDrawer;
        IMatrix matrix1, matrix2, matrix3, matrix4, matrix5, matrix6, matrix7;
        HGroupMatrices ghMatrix1, ghMatrix2;
        VGroupMatrices ghMatrix3;
        DrawMatrix drawMatrix = new DrawMatrix();
        DrawSparseMatix sparseMatrix = new DrawSparseMatix();
        RenumberingDecorator matrix_dec;
        bool is_matrix = false;

        // реализовать требовани€ по цвету и границам в отдельном классе
        // дл€ разреженных матриц - зеленый фон, а дл€ остальных белый

        public Form1()
        {
            InitializeComponent();
            Program.form = this;

            matrix1 = new Matrix(2, 2);
            matrix2 = new Matrix(3, 3);
            matrix3 = new SparseMatrix(5, 1);
            matrix4 = new SparseMatrix(1, 1);
            matrix5 = new SparseMatrix(2, 4);
            matrix6 = new Matrix(2, 3);
            matrix7 = new Matrix(2, 1);

            InitMatrixValue(matrix1, 1);
            InitMatrixValue(matrix2, 2);
            InitMatrixValue(matrix3, 3);
            InitMatrixValue(matrix4, 4);
            InitMatrixValue(matrix5, 5);
            InitMatrixValue(matrix6, 6);
            InitMatrixValue(matrix7, 7);

            ghMatrix1 = new HGroupMatrices(matrix1, matrix2, matrix3);
            ghMatrix2 = new HGroupMatrices(matrix5, matrix6);
            ghMatrix1.AddMatrix(matrix4);

            ghMatrix3 = new VGroupMatrices(ghMatrix1, ghMatrix2);
            ghMatrix3.AddMatrix(matrix7);

            drawer = new ConsoleDrawer(textBox);
            graphicsDrawer = new GraphicsDrawer(dataGridView);
        }

        private void btnGenerateMatrix(object sender, EventArgs e)
        {
            renum.Enabled = true;
            recover.Enabled = true;
            //matrix = new Matrix(3, 3);
            //InitMatrix.FillMatrix(matrix, 5, 10);
            drawMatrix.Draw(ghMatrix3, drawer);
            drawMatrix.Draw(ghMatrix3, graphicsDrawer);

            is_matrix = false;
        }

        private void btnSparseMatrix_Click(object sender, EventArgs e)
        {
            renum.Enabled = true;
            recover.Enabled = true;
            //matrix = new SparseMatrix(3, 3);
            //InitMatrix.FillMatrix(matrix, 5, 10);
            sparseMatrix.Draw(ghMatrix3, drawer);
            sparseMatrix.Draw(ghMatrix3, graphicsDrawer);

            is_matrix = true;
        }

        private void checkBoxEdge_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                drawer = new AddConsoleBorder(drawer, textBox);
                graphicsDrawer.AddBorder();
            }
            else
            {
                // проверка на декоратор
                //drawer = new AddConsoleBorder(drawer, textBox);
                //graphicsDrawer.AddBorder();

                drawer = drawer.Dispose();
                graphicsDrawer.DelBorder();
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is null)
            {
                e.CellStyle.BackColor = SystemColors.Control;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }

        private void recover_Click(object sender, EventArgs e)
        {
            IMatrix matrix = matrix_dec.Recover();
            if (!is_matrix)
            {
                drawMatrix.Draw(matrix, drawer);
                drawMatrix.Draw(matrix, graphicsDrawer);
            }
            else
            {
                sparseMatrix.Draw(matrix, drawer);
                sparseMatrix.Draw(matrix, graphicsDrawer);
            }
        }

        private void renum_Click(object sender, EventArgs e)
        {
            //matrix_dec = new RenumberingDecorator(matrix);
            matrix_dec = new RenumberingDecorator(ghMatrix3);
            matrix_dec.RenumerateColumns();
            matrix_dec.RenumerateRows();

            if (!is_matrix)
            {
                drawMatrix.Draw(matrix_dec, drawer);
                drawMatrix.Draw(matrix_dec, graphicsDrawer);
            }
            else
            {
                sparseMatrix.Draw(matrix_dec, drawer);
                sparseMatrix.Draw(matrix_dec, graphicsDrawer);
            }

            
        }

        void InitMatrixValue(IMatrix matrix, int value)
        {
            for (int i = 0; i < matrix.CountRows; i++)
                for (int j = 0; j < matrix.CountColumns; j++)
                    matrix.SetItem(i, j, value);
        }


    }
}
