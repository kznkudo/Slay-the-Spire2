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
        _states = new Stack<State>();
        _states.Push(new StateMenu(_states, _player));
        Console.ReadKey();
    }
}