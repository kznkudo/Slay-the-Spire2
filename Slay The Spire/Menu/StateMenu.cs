using System;

class StateMenu 
    : State
{
    bool isActiveRunExisting=false;
    public StateMenu(Stack<State> states, Charakter? player) 
        : base(states, player)
    {
    
    }
    public override void StateGui()
    {
        Gui.MenuTitle("Slay the Spire 2");

        int i=1;
        Gui.MenuOption(i, "Play");
        if(isActiveRunExisting)
            Gui.MenuOption(++i, "Load Game");
        Gui.MenuOption(++i, "Statistics");
        Gui.MenuOption(++i, "Quit");
    }

    public override void Update()
    {
        StateGui();
        do
        {
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    this.states.Push(new StateCharacterSelection(states, player));
                    break;
                case '2':
                    if(isActiveRunExisting)
                        System.Console.WriteLine("loading game...");
                    else goto case '3';
                    break;
                case '3':
                    System.Console.WriteLine("Hello from statistics");
                    break;
                case '4':
                    this.isEnd=true;
                    break;
                default:
                    System.Console.WriteLine("invalid input, try again");
                    break;
            }        
        } while (states.Peek()==this);    
    }       
}