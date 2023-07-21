namespace Zoo_LAB06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>(); 

            Lion lion = new Lion("Simba", 5, true);
            Elephant elephant = new Elephant("Dumbo", 10, true);
            Snake snake = new Snake("Kaa", 3);
            Eagle eagle = new Eagle("Majestic", 7);
            Giraffe giraffe = new Giraffe("Melman", 8, true);
            Monkey monkey = new Monkey("George", 6);

            animals.Add(lion);
            animals.Add(elephant);
            animals.Add(snake);
            animals.Add(eagle);
            animals.Add(giraffe);
            animals.Add(monkey);

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.Name}:");
                animal.Eat();
                animal.Sleep();

                if (animal is IFlyable flyableAnimal)
                {
                    flyableAnimal.Fly();
                }

                if (animal is IClimbable climbableAnimal)
                {
                    climbableAnimal.Climb();
                }

                if (animal is Reptile reptileAnimal)
                {
                    reptileAnimal.Slither();
                    reptileAnimal.ShedSkin();
                }

                Console.WriteLine();
            } 

            Console.ReadLine();
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Eat();
        public abstract void Sleep();
    }

    public abstract class Mammal : Animal
    {
        public bool HasFur { get; set; }

        public Mammal(string name, int age, bool hasFur)
            : base(name, age)
        {
            HasFur = hasFur;
        }

        public override void Sleep()
        {
            Console.WriteLine("The mammal is sleeping.");
        }
    }

    public class Lion : Mammal
    {
        public Lion(string name, int age, bool hasFur)
            : base(name, age, hasFur)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The lion is eating.");
        }
    }

    public class Elephant : Mammal
    {
        public Elephant(string name, int age, bool hasFur)
            : base(name, age, hasFur)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The elephant is eating.");
        }
    }

    public abstract class Reptile : Animal
    {
        public Reptile(string name, int age)
            : base(name, age)
        {
        }

        public abstract void Slither();
        public abstract void ShedSkin();
    }

    public class Snake : Reptile
    {
        public Snake(string name, int age)
            : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The snake is eating.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The snake is sleeping.");
        }

        public override void Slither()
        {
            Console.WriteLine("The snake is slithering.");
        }

        public override void ShedSkin()
        {
            Console.WriteLine("The snake is shedding its skin.");
        }
    }

    public abstract class Bird : Animal
    {
        public Bird(string name, int age)
            : base(name, age)
        {
        }

        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }

    public class Eagle : Bird, IFlyable
    {
        public Eagle(string name, int age)
            : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The eagle is eating.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The eagle is sleeping.");
        }

        public override void Fly()
        {
            Console.WriteLine("The eagle is flying high in the sky.");
        }
    }

    public class Giraffe : Mammal
    {
        public Giraffe(string name, int age, bool hasFur)
            : base(name, age, hasFur)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The giraffe is eating.");
        }
    }

    public class Monkey : Animal, IClimbable
    {
        public Monkey(string name, int age)
            : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The monkey is eating.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The monkey is sleeping.");
        }

        public void Climb()
        {
            Console.WriteLine("The monkey is climbing trees.");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface IClimbable
    {
        void Climb();
    }
}
