using System.Net.NetworkInformation;

namespace Character_Helper.Models
{
    public class CharacterCreationViewModel
    {
        public CharacterViewModel Character { get; set; }
        public List<PlayerViewModel> Players { get; set; }
    }
}
