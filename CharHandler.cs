namespace PA4
{
    public class CharHandler
    {
      public List <Character>  CharacterList = new List<Character>();
      public List <Character> GetAllCharacters(){
         JackSparrow JackSparrow = new JackSparrow();
      CharacterList.Add(JackSparrow);
      DavyJones DavyJones = new DavyJones();
      CharacterList.Add(DavyJones);
      WillTurner WillTurner = new WillTurner();
       CharacterList.Add(WillTurner);
       return CharacterList;
      }

    }
}