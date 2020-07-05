using System.Collections.Generic;

namespace CommandPattern
{
    public class Command
    {
        // A stack is "Last In First Out (LIFO)" data structure, it will allow us to keep track of the exact order commands were executed (undo commands in correct order)
        private Stack<ICommand> commands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                commands.Push(command);
                command.Execute();
            }
        }

        public void Undo()
        {
            while(commands.Count > 0)
            {
                var command = commands.Pop();
                command.Undo();
            }
        }
    }
}
