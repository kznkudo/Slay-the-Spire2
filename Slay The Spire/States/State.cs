abstract class State
{
    public string Name { get; set; } = "default";
    protected Stack<State> _states;
    protected Charakter? _player;
    public State(Stack<State> states, Charakter? player)
    {
        this._states = states;
        this._player = player;
    }
    public abstract void StateGui();
    public abstract void Update();
}