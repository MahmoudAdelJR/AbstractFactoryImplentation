using UIColors_AbstractFactoryImplentation.Constants;
using UIColors_AbstractFactoryImplentation.Implementation.UserInterfaceFactories;
using UIColors_AbstractFactoryImplentation.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        UserInterfaceFactory factory ;
        Button button;
        TextBox textBox;
        Console.ForegroundColor = LinuxConstants.BUTTON_COLOR;
        Console.WriteLine("Linux Interface");
        Console.WriteLine("***************************************");
        Console.WriteLine();
        factory = new LinuxUserInterfaceFactory();
        button = factory.GetButton();
        textBox = factory.GetTextBox();
        Console.WriteLine(button);
        Console.WriteLine();
        Console.WriteLine(textBox);
        Console.WriteLine("---------------------------------------------");
        //*****************************************************************
        Console.ForegroundColor = WiindowsConstants.BUTTON_COLOR;
        Console.WriteLine("Windows Interface");
        Console.WriteLine("***************************************");
        Console.WriteLine();
        factory = new Windows_UserInterfaceFactory();
        button = factory.GetButton();
        textBox = factory.GetTextBox();
        Console.WriteLine(button);
        Console.WriteLine();
        Console.WriteLine(textBox);
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine();
        //*********************************************************************
        Console.ForegroundColor = MacConstants.BUTTON_COLOR;
        Console.WriteLine("Mac Interface");
        Console.WriteLine("***************************************");
        Console.WriteLine();
        factory = new MacUserInterfaceFactory();
        button = factory.GetButton();
        textBox = factory.GetTextBox();
        Console.WriteLine(button);
        Console.WriteLine();
        Console.WriteLine(textBox);
        Console.WriteLine("----------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
    }
}