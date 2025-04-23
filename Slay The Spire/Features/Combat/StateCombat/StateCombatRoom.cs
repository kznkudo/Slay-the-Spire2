class StateCombatRoom
    : State
{
    private int turn = 0;
    protected Enemy? enemy;
    public StateCombatRoom(Stack<State> states, Charakter player) 
        : base(states, player)
    {
        enemy = new Thief();
        new EnemyService(enemy!);
        player.Deck.ShuffleDeck();  
    }
    public void LoadEnemy() //hab ich geschrieben, bevor ich auf die idee kam, ihn direkt im konstruktor anzulegen
    {
        
    }
    public override void StateGui()
    {
        global::Gui.Header("Room 1", ConsoleColor.White);
        System.Console.WriteLine("Turn "+turn);
        enemy!.Display();
        player.Deck.ShowHand();
        global::Gui.MenuOption(player.Handsize+1, "End Turn");
        player.Display();
    }
    public override void Update()
    {
        StartRound();
        PlayRound();    
        EndRound();
    }
    public void StartRound()
    {
        player.Init();
        player.Deck.DrawHand(player.Handsize);
        turn++;
        StateGui();
    }
    public void PlayRound()
    {
        int input;
        do
        {
            input = Gui.GetInt();
            System.Console.WriteLine(input);
            if(input == player.Deck.Hand.Count+1) //die nummer End Turn wurde gedrückt
                return;
            else if(input>player.Deck.Hand.Count)
                Gui.WrongInput();
            else 
            {
                player.Deck.Hand[input-1].Play();
                player.Deck.Hand.Remove(player.Deck.Hand[input-1]);
                StateGui();
            }
        } while (CharacterService.HasHp()&&EnemyService.HasHp());
    }
    public void EndRound()
    {
        enemy.Block=0;
        enemy.Turn();
        player.Deck.RemoveHand();
        
    }
}