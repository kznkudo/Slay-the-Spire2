class StateCharacterSelectionConfirm 
    : State
{
    public StateCharacterSelectionConfirm(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        
    }

    public override void StateGui()
    {
        player!.Describtion();
        global::Gui.MenuOption(1,"Play");
        global::Gui.MenuOption(2,"Back");
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
                    states.Push(new StateStartingRoom(states, player!));
                    break;
                case "2":
                    states.Pop();
                    break;
                default:
                    global::Gui.WrongInput();
                    break;
            }
        } while (states.Peek()==this);
    }
}