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
        IMatrix matrix;
        RenumberingDecorator matrix_dec;
        bool is_matrix = false;

        //Border bord;

        public Form1()
        {
            InitializeComponent();
            Program.form = this;
            drawer = new ConsoleDrawer(textBox);
            graphicsDrawer = new GraphicsDrawer(dataGridView);
        }

        private void btnGenerateMatrix(object sender, EventArgs e)
        {
            renum.Enabled = true;
            recover.Enabled = true;
            matrix = new Matrix(3, 3);
            InitMatrix.FillMatrix(matrix, 5, 10);
            matrix.Draw(drawer);
            matrix.Draw(graphicsDrawer);
            is_matrix = false;
        }

        private void btnSparseMatrix_Click(object sender, EventArgs e)
        {
            renum.Enabled = true;
            recover.Enabled = true;
            matrix = new SparseMatrix(3, 3);
            InitMatrix.FillMatrix(matrix, 5, 10);
            matrix.Draw(drawer);
            matrix.Draw(graphicsDrawer);
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

                //graphicsDrawer.Dispose();
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
            matrix = matrix_dec.Recover();
            matrix.Draw(drawer);
            matrix.Draw(graphicsDrawer);            
        }

        private void renum_Click(object sender, EventArgs e)
        {
            matrix_dec = new RenumberingDecorator(matrix);
            matrix_dec.RenumerateColumns();
            matrix_dec.RenumerateRows();
            matrix_dec.Draw(drawer);
            matrix_dec.Draw(graphicsDrawer);
        }
    }
}
