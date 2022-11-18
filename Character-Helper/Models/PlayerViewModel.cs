using System.ComponentModel.DataAnnotations;
namespace Character_Helper.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [RegularExpression(@"^1?(\s|-)?\(?\d{3}\)?(\s|-|\s-)?\d{3}(\s|-)\d{4}?$")]
        public string PhoneNumber { get; set; }
        public ICollection<CharacterViewModel> Characters { get; set; }
    }
}
