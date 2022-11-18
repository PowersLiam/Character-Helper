/*
 * I applied OCP or the Open/Closed Principle to my CharacterViewModel. This model needs to be mostly closed to modification as it is tied to the database.
 * But there are situations where I need this and more, which is how it is open to extension. For creating characters I can only pass one model to the view,
 * I need this CharacterViewModel because that is what is being created but I need a list of all players to choose one from as ther is a one(player) to many(characters) relationship.
 * So, I extended this CharacterViewModel and the PlayerViewModel in a way, I created the CharacterCreationViewModel as a specific tool for this purpose that has no affect on
 * either model it takes from, it has a CharacterViewModel as a property and a list of PlayerViewModels as another. This way I was able to pass everything to the Character Create
 * page without crudely modifying the pre-existing models.
 */

namespace Character_Helper.Models
{
    public class CharacterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerId { get; set; }
        public PlayerViewModel Player { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public int GetMod(int stat)
        {
            if(stat%2 != 0)
            {
                stat = stat - 1;
            }
            return (stat-10)/2;
        }
    }
}
