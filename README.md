# Zoo-LAB06

Definition of an Interface:
An interface in C# is a contract or a set of specifications that define a group of related methods or properties that classes can implement. It defines the structure and behavior that a class should provide without specifying how the class should achieve it. In other words, an interface acts as a blueprint for a class and ensures that all implementing classes adhere to the same set of rules, ensuring consistency and providing a way to achieve polymorphism.

Interfaces in the Provided Code:

IFlyable: This interface is used to define the behavior of animals that can fly. It has a single method Fly() that needs to be implemented by classes that want to be considered as flyable animals.

Example: The class Eagle implements the IFlyable interface because eagles are birds that can fly. The Eagle class provides its implementation of the Fly() method, specifying how eagles fly.

IClimbable: This interface is used to define the behavior of animals that can climb. It has a single method Climb() that needs to be implemented by classes that want to be considered as animals capable of climbing.

Example: The class Monkey implements the IClimbable interface because monkeys are known for their ability to climb trees. The Monkey class provides its implementation of the Climb() method, defining how monkeys climb trees.
