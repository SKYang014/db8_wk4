
Car one = new Car("WSB", "PolyTruck", 2030, 1000000m);
Car two = new Car("RKT-MTG", "Rocketship", 2050, 100000000m);
Car three = new Car("WSB", "PolyTruck", 2030, 10m);

UsedCar four = new UsedCar("Boatmobile", "Invisible", 1950, 500m, 100, "Barnacle Boy");
//Console.WriteLine(four.ToString());

List<Car> inventory = new List<Car>();

inventory.Add(one);
inventory.Add(two);
inventory.Add(three);
inventory.Add(four);

Console.WriteLine("Welcome to the pushy dealership, costs have doubled since your last visit!");

do
{

    ShowAll(inventory);
    Console.WriteLine("What would you like to do? Sell your car[1] buy a car [2], or leave(again?)[3] ");

    int mainMenu = Convert.ToInt32(Console.ReadLine());
    while (mainMenu >3 || mainMenu <1)
    {
        Console.WriteLine("Try again, Sell your car[1] buy a car [2], or leave[3] ");
        mainMenu = Convert.ToInt32(Console.ReadLine());
    }
    if (mainMenu == 1)
    {
        AddCar(inventory);
    }
    else if (mainMenu ==2)
    {
        Console.WriteLine("Which car would you like to purchase? (all sales final)");
        int index = Convert.ToInt32(Console.ReadLine());
        DeleteCar(inventory, index);

    }
    else if (mainMenu ==3)
    {
        Console.WriteLine("Come back when your credit is better!");
        break;
    }

} while (true);

static void DeleteCar(List<Car> theList, int x)
{
    Console.WriteLine("You want to buy the: ");
    Console.WriteLine(theList[x]);
    Console.WriteLine("enter y/n");
    string choice = Console.ReadLine().ToLower();

    if (choice == "y" || choice == "yes")
    {
        theList.RemoveAt(x);
        Console.WriteLine("No Take-backsies!");
    }
    else
    {
        Console.WriteLine("That's okay, I have another family coming to look at it later today");
    }
         
}

static void AddCar(List<Car> theList)
{
    Console.WriteLine("Is the car new[1] or used[2]?");
    int carType = Convert.ToInt32(Console.ReadLine());
    while (carType < 1 || carType > 2)
    {
        Console.WriteLine("Please enter new[1] or used[2]: ");
        carType = Convert.ToInt32(Console.ReadLine());
    }
        Console.WriteLine("What is the make?");
        string make = Console.ReadLine();
        Console.WriteLine("what is the model?");
        string model = Console.ReadLine();
        Console.WriteLine("What year was it made?");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the price?");
        decimal price = Convert.ToDecimal(Console.ReadLine());
    if (carType == 1)
    {
        Car beep = new Car((make),(model),(year),(price));
        theList.Add(beep);
    }
    if(carType == 2)
    {
        Console.WriteLine("What is the milage?");
        double milage = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Who was the previous owner?");
        string prevowner = Console.ReadLine();

        UsedCar honk = new UsedCar((make), (model), (year), (price), (milage), (prevowner));
        theList.Add(honk);
    }
        Console.WriteLine("New car added!");
}

static void ShowAll(List<Car>x)
{
    int i = 1;
    Console.WriteLine("--------------------------\nCurrent Inventory\n--------------------------");
    foreach (Car item in x) 
    {
        Console.Write(i +". ");
        Console.WriteLine(item.ToString());
        i++;
    }
}

class Car
{
    public string Make;
    public string Model;
    public int Year;
    public decimal Price;

    public Car(string aMake, string aModel, int aYear, decimal aPrice)
    {
        Make = aMake;
        Model = aModel;
        Year = aYear;
        Price = aPrice;
    }

    public override string ToString()
    {
        return
            $"{Make} {Model} {Year} ${Price}\n" +
            $"--------------------------";
    }


}

class UsedCar : Car
{
    public double Miles;
    public string PrevOwner;

    public UsedCar (string aMake, string aModel, int aYear, decimal aPrice, double aMiles, string aPrevOwner)
        :base(aMake, aModel, aYear, aPrice)
    {
        Miles = aMiles;
        PrevOwner = aPrevOwner;
    }
    public override string ToString()
    {
        return $"{Make} {Model} {Year} ${Price} Mileage:{Miles}  Previous Owner:{PrevOwner}\n" +
            $"--------------------------";
    }
}