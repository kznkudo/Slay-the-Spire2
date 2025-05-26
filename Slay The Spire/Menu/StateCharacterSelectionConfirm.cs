class StateCharacterSelectionConfirm
    : State
{
    public StateCharacterSelectionConfirm(Stack<State> states, Charakter player)
        : base(states, player)
    {

    }

    public override void StateGui()
    {
        _player!.Describtion();
        global::Gui.MenuOption(1, "Play");
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
                    _states.Pop();
                    _states.Push(new StateStartingRoom(_states, _player!));
                    break;
                case "2":
                    _states.Pop();
                    break;
                default:
                    global::Gui.WrongInput();
                    break;
            }
        } while (_states.Peek() == this);
    }
}