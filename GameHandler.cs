namespace PA4
{
    public class GameHandler 
    {
    public Character Player1{get; set;}
    public Character Player2{get; set;}

    public List<Character> StatsList{get; set;}

    public Character[] GetPlayers(){
         CharHandler hand = new CharHandler();
   List<Character> CharList = hand.GetAllCharacters();
   List<Character> Statslist = new List<Character>();
        while(Player1 == null){

    Console.WriteLine("Please Select a Character to Fight As: \n 1. Jack Sparrow  \n 2. Will Turner \n 3. Davy Jones ");
    CharList.ForEach(Character=>{
     Console.WriteLine(Character.ToString());
    });
    int userChoice = int.Parse(Console.ReadLine());
    if (userChoice == 1){
     Player1 = CharList[0];
    Console.WriteLine(Player1.ToString());
    }
   else if (userChoice == 2){
        Player1 = CharList[2];
        Console.WriteLine(Player1.ToString());
    }
  else if (userChoice == 3){
        Player1 = CharList[1];
        Console.WriteLine(Player1.ToString());
       
  }
    else {
        Console.WriteLine("invalid input");
        Console.WriteLine(" ");
    }
    }
        
    while (Player2 == null){
        CharHandler Opp = new CharHandler();
   List<Character> OppenentList = Opp.GetAllCharacters();
    Console.WriteLine("Please Select an Oppenent");
    Console.WriteLine("1. Jack Sparrow \n 2. Will Turner \n 3. Davy Jones");
       int userChoice2 = int.Parse(Console.ReadLine());
    if (userChoice2 == 1){
     Player2 = OppenentList[0];
    Console.WriteLine(Player2.ToString());
    }
   else if (userChoice2 == 2){
        Player2 = OppenentList[2];
        Console.WriteLine(Player2.ToString());
    }
  else if (userChoice2 == 3){
        Player2 = OppenentList[1];
        Console.WriteLine(Player2.ToString());
  }
    else {
        Console.WriteLine("invalid input");
        Console.WriteLine(" ");
    }
        //  StatsList[1].ToString();
    }
   Character[] players = {Player1,Player2};
   Console.WriteLine("You have selected" + " " + Player1.name + " to battle "+ Player2.name);
   return players;
    }
    public void StartGame(){
      Random rand = new Random();
      int randomindex = rand.Next(0,2);
    rand.Next();
    int index = -1;
        Character[] Players = GetPlayers();
       Players[0] = Player1;
       Players[1] = Player2;
       Players[0].RandomizeScaling();
       Players[1].RandomizeScaling();
     string SelectedFirst = Players[randomindex].name;
     Console.WriteLine(SelectedFirst + " Will Attack First");
     int SelectedFirstID = Players[randomindex].id;
     for(int i = 0; i<2; i++){
        if(Players[i].id != SelectedFirstID || Players[i].name != SelectedFirst){
            index = i;
        }
    }
    bool GameEnded = false ;
    double damageDone = 0;
 while (Players[randomindex].health > 0 & Players[index].health > 0){
 while  (GameEnded == false){
  GetResult(Players,ref GameEnded);
   for(int i =0; i<2; i++){
         Players[i].RandomizeScaling();
       }
         Console.WriteLine(Players[randomindex].name); 
        Players[randomindex].PrimaryAbility.PrimaryAbility();
        Console.Write(" " + Players[index].name + " with total damage at" +  Players[randomindex].attackStrength);

    Console.WriteLine (Players[index].name +  " has blocked " + Players[index].defensivePower + " damage");
 GetFightDamage(Players, ref damageDone , randomindex , index);
   double HealthLost = Players[index].health - Math.Abs(damageDone);

    Players[index].health -=  Math.Abs(HealthLost);
     Console.WriteLine(Players[index].name + " has lost " + Math.Abs(damageDone));
     Console.WriteLine(Players[index].ToString());
      GetResult(Players,ref GameEnded);
      //  damageDone = 0;
       HealthLost = 0;
        Console.WriteLine(Players[index].name); 
        Players[index].PrimaryAbility.PrimaryAbility();
        Console.Write(" " + Players[randomindex].name + " with total damage at" +  Players[randomindex].attackStrength);
  GetFightDamage(Players, ref damageDone , index, randomindex);
    Console.WriteLine (Players[randomindex].name +  " has blocked " + Players[randomindex].defensivePower + " damage");

      HealthLost = Players[randomindex].health - Math.Abs(damageDone);
      Players[randomindex].health -= HealthLost;
     Console.WriteLine(Players[randomindex].name + " has lost " + (damageDone));
        //  damageDone = 0;
         HealthLost= 0;
      Console.WriteLine(Players[randomindex].ToString());
  
  Console.WriteLine(Players[index].ToString());
         GetResult(Players, ref GameEnded);
       ChangeAttack(Players);
   
 }
 }

     }
    //  GetResult(Players);
    
     public bool GetResult(Character[] Players, ref bool GameEnded){
         for(int i = 0; i<1; i++){
          for (int j = i+1; j<2; j++){
             if (Players[i].health < 0.0 && Players[j].health> 0.0){
          Console.WriteLine(Players[j].name + " Wins");
          return GameEnded = true;
             }
          if (Players[j].health < 0.0 && Players[i].health> 0.0){
          Console.WriteLine(Players[i].name + " Wins");
          return GameEnded = true;
             }
          if (Players[j].health > 0 && Players[i].health>0){
            return GameEnded == false;
          }
                    }
           
         }
          return true;
     }
     
    
    public double GetFightDamage(Character[] Players, ref double damageDone, int i, int j){
        if(Players[0].name == "Jack Sparrow" && Players[1].name == "Will Turner"){
         damageDone = (Players[0].attackStrength - Players[1].defensivePower) * 1.2;
           return damageDone;
        }
        if (Players[0].name == "Will Turner" && Players[1].name == "Davy Jones") {
         damageDone = (Players[0].attackStrength - Players[1].defensivePower)*1.2;
         return damageDone;
        }
        if (Players[0].name == "Davy Jones" && Players[1].name == "Jack Sparrow") {
         damageDone = (Players[0].attackStrength - Players[1].defensivePower)*1.2;
         return damageDone;
        }
            if(Players[1].name == "Jack Sparrow" && Players[0].name == "Will Turner"){
          damageDone =(Players[1].attackStrength - Players[0].defensivePower) * 1.2;
           return damageDone;
        }
        if (Players[1].name == "Will Turner" && Players[0].name == "Davy Jones") {
        damageDone =(Players[1].attackStrength - Players[0].defensivePower) * 1.2;
           return damageDone;
        }
        if (Players[1].name == "Davy Jones" && Players[0].name == "Jack Sparrow") {
       damageDone = (Players[1].attackStrength - Players[0].defensivePower) * 1.2;
           return damageDone;
        }
        else {
      damageDone = (Players[i].attackStrength - Players[j].defensivePower);
   return damageDone;
        }
    }
  public void ChangeAttack(Character[] Players){
    Random rand = new Random();
    // int index = rand.Next(0,2);
    // Players[index].PrimaryAbility = new Pistol();
  }

    }
}

    

    
