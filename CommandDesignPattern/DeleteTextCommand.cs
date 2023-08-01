using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class DeleteTextCommand : ICommand
    {
        private TextEditor _editor;
        private string _deletedText;

        public DeleteTextCommand(TextEditor editor, string deletedText)
        {
            _editor = editor;
            _deletedText = deletedText;
        }

        public void Execute()
        {
            string currentText = _editor.GetText();
            if (currentText.EndsWith(_deletedText))
            {
                _editor.SetText(currentText.Substring(0, currentText.Length - _deletedText.Length));
            }
        }

        public void Undo()
        {
            _editor.SetText(_editor.GetText() + _deletedText);
        }
    }
}
