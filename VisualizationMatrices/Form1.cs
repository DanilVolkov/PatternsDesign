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
        IMatrix matrix, matrix1, matrix2, matrix3, matrix4, matrix5, matrix6, matrix7;
        HGroupMatrices ghMatrix1, ghMatrix2;
        VGroupMatrices ghMatrix3;
        DrawMatrix drawMatrix = new DrawMatrix();
        DrawSparseMatix sparseMatrix = new DrawSparseMatix();
        RenumberingDecorator matrix_dec;
        bool is_matrix = false;
        bool is_v_group = false;
        bool is_h_group = false;

        // реализовать требовани€ по цвету и границам в отдельном классе
        // дл€ разреженных матриц - зеленый фон, а дл€ остальных белый

        public Form1()
        {
            InitializeComponent();
            Program.form = this;

            CommandManager.Instance().Registry(new InitializeApplicationCommand());

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
            ChangeEnabled(true);
            matrix = new Matrix(3, 3);
            InitMatrix.FillMatrix(matrix, 5, 10);
            drawMatrix.Draw(matrix, drawer);
            drawMatrix.Draw(matrix, graphicsDrawer);

            is_matrix = false;
            is_h_group = false;
            is_v_group = false;


        }

        private void btnSparseMatrix_Click(object sender, EventArgs e)
        {
            ChangeEnabled(true);
            matrix = new SparseMatrix(3, 3);
            InitMatrix.FillMatrix(matrix, 5, 10);
            sparseMatrix.Draw(matrix, drawer);
            sparseMatrix.Draw(matrix, graphicsDrawer);

            is_matrix = true;
            is_h_group = false;
            is_v_group = false;
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
            DrawMatrix(matrix);
        }

        private void renum_Click(object sender, EventArgs e)
        {

            if (is_h_group)
            {
                matrix_dec = new RenumberingDecorator(ghMatrix1);
            }
            else if (is_v_group)
            {
                matrix_dec = new RenumberingDecorator(ghMatrix3);
            }
            else
            {
                matrix_dec = new RenumberingDecorator(matrix);
            }


            matrix_dec.RenumerateColumns();
            matrix_dec.RenumerateRows();

            DrawMatrix(matrix_dec);

        }

        void InitMatrixValue(IMatrix matrix, int value)
        {
            for (int i = 0; i < matrix.CountRows; i++)
                for (int j = 0; j < matrix.CountColumns; j++)
                    matrix.SetItem(i, j, value);
        }

        private void ChangeEnabled(bool enable)
        {
            if (enable)
            {
                renum.Enabled = true;
                recover.Enabled = true;
                btnChange.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                renum.Enabled = false;
                recover.Enabled = false;
                btnChange.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void btnHGroupMatrix_Click(object sender, EventArgs e)
        {
            ChangeEnabled(true);
            drawMatrix.Draw(ghMatrix1, drawer);
            drawMatrix.Draw(ghMatrix1, graphicsDrawer);
            is_h_group = true;
            is_v_group = false;
            is_matrix = false;
        }

        private void btnHGroupSparseMatrix_Click(object sender, EventArgs e)
        {
            ChangeEnabled(true);
            sparseMatrix.Draw(ghMatrix1, drawer);
            sparseMatrix.Draw(ghMatrix1, graphicsDrawer);
            is_h_group = true;
            is_v_group = false;
            is_matrix = true;
        }

        private void btnVGroupMatrix_Click(object sender, EventArgs e)
        {
            ChangeEnabled(true);
            drawMatrix.Draw(ghMatrix3, drawer);
            drawMatrix.Draw(ghMatrix3, graphicsDrawer);
            is_h_group = false;
            is_v_group = true;
            is_matrix = false;
        }

        private void btnVGroupSparseMatrix_Click(object sender, EventArgs e)
        {
            ChangeEnabled(true);
            sparseMatrix.Draw(ghMatrix3, drawer);
            sparseMatrix.Draw(ghMatrix3, graphicsDrawer);
            is_h_group = false;
            is_v_group = true;
            is_matrix = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (is_h_group)
            {
                ACommand command = new WriteValueToMatrixCommand(ghMatrix1, 0, 0, 21);
                command.Execute();
                CommandManager.Instance().Registry(command);
                DrawMatrix(ghMatrix1);
            }
            else if (is_v_group)
            {
                ACommand command = new WriteValueToMatrixCommand(ghMatrix3, 0, 0, 21);
                command.Execute();
                CommandManager.Instance().Registry(command);
                DrawMatrix(ghMatrix3);
            }
            else
            {
                ACommand command = new WriteValueToMatrixCommand(matrix, 0, 0, 21);
                command.Execute();
                CommandManager.Instance().Registry(command);
                DrawMatrix(matrix);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommandManager.Instance().Undo();

            if (is_h_group)
            {
                DrawMatrix(ghMatrix1);
            }
            else if (is_v_group)
            {
                DrawMatrix(ghMatrix3);
            }
            else
            {
                DrawMatrix(matrix);
            }
        }

        private void DrawMatrix(IMatrix matrix)
        {
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

        
    }
}
