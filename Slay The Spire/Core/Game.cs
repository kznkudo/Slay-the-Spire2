using System.Runtime.InteropServices;

class Game
{
    bool devMode=false;
    private Stack<State> states=new Stack<State>();
    public Charakter? player= new IceMan();
    private void InitVariables()
    {
        new CharacterService(player!);
        //if data ist nicht vorhanden
            //player=null;
            //oder vielleicht player=data, wenn player null, dann kein spielstand vorrhanden(keine option load game, etc)
    }
    private void InitStates()
    {
        states=new Stack<State>();
        if (devMode)
        {
            states.Push(new StateCombatRoom(states, player!));
        }
        else
        {        
            states.Push(new StateMenu(states, player));
        }
    }
    public void Run()
    {
        InitVariables();
        InitStates();
        
        while(states.Count>0)
        {
            states.Peek().Update();

            CheckFor.StateEnd(states);
        }
        System.Console.WriteLine("Game closed");
    }
}