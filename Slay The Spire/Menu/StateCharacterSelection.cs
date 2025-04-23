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
        global::Gui.MenuOption(1,"Iceman");
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
                    states.Push(new StateCharacterSelectionConfirm(states, player!));
                    break;
                case "2":
                    this.isEnd = true;
                    break;
                default:
                    global::Gui.WrongInput();
                    break;
            }
        } while (states.Peek()==this);
    }
}