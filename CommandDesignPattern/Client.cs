using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDesignPattern
{
    public class Client
    {
        private TextEditor _editor = new TextEditor();
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();//_commandHistory.Pop(): Eğer yığın boş değilse, yığının en üstündeki (son eklenen) komutu çıkarır ve lastCommand değişkenine atar. Bu komut geri alınacak komutu temsil eder.
                lastCommand.Undo();
            }
        }
    }
}
