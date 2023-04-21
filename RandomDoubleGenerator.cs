namespace PA4
{
    public class RandomDoubleGenerator
    {
       public double Lower{get;set;}
       public double Upper{get; set;}

    
       public double GetRandomDoubleRange(double Lower,double Upper){
        Random rand = new Random();
      var rDouble = rand.NextDouble();
     var rangeDouble =  rDouble*(Upper - Lower) + Lower;
        return rangeDouble;
       }
    }
}