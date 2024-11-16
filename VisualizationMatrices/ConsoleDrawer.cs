using System.Drawing;

namespace VisualizationMatrices
{
    class ConsoleDrawer : IDrawer
    {
        protected TextBox textBox;
        public ConsoleDrawer(TextBox textBox)
        {
            this.textBox = textBox;
        }
        public void BeginDraw(IMatrix matrix)
        {
            textBox.Text = "";
        }

        public void BeginDrawItem(IMatrix matrix, int row, int col) { }

        public void BeginDrawRow(IMatrix matrix, int row) { }

        public virtual void DrawBorder(IMatrix matrix)
        {
            int rowCount = matrix.CountRows;
            for (int i = 0; i < rowCount; i++)
            {
                textBox.Text += Environment.NewLine;
            }
        }

        public void DrawItem(int value, int row, int col, int countColumns)
        {
            Console.WriteLine($"row: {row}, col: {col}, value: {value}");
            if (col == countColumns - 1)
            {
                textBox.Paste(value.ToString());
            }
            else
            {
                textBox.Paste(value.ToString() + " ");
            }
        }

        public void DrawItemBorder(IMatrix matrix, int row, int col) { }

        public void EndDraw(IMatrix matrix) { }

        public void EndDrawItem(IMatrix somatrixmeMatrix, int row, int col) { }

        public void EndDrawRow(IMatrix matrix, int row)
        {
            
            string[] lines = textBox.Lines;
            int start = lines[row + 1].Length / 2;
            for (int i = 0; i < row + 1; i++)
            {
                start += lines[i].Length + 2; // \r\n - это 2 символа
            }
            textBox.SelectionStart = start;
            
        }

        public virtual IDrawer Dispose() => this;

        public void SetColor(Color color) { }
    }

    class AddConsoleBorder : ConsoleDrawer
    {

        IDrawer drawer;

        public AddConsoleBorder(IDrawer drawer, TextBox textBox) : base(textBox)
        {
            this.drawer = drawer;
        }

        public override void DrawBorder(IMatrix matrix)
        {
            drawer.DrawBorder(matrix);
            string text = textBox.Text;
            text = "|" + text.Replace(Environment.NewLine, $"|{Environment.NewLine}|");
            textBox.Text = text.Substring(0, text.Length - 1);
            textBox.SelectionStart = textBox.Lines[0].Length / 2;
        }

        public override IDrawer Dispose()
        {
            return drawer;
        }
    }


}
