using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class AddTextCommand : ICommand
    {
        private TextEditor _editor;
        private string _addedText;

        public AddTextCommand(TextEditor editor, string addedText)
        {
            _editor = editor;
            _addedText = addedText;
        }

        public void Execute()
        {
            _editor.SetText(_editor.GetText() + _addedText);
        }

        public void Undo()
        {
            string currentText = _editor.GetText();
            if (currentText.EndsWith(_addedText))
            {
                _editor.SetText(currentText.Substring(0, currentText.Length - _addedText.Length));
            }
        }
    }
}
