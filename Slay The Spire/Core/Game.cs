using System.Runtime.InteropServices;

class Game
{
    bool _devMode = true;
    private Stack<State> _states = new Stack<State>();
    private Charakter? _player = new IceMan();
    private void InitVariables()
    {
        new CharacterService(_player!);
        //if data ist nicht vorhanden
        //player=null;
        //oder vielleicht player=data, wenn player null, dann kein spielstand vorrhanden(keine option load game, etc)
    }
    private void InitStates()
    {
        _states = new Stack<State>();
        if (_devMode)
        {
            _states.Push(new StateMap(_states, _player!));
        }
        else
        {
            _states.Push(new StateMenu(_states, _player));
        }
    }
    public void Run()
    {
        InitVariables();
        InitStates();

        while (_states.Count > 0)
            _states.Peek().Update();

        System.Console.WriteLine("Game closed");
    }
}