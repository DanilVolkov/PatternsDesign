using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VisualizationMatrices
{
    public partial class Form1 : Form
    {

        IDrawer drawer;
        IDrawer graphicsDrawer;

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
            Matrix matrix = new Matrix(3, 3);
            InitMatrix.FillMatrix(matrix, 5, 10);
            matrix.Draw(drawer);
            matrix.Draw(graphicsDrawer);
        }

        private void btnSparseMatrix_Click(object sender, EventArgs e)
        {
            SparseMatrix matrix = new SparseMatrix(3, 3);
            InitMatrix.FillMatrix(matrix, 5, 10);
            matrix.Draw(drawer);
            matrix.Draw(graphicsDrawer);
        }

        private void checkBoxEdge_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                drawer = new AddConsoleBorder(drawer, textBox);
                graphicsDrawer = new AddGraphicsBorder(graphicsDrawer, dataGridView);
            }
            else
            {
                drawer = drawer.Dispose();
                graphicsDrawer = new GraphicsDrawer(dataGridView);
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
    }
}
