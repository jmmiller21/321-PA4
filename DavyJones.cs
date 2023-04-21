namespace PA4
{
    public class DavyJones : Character
    {
    public DavyJones(){
        RandomDoubleGenerator randd = new RandomDoubleGenerator();
     
          name = "Davy Jones";
        Random rand = new Random();
         id = rand.Next(0,1000);
           maxPower = randd.GetRandomDoubleRange(0.0, 100);
        attackStrength = randd.GetRandomDoubleRange(0,maxPower);
        health = 100;
        defensivePower = randd.GetRandomDoubleRange(0,maxPower);
        maxPower = Math.Round(maxPower,2);
       attackStrength = Math.Round(attackStrength,2); 
       defensivePower = Math.Round(defensivePower,2);
       PrimaryAbility = new Sword();
    PrimaryAbility = new CannonFire();
    DefendAbility = new Block();
   
    }
    }
}