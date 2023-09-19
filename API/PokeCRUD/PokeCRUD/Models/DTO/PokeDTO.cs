namespace PokeCRUD.Models.DTO
{
    public class PokeDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Move { get; set; }
        public string Weakness { get; set; }
        public int Level { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
