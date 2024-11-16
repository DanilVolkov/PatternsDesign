using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class InitializeApplicationCommand : ACommand
    {
        public override void Undo() { }

        public override ICommand Copy()
        {
           return new InitializeApplicationCommand();
        }

        protected override void DoExecute() { }
    }
}
