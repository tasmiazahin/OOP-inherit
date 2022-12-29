using System.Drawing;
using System.Xml.Linq;

namespace InheritWork;
class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Margain" , 3,4,"brown",15, "green", "Domestic", true);
        cat.FullCat();
        Console.WriteLine(cat.FullCat());
        cat.makeSound();
        Console.WriteLine("Cat type : " + cat.type);
        Console.WriteLine(cat.isDomestic?"Cat is domestic animal" : "Cat is wild animal");

        Dog dog = new Dog("Bunty",6,2,"white",10,"wild",true);
        dog.Full();
        Console.WriteLine(dog.Full());
        dog.makeSound();
        Console.WriteLine("Dog type: " + dog.type);
        Console.WriteLine(dog.isDomestic ? "Dog is domestic animal" : "Dog is wild animal");


         Bulldog bulldog = new Bulldog("Bruno",5,3,"Brown",20, "Domestic", true, "Big","Soft","Thick");
         Console.WriteLine(bulldog.FullBullDog());
         bulldog.makeSound();
         Console.WriteLine("Bulldog type: " + bulldog.type);
         Console.WriteLine(bulldog.isDomestic ? "Bulldog is domestic animal" : "Bulldog is wild animal");


        Chihuahua chihuahua = new Chihuahua("Tommy",5,6,"Black",40,"Domestic", true,"Sharp","Long","Big");
        Console.WriteLine(chihuahua.FullChihuahua());
        chihuahua.makeSound();
        Console.WriteLine("Chihuahua type: " + chihuahua.type);
        Console.WriteLine(chihuahua.isDomestic ? "Chihuahua is domestic animal" : "Chihuahua is wild animal");


        Tiger tiger = new Tiger("Halum",6,20,"Brown",140,"Bangladeshi", "Reptiles", false);
        Console.WriteLine(tiger.FullTiger());
        tiger.makeSound();
        Console.WriteLine(tiger.isDomestic ? "Tiger is a domestic animal" : "Tiger is an wild animal");

        Human human = new Human("Sonia",5,25,"Light brown",60);
        Console.WriteLine(human.FullHuman());
        human.makeSound();
        Console.WriteLine(human.isDomestic ? "Human is a domestic animal" : "Human is an wild animal");


        Console.ReadLine();
    }
}

class Djur
{
    public string Name;
    public int Height;
    public int Age;
    public string Color;
    public int Weight;


    public Djur(string name, int height, int age, string color, int weight)
    {
        Name = name;
        Height = height;
        Age = age;
        Color = color;
        Weight = weight;
    }

    public virtual void makeSound()
    {
        Console.WriteLine("Animal make sound");
    }

    public void eat()
    {

    }

    public void sleep()
    {
    }
}
    class Cat:Djur
{
    public string eyeColor;

    public string type = "Mammals";

    public bool isDomestic = true;

    
    public Cat(string name, int height, int age, string color, int weight, string eyeColor, string type, bool isDomestic) : base(name, height, age, color, weight)
    {
      
    }

    public string FullCat()
    {
        return ("Cats name  is : " + Name + " , Age is : " + Age + " , Color is : " + Color + " , weight is : " + Weight + "  , Type is : " + type + " , is domestic  is : " + isDomestic);
    }

    public void play()
    {

    }

    public override void makeSound()
    {
        Console.WriteLine("Cat sound : Meow");
    }
}

class Dog:Djur
{
    public string type ="Mammals";
    public bool isDomestic = true;

    public Dog(string name, int height, int age, string color, int weight,string type,bool isDomestic):base(name, height, age, color, weight)
    {
      
    }
    public string Full()
    {
        return ("Dogs name  is : " +   Name   +  " , Age is : " + Age + " , Color is : " +  Color  + " , weight is : " +  Weight + "  , Type is : " +  type  + " , is domestic  is : " + isDomestic);
    }


    public void walk()
    {

    }

    public override void makeSound()
    {
        Console.WriteLine("Dog sound : Bark");
    }
}

class Bulldog : Dog 
{
    public string Shape;
    public string Skin;
    public string Hair;

    public Bulldog(string name, int height, int age, string color, int weight, string type, bool isDomestic, string shape,string skin,string hair ) : base( name,  height,  age,  color,  weight,  type,  isDomestic) 
    {
        Shape = shape;
        Skin = skin;
        Hair = hair;
    }

    public string FullBullDog()
    {
        return ("BullDogs name  is : " + Name + " , Age is : " + Age + " , Color is : " + Color + " , weight is : " + Weight + "  , Type is : " + type + " , is domestic  is : " + isDomestic + " , Shape is : " + Shape + "Skin is : " + Skin + " ,Hair is :" + Hair);
    }

    public void nature()
    {  

        
    }

    public override void makeSound()
    {
        Console.WriteLine("Bulldog is barking");
    }
}

    class Chihuahua:Dog
  {
    public string Teeth;
    public string Tail;
    public string Size;

    public Chihuahua(string name, int height, int age, string color, int weight, string type, bool isDomestic, string teeth, string tail, string size) : base(name, height, age, color, weight, type, isDomestic)
    {
        Teeth = teeth;
        Tail = tail;
        Size = size;
    }

    public string FullChihuahua()
    {
        return ("Chihuahua dog name  is : " + Name + " , Age is : " + Age + " , Color is : " + Color + " , weight is : " + Weight + "  , Type is : " + type + " , is domestic  is : " + isDomestic + " , Teeth is : " + Teeth + ", Tail is : " + Tail + " , Size is :" + Size);
    }

    public void Senses()
    {

    }

    public override void makeSound()
    {
        Console.WriteLine("Chihuahua is barking");
    }
}

class Tiger : Djur
{
    public string Origin;
    public string Type;
    public bool isDomestic = false;

    public Tiger(string name, int height, int age, string color, int weight, string origin, string type, bool isDomestic) : base(name, height, age, color, weight)
    {

        Origin = origin;
        Type = type;
    }

    public string FullTiger()
    {
        return ("tigers name  is : " + Name + " , Age is : " + Age + " , Color is : " + Color + " , weight is : " + Weight + "  , Origin is : " + Origin + " , Type  is : " + Type  + ", is domestic is " +  isDomestic);
    }


    public void speed()
    {

    }
    public override void makeSound()
    {
        Console.WriteLine("Tiger sound : Roar");
    }
}

class Human : Djur
{
    public string type = "Mammals";
    public bool isDomestic = true;


    public Human(string name, int height, int age, string color, int weight ) : base(name, height, age, color, weight)
    {

    }

    public string FullHuman()
    {
        return ("Humans name  is : " + Name + " , Age is : " + Age + " , Color is : " + Color + " , weight is : " + Weight);
    }

    public override void makeSound()
    {
        Console.WriteLine("Human speaks natural");
    }
}



