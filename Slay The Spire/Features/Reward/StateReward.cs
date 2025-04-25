class StateReward
    : State
{
    private int _gold;
    public StateReward(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        
    }
    public override void StateGui()
    {
    }
        
     
    public override void Update()
    {
        Random rand = new Random();

        _gold = rand.Next(20,41);

        
    }
}