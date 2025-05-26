class StateCharacterSelection
    : State
{
    public StateCharacterSelection(Stack<State> states, Charakter? player)
        : base(states, player)
    {

    }
    public override void StateGui()
    {
        global::Gui.MenuTitle("Character Selection");
        global::Gui.MenuOption(1, "Iceman");
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
                    _states.Push(new StateCharacterSelectionConfirm(_states, _player!));
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