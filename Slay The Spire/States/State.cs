abstract class State
{
    public string Name{get;set;}="default";
    protected Stack<State> states;
    protected Charakter? player;
    public State(Stack<State> states, Charakter? player)
    {
        this.states=states;
        this.player=player;
    }
    public abstract void StateGui();
    public abstract void Update();
} 