using System.Runtime.InteropServices;

namespace VisualizationMatrices
{
    public partial class Form1 : Form
    {

        IDrawer drawer;
        IDrawer graphicsDrawer;

        //Border bord;

        public Form1()
        {
            Program.form = this;
            //bord = new NoBord();
            drawer = new ConsoleDrawer();
            graphicsDrawer = new GraphicsDrawer();
            InitializeComponent();
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
                drawer = new ConsoleBorder(drawer);
                graphicsDrawer = new GraphicsBorder(graphicsDrawer);
            }
            else
            {
                drawer = new ConsoleDrawer();
                //drawer = drawer.Dispose(); // как бы правильно сделать раздекорирование?

                graphicsDrawer = new GraphicsDrawer();
            }
        }
    }
}
