namespace PA4
{
    public class WillTurner : Character
    {
       public WillTurner(){
        RandomDoubleGenerator randd = new RandomDoubleGenerator();
        name = "Will Turner";
        Random rand = new Random();
         id = rand.Next(0,1000);
        health = 100;
        maxPower = randd.GetRandomDoubleRange(1, 100);
        attackStrength = randd.GetRandomDoubleRange(1,maxPower);
        health = 100;
        defensivePower = randd.GetRandomDoubleRange(1,maxPower);
         maxPower = Math.Round(maxPower,2);
         attackStrength = Math.Round(attackStrength,2); 
         defensivePower = Math.Round(defensivePower,2);
       PrimaryAbility = new Sword();
       } 
    }
}