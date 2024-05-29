namespace DesignPatterns.Structural.Facade
{
    public class Player(string name, int number)
    {
        public string Name { get; set; } = name;

        public int Number { get; set; } = number;

        public void Play()
        {
            Console.WriteLine($"Player number {this.Number} is playing");
        }
    }
}