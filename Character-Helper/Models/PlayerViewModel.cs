namespace Character_Helper.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<CharacterViewModel> Characters { get; set; }
    }
}
