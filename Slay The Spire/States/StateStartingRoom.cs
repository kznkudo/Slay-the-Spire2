class StateStartingRoom
    : State
{
    public StateStartingRoom(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        
    }
    public override void StateGui()
    {
        global::Gui.TextColor("Under construction.", ConsoleColor.Red);
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
                    states.Push(new StateCombatRoom(states, player!));
                    break;
                case "2":
                    this.isEnd=true;
                    break;
                default:
                    System.Console.WriteLine("invalid input, try again");
                    break;
            }
        } while (states.Peek()==this);
    }
}