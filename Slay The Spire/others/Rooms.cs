// class NextRoom
//     : State
// {
//     public string Name {get;set;}="not defined";
//     public State? State {get;set;}

//     public NextRoom(string roomType, Stack<State> states, Charakter player) 
//         : base(states, player)
//     {
//         switch(roomType.ToLower())
//         {
//             case "enemy": 
//                 Name = "Enemy";
//                 State = new StateCombatRoom(states, player);
//                 break;
//             case "rest": 
//                 Name = "Rest";
//                 State = new StateCombatRoom(states, player);
//                 break;
//             case "???": 
//                 Name = "???";
//                 State = new StateCombatRoom(states, player);
//                 break;

//         }
//     }
// }