namespace PP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var character = new Character("Frank", "Peter's house", "Magic Wand");
            var shop = new ShopMenu("Animals", "Wands");
            var animalMenu1 = new Animal("150", "Owl");
            var animalMenu2 = new Animal("200", "Rat");
            var animalMenu3 = new Animal("250", "Cat");
            var wand1 = new Wands(300, "Phoenix Wand");
            var wand2 = new Wands(350, "Unicorn Wand");
            var wand3 = new Wands(400, "Magic Wand");
            shop.MenuAnimal.Add(animalMenu1);
            shop.MenuAnimal.Add(animalMenu2);
            shop.MenuAnimal.Add(animalMenu3);
            shop.MenuWands.Add(wand1);
            Console.WriteLine($"Your character's name is {character.Name}, you live in {character.House} and in your inventory, there is a {character.Inventory}");
            Console.WriteLine("Press 1 to enter the shop");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Welcome to the shop, here you can choose in 2 categories");
                Console.WriteLine($"{shop.MenuAnimal}   |   {shop.MenuWands}");
            }
            Console.ReadLine();

        }
    }
}
