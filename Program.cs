class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
   
   //constructor adicional
   public Human(string name, int strength, int intelligence, int dexterity, int health){
    Name = name;
    Strength = strength;
    Intelligence = intelligence;
    Dexterity = dexterity;
    Health = health;
   }

   public Human(string name){
    Name = name;
    Strength = 22;
    Intelligence = 22;
    Dexterity = 22;
    Health = 100;
   }
    
    public int Attack(Human target){
        int damage = Strength * 3;

        target.Health -= damage;

        return target.Health;
    }
}

class Program
{
    static void Main()
    {
        Human jugador1 = new Human("Jacobo", 11, 22, 33, 111);
        Human jugador2 = new Human("Carlos", 9, 12, 5, 85);

        Console.WriteLine(jugador1.Attack(jugador2));

        int remainingHealth = jugador1.Attack(jugador2);
        Console.WriteLine($"{jugador1.Name} realizó un ataque a {jugador2.Name} y quitó {remainingHealth} puntos de salud a {jugador2.Name}.");
    }
}
