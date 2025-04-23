class CheckFor
{
    public static void Null(object? value)
    {
        if (value == null)
        {            
            throw new System.Exception($"Wert ist Null");
        }         
    }
    public static void StateEnd(Stack<State> states)
    {
        if(states.Peek().IsEnd())
            states.Pop();
    }
    public static void EnemyDead()
    {
        
    }
}