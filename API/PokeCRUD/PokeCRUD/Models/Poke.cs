namespace PokeCRUD.Models
{
    public class Poke
    {
        // Properties
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        private List<string> Moves;
        public string Weakness { get; set; }
        public int Level { get; set; }
        public DateTime BirthDate { get; set; }

        // Constructor
        public Poke(string name, string type, string weakness, int level = 0)
        {
            Name = name;
            Type = type;
            Moves = new List<string>{};
            Weakness = weakness;
            Level = level;
            BirthDate = DateTime.Now;
        }

        // Methods
        /// Method to add a move to the Moves list
        public void AddMove(string move) {
            if (Moves.Count < 4) // Check if there are fewer than 4 moves
            {
                Moves.Add(move);
            }
            else
            {
                Console.WriteLine("A Pokemon can have at most 4 moves. First the Pokemon needs to forget a move:");
                foreach (string m in Moves){
                    Console.WriteLine($"- {m}");
                }
            }
        }

        /// Method to forget a move
        public void ForgetMove(string move)
        {
            Moves.Remove(move);
        }

        /// Method to update the level of the Pokemon
        public void LevelUp()
        {
            if (Level == 100) {
                Console.WriteLine($"{Name} has reached max level");
            }
            else {
                Level++;
                Console.WriteLine($"{Name} is now level {Level}!");
            }
        }

        /// Method to display information about the Pokemon
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Weakness: {Weakness}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine("Moves:");
            foreach (string move in Moves)
            {
                Console.WriteLine($"- {move}");
            }
        }
    }

}
