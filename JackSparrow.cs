namespace PA4
{
    public class JackSparrow : Character
    {
        public JackSparrow(){
         RandomDoubleGenerator randd = new RandomDoubleGenerator();
            Random rand = new Random();
            id = rand.Next(0,1000);
          name = "Jack Sparrow";
          maxPower = randd.GetRandomDoubleRange(1, 100);
        attackStrength = randd.GetRandomDoubleRange(1,maxPower);
      
        health = 100;
        defensivePower = randd.GetRandomDoubleRange(1,maxPower);
        maxPower = Math.Round(maxPower,2);
         attackStrength = Math.Round(attackStrength,2); 
         defensivePower = Math.Round(defensivePower,2);
          PrimaryAbility = new Distraction();
           } 
        }
    }
