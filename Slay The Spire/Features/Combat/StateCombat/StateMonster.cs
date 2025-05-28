class StateMonster
    : State
{
    private int _turn = 0;
    protected Enemy? _enemy = new Thief();
    public StateMonster(Stack<State> _states, Charakter _player)
        : base(_states, _player)
    {
        Name = "Monster";
        _player.Deck.ShuffleDeck();
    }
    public void LoadEnemy() //hab ich geschrieben, bevor ich auf die idee kam, ihn direkt im konstruktor anzulegen
    {
        new EnemyService(_enemy!);
    }
    public override void StateGui()
    {
        global::Gui.Header("Room 1", ConsoleColor.White);
        System.Console.WriteLine("Turn " + _turn);
        _enemy!.Display();
        _player!.Deck.ShowHand();
        global::Gui.MenuOption(_player.Handsize + 1, "End Turn");
        _player.Display();
    }
    public override void Update()
    {
        LoadEnemy();
        while (true)
        {
            StartRound();
            PlayRound();
            EndRound();
        }
    }
    public void StartRound()
    {
        _player!.Init();
        _player.Deck.DrawHand(_player.Handsize);
        _turn++;
        StateGui();
    }
    public void PlayRound()
    {
        //Die Auswahlmöglichkeit um den Turn zu beenden ist immer die letzte nummer, also immer eins nach der letzten handkarte
        int _iEndround = _player!.Deck.Hand.Count + 1;
        int _input;
        do
        {
            _input = Gui.GetInt();
            System.Console.WriteLine(_input);
            if (_input == _iEndround) //die nummer End Turn wurde gedrückt
                return;
            else if (_input > _player.Deck.Hand.Count)
                Gui.WrongInput();
            else
            {
                _player.Deck.Hand[_input - 1].Play();
                _player.Deck.Hand.Remove(_player.Deck.Hand[_input - 1]);
                StateGui();
            }
        } while (CharacterService.HasHp() && EnemyService.HasHp());
        End();
    }
    public void EndRound()
    {
        _enemy!.Block = 0;
        _enemy.Turn();
        _player!.Deck.RemoveHand();
        End();
    }
    public void End()
    {
        if (_player!.CurrentHp == 0)
            _states.Push(new StateGameover(_states, _player));
        else if (_enemy!.CurrentHp == 0)
            _states.Push(new StateReward(_states, _player));
    }
}