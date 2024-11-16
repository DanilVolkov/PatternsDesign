﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class VGroupMatrices : HGroupMatrices
    {
        public VGroupMatrices(HGroupMatrices group) : base(group)
        {

        }

        public override int CountRows
        {
            get
            {
                return base.CountColumns;
            }
        }

        public override int CountColumns
        {
            get
            {
                return base.CountRows;
            }
        }

        public override int GetItem(int row, int column)
        {
            return base.GetItem(column, row);
        }

        public override void SetItem(int row, int column, int value)
        {
            base.SetItem(column, row, value);
        }

        //public override void Draw(int value, int row, int col, IDrawer drawer, int countColumns)
        //{
        //    base.Draw(value, row, col, drawer, countColumns);
        //}
    }
}
