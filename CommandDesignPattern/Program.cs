using CommandDesignPattern;

class Program
{
    public static void Main(string[] args)
    {
        Client client = new Client();
        TextEditor editor = new TextEditor();

        client.ExecuteCommand(new AddTextCommand(editor, "Hello, "));
        Console.WriteLine(editor.GetText()); // Output: Hello,

        client.ExecuteCommand(new AddTextCommand(editor, "world! "));
        Console.WriteLine(editor.GetText()); // Output: Hello, world!

        client.ExecuteCommand(new DeleteTextCommand(editor, "world! "));
        Console.WriteLine(editor.GetText()); // Output: Hello,

        client.UndoLastCommand();
        Console.WriteLine(editor.GetText()); // Output: Hello, world!

        client.UndoLastCommand();
        Console.WriteLine(editor.GetText()); // Output: Hello,

        // Burada metnin son hali: "Hello,"
    }
}



