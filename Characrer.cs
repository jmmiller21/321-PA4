namespace PA4
{
    public abstract class Character
    {
        public int id {get; set;}
    public string name {get; set;}
    public double maxPower{get; set;}
    public double health{get; set;}
    public double attackStrength{get; set;}
    public double defensivePower{get; set;}
    public IAttackBehavior PrimaryAbility{get; set;}
    public IDefendBehavior DefendAbility {get; set;}
    
    public override string ToString(){
        return  " Character Name " + name + " "   +  "Max Power " + maxPower + "  Health " + health + " Attack Strength "+ attackStrength +"  Defensive Power "+ defensivePower;
    }
    public void RandomizeScaling(){
        RandomDoubleGenerator randd = new RandomDoubleGenerator();
        maxPower= randd.GetRandomDoubleRange(1,100);
        attackStrength = randd.GetRandomDoubleRange(1,maxPower);
        defensivePower = randd.GetRandomDoubleRange(1,maxPower);
            maxPower = Math.Round(maxPower,2);
       attackStrength = Math.Round(attackStrength,2); 
       defensivePower = Math.Round(defensivePower,2);
    }
    public Character() {
    PrimaryAbility = null;
    DefendAbility = new Block();
    }
   
    }
}