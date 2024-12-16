using MyFirstProgram;

var date = DateTime.UtcNow;

var menu = new Menu();

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name;
}