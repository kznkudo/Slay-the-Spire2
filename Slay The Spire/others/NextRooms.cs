using System.Security.Cryptography.X509Certificates;

class NextRooms
{
    protected Stack<State> _states;
    protected Charakter? _player;
    int _roomsCleared;
    int _propMonster;
    int _propEvent;
    int _propMerchant;
    int _propRoom2;

     public NextRooms(Stack<State> states, Charakter player, int roomsCleared)
    {
        _roomsCleared=roomsCleared;
        _states = states;
        _player = player;
    }

    public void InitVariables()
    {
        _propMonster=45;//61
        _propEvent=_propMonster+22;//83
        _propMerchant=_propEvent+5;//88
        // rest site is everything else till 100, so 22%.
    }
    public State DecideRoom()
    {
        switch(_roomsCleared)
        {
            case 1:
                return new StateCombatRoom(_states, _player!);
            case 2:
            case 3:
            case 4:
                InitVariables();
                return DecideRandomly();
            case 5:
                return new StateTreasure(_states, _player!);
            case 6:
            case 7:
            case 8:
                InitVariables();
                return DecideRandomly();
            case 9:
                return new StateRest(_states, _player!);
            default:
                return new StateBoss(_states, _player!);
        }
    }
    public State DecideRandomly()
    {
        Random rand = new Random();
        int iRand = rand.Next(1,101);

        if(iRand<=_propMonster)
            return new StateCombatRoom(_states, _player!);
        else if(iRand<=_propEvent)
            return new StateEvent(_states, _player!);
        else if(iRand<=_propMerchant)
            return new StateMerchant(_states, _player!);
        else
            return new StateRest(_states, _player!);
    }
    public void DecideRoom2()
    {
        Random rand = new Random();
        int propRoom2 = rand.Next(0,34);

        if(propRoom2<= _propRoom2)
            DecideRandomly();
    }

}