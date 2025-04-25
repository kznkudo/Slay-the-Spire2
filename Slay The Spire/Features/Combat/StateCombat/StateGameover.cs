class StateGameover
    : State
{
    public StateGameover(Stack<State> states, Charakter player) 
        : base(states, player)
    {

    }
    public override void StateGui()
    {
        Gui.TextColor("Game over.", ConsoleColor.Red);
        System.Console.WriteLine("Back to Menu");
    }
        
     
    public override void Update()
    {
        StateGui();
        states = new Stack<State>();
        states.Push(new StateMenu(states, player));
        Console.ReadKey();
    }
}