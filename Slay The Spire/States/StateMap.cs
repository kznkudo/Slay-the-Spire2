using System;

class StateMap 
    : State
{
    private State? _nextState1;
    private State? _nextState2;
    public int RoomsCleared{get;set;}
    private NextRooms? _nextRoom;
    public StateMap(Stack<State> states, Charakter? player) 
        : base(states, player)
    {
        RoomsCleared=0;
    }
    public override void StateGui()
    {
        Gui.Header("MAP", ConsoleColor.Green);
        Gui.MenuOption(1, _nextState1.Name);
        if(_nextState2!=null)
            Gui.MenuOption(2, _nextState2.Name);
    }

    public override void Update()
    {
        RoomsCleared++;

        _nextRoom = new NextRooms(states, player!, RoomsCleared);

        _nextState1 = _nextRoom.DecideRoom();
        _nextState2 = _nextRoom.DecideRoom();

        StateGui();
        
        switch(Console.ReadLine())
        {
            case "1":
                states.Push(_nextState1);
                break;
            case "2":
                if(_nextState2!=null)
                    states.Push(_nextState2);
                else goto default;
                break;
            default:
                Gui.WrongInput();
                break;
            
        }
    }       
}