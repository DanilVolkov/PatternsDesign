using System.Runtime.InteropServices;

namespace VisualizationMatrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.form = this;
            InitializeComponent();
        }

        private void btnGenerateMatrix(object sender, EventArgs e)
        {
            SparseMatrix matrix = new SparseMatrix(3, 3);
            InitMatrix.FillMatrix(matrix, 5, 10);
            matrix.Draw(new ConsoleDrawer());
        }
    }
}
