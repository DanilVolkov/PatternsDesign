namespace VisualizationMatrices
{
    interface IMatrix
    {

        public int CountRows { get; }

        public int CountColumns { get; }

        void SetItem(int row, int column, int value);

        int GetItem(int row, int column);

        void Draw(IDrawer drawer);
    }
}
