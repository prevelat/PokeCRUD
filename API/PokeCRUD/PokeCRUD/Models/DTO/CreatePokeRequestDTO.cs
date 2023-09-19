namespace PokeCRUD.Models.DTO
{
    public class CreatePokeRequestDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Move { get; set; }
        public string Weakness { get; set; }
        public int Level { get; set; }
    }
}
