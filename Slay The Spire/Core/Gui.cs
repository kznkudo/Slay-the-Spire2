using System.Drawing;
using System.Security.Authentication.ExtendedProtection;

class Gui
{
    public static void MenuTitle(string text)
    {
        Console.Write("\n============");
        TextColor(text, ConsoleColor.Yellow);
        Console.WriteLine("=============");
    }
    public static void Header(string text, ConsoleColor color)
    {
        Console.Write("\n==================");
        TextColor(text, color);            
        Console.WriteLine("==================");
    }
    public static void EntityHeader(string text, ConsoleColor color)
    {
        System.Console.Write($"\t----------");
        TextColor(text, color);
        System.Console.WriteLine("-----------");
    }
    public static void MenuOption(int index, string text)
    {
        TextColor(index+". ", ConsoleColor.Red);
        System.Console.WriteLine(text);
    }
    public static void CombatOption(int index, string name, string descr)
    {
        TextColor(index+". ", ConsoleColor.Red);
        TextColor(name, ConsoleColor.Blue);
        System.Console.WriteLine(descr);
    }
    public static void WrongInput()
    {
        System.Console.WriteLine("invalid input, try again");
    }
    public static void TextColor(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        System.Console.Write(text);
        Console.ResetColor();
    }
    public static int GetInt()
    {
        int input=187;

        while (input==187)
        {
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("invalid input, try again");
            }
        }
        return input;
    }
    public static void Hp(int CurrentHp, int Block, int MaxHp)
    {
        System.Console.Write("\tHp: ");
        Gui.TextColor(CurrentHp.ToString(), ConsoleColor.Green);
        if(Block>0)
        {
            System.Console.Write("(");
            Gui.TextColor(Block.ToString(), ConsoleColor.DarkCyan);
            System.Console.Write(")");
        }
        Gui.TextColor("/"+MaxHp, ConsoleColor.Green);
    }
    public static void EnemyIntend(Action<string> TextColor, string intent, string value, string intent2="")
    {
        System.Console.WriteLine("wants to ");
        TextColor(intent);
        System.Console.WriteLine(" you for ");
        TextColor(value);
    }
}