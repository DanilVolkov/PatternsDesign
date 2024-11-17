using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    abstract class ACommand : ICommand
    {
        public void Execute()
        {
            DoExecute();
        }

        public abstract void Undo();

        protected abstract void DoExecute();

        public abstract ICommand Copy();
    }
}
