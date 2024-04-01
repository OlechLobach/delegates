using MessageApp;


namespace MainProject

{
    public delegate void DisplayMessageDelegate(string message);

    class Program
    {
        static void Main(string[] args)
        {
            MessageDisplayer messageDisplayer = new MessageDisplayer();

            DisplayMessageDelegate displayMessageDelegate = new DisplayMessageDelegate(messageDisplayer.DisplayMessage);

            displayMessageDelegate("Hello, World!");
            displayMessageDelegate("This is a delegate example.");
            displayMessageDelegate("Goodbye!");

            Console.ReadLine();
        }
    }
}