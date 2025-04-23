class StateMerchant
    : State
{
    public new string Name{get;set;}
    public StateMerchant(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        
    }
    public override void StateGui()
    {
    }
        
     
    public override void Update()
    {
    }
}