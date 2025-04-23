using System.Data.SqlTypes;
using System.Net;

public abstract class Card
{
    public abstract Type Name{get;set;}
    //public abstract int ManaCost{get;set;}
    
     public abstract void Play();
    public abstract string Description();
    public abstract void Effect();
   
}