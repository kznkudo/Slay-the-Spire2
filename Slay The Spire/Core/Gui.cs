using System.Drawing;
using System.Security.Authentication.ExtendedProtection;

class Gui
{
    public static void MenuTitle(string _text)
    {
        Console.Write("\n============");
        TextColor(_text, ConsoleColor.Yellow);
        Console.WriteLine("=============");
    }
    public static void Header(string _text, ConsoleColor _color)
    {
        Console.Write("\n==================");
        TextColor(_text, _color);
        Console.WriteLine("==================");
    }
    public static void EntityHeader(string _text, ConsoleColor _color)
    {
        System.Console.Write($"\t----------");
        TextColor(_text, _color);
        System.Console.WriteLine("-----------");
    }
    public static void MenuOption(int _index, string _text)
    {
        TextColor(_index + ". ", ConsoleColor.Red);
        System.Console.WriteLine(_text);
    }
    public static void CombatOption(int _index, string _name, string _descr)
    {
        TextColor(_index + ". ", ConsoleColor.Red);
        TextColor(_name, ConsoleColor.Blue);
        System.Console.WriteLine(_descr);
    }
    public static void WrongInput()
    {
        System.Console.WriteLine("invalid input, try again");
    }
    public static void TextColor(string _text, ConsoleColor _color)
    {
        Console.ForegroundColor = _color;
        System.Console.Write(_text);
        Console.ResetColor();
    }
    public static int GetInt()
    {
        int _input = 187;

        while (_input == 187)
        {
            try
            {
                _input = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("invalid input, try again");
            }
        }
        return _input;
    }
    public static void Hp(int _CurrentHp, int _Block, int _MaxHp)
    {
        System.Console.Write("\tHp: ");
        Gui.TextColor(_CurrentHp.ToString(), ConsoleColor.Green);
        if (_Block > 0)
        {
            System.Console.Write("(");
            Gui.TextColor(_Block.ToString(), ConsoleColor.DarkCyan);
            System.Console.Write(")");
        }
        Gui.TextColor("/" + _MaxHp, ConsoleColor.Green);
    }
    public static void EnemyIntend(Action<string> _TextColor, string _intent, string _value, string _intent2 = "")
    {
        System.Console.WriteLine("wants to ");
        _TextColor(_intent);
        System.Console.WriteLine(" you for ");
        _TextColor(_value);
    }
}