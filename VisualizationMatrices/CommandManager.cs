using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class CommandManager
    {
        private Stack<ICommand> commands = new Stack<ICommand>();

        private static CommandManager instance;

        private CommandManager() { }

        public static CommandManager Instance()
        {
            if (instance == null)
            {
                instance = new CommandManager();
            }
            return instance;
        }

        public void Registry(ICommand command)
        {
            Instance();
            commands.Push(command.Copy());
            UpdateStack();
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                var command = commands.Pop();
                command.Undo();
            }


        }

        private void UpdateStack()
        {
            if (commands.Count > 10)
            {
                commands.Pop();
            }
        }
    }
}
