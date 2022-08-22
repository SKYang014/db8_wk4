//DATE TIME

//DateTime time1 = new DateTime(2022, 7, 31);
//Console.WriteLine(time1.ToString("yyyy-MM-dd"));

//DateTime time2 = DateTime.Now;
//Console.WriteLine(time2);

//DateTime time3 = DateTime.Parse("07/09/22 11:30am");
//Console.WriteLine(time3.ToShortDateString());

//DICTIONARY OF OBJECTS

//Dictionary<string, Rectangle> rects = new Dictionary<string, Rectangle>();

//rects["first"] = new Rectangle("Fred", 3.5, 4.6);
//rects["second"] = new Rectangle("Sally", 5.5, 6.6);
//rects["third"] = new Rectangle("Sam", 10.0, 11.5);

//// This gets too messy

//rects["first"].Length = 10;

//foreach (var pair in rects)
//{
//	Console.WriteLine($"Key: {pair.Key}  Value: {pair.Value}");
//}


//class Rectangle
//{
//	public string Name;
//	public double Length;
//	public double Height;

//	public Rectangle(string _Name, double _Length, double _Height)
//	{
//		Name = _Name;
//		Length = _Length;
//		Height = _Height;
//	}

//	public override string ToString()
//	{
//		return $"{Name}:{Length}x{Height}";
//	}
//}

//LISTINITCONSTRUCT


//TestClass inst = new TestClass("abc", "def", "ghi");
//inst.AddTwo("jkl", "mno");

//foreach (string name in inst.names)
//{
//	Console.WriteLine(name);
//}


//class TestClass
//{
//	public List<string> names;

//	public TestClass(string name1, string name2, string name3)
//	{
//		names = new List<string>();
//		names.Add(name1);
//		names.Add(name2);
//		names.Add(name3);
//	}

//	public void AddTwo(string name4, string name5)
//	{
//		names.Add(name4);
//		names.Add(name5);
//	}
//}

//PT2

// Requirements:
//    Can add additional edges
//    Can change the length of an edge. For example change edge "b" from 4 to 5.

//Polygon poly1 = new Polygon("Fred", new Edge("a", 5), new Edge("b", 4), new Edge("c", 3));
//Console.WriteLine(poly1);

//poly1.AddEdge(new Edge("b", 6));
//Console.WriteLine(poly1);

//poly1.ChangeEdge("b", 5);
//Console.WriteLine(poly1);

//Console.WriteLine();
//Console.Write("Which edge would you like to change? ");
//string edge = Console.ReadLine();
//Console.Write("What size do you want to change it to? ");
//string entry = Console.ReadLine();
//double length = double.Parse(entry);

//poly1.ChangeEdge(edge, length);
//Console.WriteLine(poly1);

//class Edge
//{
//	public string Name;
//	public double Length;
//	public Edge(string _Name, double _Length)
//	{
//		Name = _Name;
//		Length = _Length;
//	}
//}

//class Polygon
//{
//	public string Name;
//	public List<Edge> Edges;
//	public Polygon(string _Name, Edge edge1, Edge edge2, Edge edge3)
//	{
//		Name = _Name;
//		Edges = new List<Edge>();
//		Edges.Add(edge1);
//		Edges.Add(edge2);
//		Edges.Add(edge3);
//	}

//	public void AddEdge(Edge another)
//	{
//		Edges.Add(another);
//	}

//	public void ChangeEdge(string which, double newLength)
//	{
//		//foreach (Edge ed in Edges)
//		//{
//		//	if (ed.Name == which)
//		//	{
//		//		ed.Length = newLength;
//		//		return;
//		//	}
//		//}

//		Edge found = null;
//		foreach (Edge ed in Edges)
//		{
//			if (ed.Name == which)
//			{
//				found = ed;
//				break;
//			}
//		}
//		if (found != null)
//		{
//			found.Length = newLength;
//		}
//	}

//	public override string ToString()
//	{
//		string result = "";
//		string comma = "";
//		foreach (Edge ed in Edges)
//		{
//			result = result + $"{comma}{ed.Name}:{ed.Length}";
//			comma = ",";
//		}
//		return $"{Name} = {result}";
//	}
//}


//LISTOFOBJECTS
//List<Rectangle> rects = new List<Rectangle>();

//Rectangle rect1 = new Rectangle("Fred", 3.5, 4.2);
////Console.WriteLine(rect1);
//rects.Add(rect1);

//Rectangle rect2 = new Rectangle("Sally", 4.6, 5.5);
////Console.WriteLine(rect2);
//rects.Add(rect2);

//Console.WriteLine("Which rectangle?");
//string entry = Console.ReadLine();

//Rectangle found = null;
//foreach (Rectangle rect in rects)
//{
//	if (rect.Name == entry)
//	{
//		found = rect;
//		break;
//	}
//}

//if (found != null)
//{
//	Console.WriteLine(found);
//}
//else
//{
//	Console.WriteLine("Sorry, not found.");
//}


//class Rectangle
//{
//	public string Name;
//	public double Length;
//	public double Height;

//	public Rectangle(string _Name, double _Length, double _Height)
//	{
//		Name = _Name;
//		Length = _Length;
//		Height = _Height;
//	}

//	public override string ToString()
//	{
//		return $"{Name}: {Length}x{Height}, Area = {Length * Height}";
//	}
//}

//MAMMALS
//Dog first = new Dog() { Name = "Fido", HairColor = "Black", BarkVolume = 8, LegCount = 4 };
////Console.WriteLine(first);
//Dog second = new Dog() { Name = "Nellie", HairColor = "Yellow", BarkVolume = 5, LegCount = 4 };
//Orangutan third = new Orangutan() { Name = "Fred", HairColor = "Orange", LegCount = 2, ThumbLength = 3 };
////Console.WriteLine(third);

//List<Mammal> pets = new List<Mammal>();
//pets.Add(first);  // Added the dog Fido to the list
//pets.Add(second); // Added the dog Nellie to the list
//pets.Add(third);  // Added the orangutan Fred to the list

//foreach (Mammal pet in pets)
//{
//string info = pet.ToString();  // C# will call the correct ToString for the object
//Console.WriteLine(info);
//}

//Console.WriteLine();
//Console.WriteLine("Test method!");
//Test(third);

//static void Test(Mammal pet)
//{
//	string data = pet.ToString();
//	Console.WriteLine(data);
//}

//class Mammal
//{
//	public string Name;
//	public string HairColor;  // What color its hair is
//	public int LegCount;      // How many legs it walks on

//	public void Walk()
//	{
//		Console.WriteLine("I am walking.");
//	}

//	// We are overriding what's called a "virtual" function.
//	// i.e. A "virtual" function is one that you can override.
//	public override string ToString()
//	{
//		return "This is a mammal";
//	}
//}

//class Dog : Mammal
//{
//	public int BarkVolume;   // How loud the dog's bark is
//	public override string ToString()
//	{
//		return $"Dog named {Name}, hair {HairColor}, {LegCount} legs, barks at volume {BarkVolume}";
//	}
//}

//class Orangutan : Mammal
//{
//	public int ThumbLength;  // How long the thumb is
//	public override string ToString()
//	{
//		return $"Orangutan named {Name}, hair {HairColor}, {LegCount} legs, thumb is {ThumbLength} inches.";
//	}
//}

//Vehicles
Sedan mycar = new Sedan(4, "Blue", true, 4);
mycar.Drive();

RaceCar myracecar = new RaceCar(4, "Red", 400);
myracecar.Drive();

RaceCar secondracer = new RaceCar(3, "Yellow", 1000);

List<Vehicle> cars = new List<Vehicle>();
cars.Add(mycar);
cars.Add(myracecar);
cars.Add(secondracer);

Console.WriteLine();
Console.WriteLine("Everybody drive!");

foreach (Vehicle car in cars)
{
	car.Drive();
}

// This commented code demonstrates polymorphism
//Vehicle something;
//something = mycar;
//something.Drive(); // It will call the correct version

//something = myracecar;
//something.Drive(); // Again, correct version

// Calling the correct version is known as "polymorphism".

class Vehicle
{
	public int WheelCount;
	public string Color;
	public Vehicle(int _WheelCount, string _Color)
	{
		WheelCount = _WheelCount;
		Color = _Color;
	}
	public virtual void Drive()
	{
		Console.WriteLine($"I am driving a {Color} car with {WheelCount} wheels.");
	}
}

class Sedan : Vehicle  // Ignore the error about construtor parameters. We'll get there!
{
	public bool HasHatchBack;
	public int DoorCount;
	public Sedan(int _SedanWheelCount, string _SedanColor, bool _HasHatchBack, int _DoorCount)
		: base(_SedanWheelCount, _SedanColor)
	{
		WheelCount = _SedanWheelCount;
		Color = _SedanColor;
		HasHatchBack = _HasHatchBack;
		DoorCount = _DoorCount;
	}
	public override void Drive()
	{
		Console.WriteLine($"I am driving speed limit in my {Color} {DoorCount}-door car!");
	}
}

class RaceCar : Vehicle
{
	public int EngineSize;
	public RaceCar(int _WheelCount, string _Color, int _EngineSize)
		: base(_WheelCount, _Color)
	{
		EngineSize = _EngineSize;
	}

	public override void Drive()
	{
		Console.WriteLine($"I am driving really fast with my {EngineSize} engine! The car is {Color}.");
	}
}