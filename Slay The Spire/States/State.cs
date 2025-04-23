abstract class State
{
    protected bool isEnd=false;
    protected Stack<State> states;
    protected Charakter? player;
    public State(Stack<State> states, Charakter? player)
    {
        this.states=states;
        this.player=player;
    }
    public bool IsEnd()
    {
        return isEnd;
    }
    public abstract void StateGui();
    public abstract void Update();
} 