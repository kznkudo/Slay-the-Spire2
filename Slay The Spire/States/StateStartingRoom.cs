class StateStartingRoom
    : State
{
    public StateStartingRoom(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        
    }
    public override void StateGui()
    {
        global::Gui.TextColor("Under construction.\n", ConsoleColor.Red);
        global::Gui.MenuOption(1, "Continue");
        global::Gui.MenuOption(2, "Back");
    }
        
     
    public override void Update()
    {
        StateGui();
        do
        {
            switch (Console.ReadLine())
            {
                case "1":
                    states.Pop();
                    states.Push(new StateMap(states, player!));
                    break;
                case "2":
                    states.Pop();
                    break;
                default:
                    System.Console.WriteLine("invalid input, try again");
                    break;
            }
        } while (states.Peek()==this);
    }
}