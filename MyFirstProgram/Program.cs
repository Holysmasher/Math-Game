using MyFirstProgram;
using System.Threading.Tasks.Sources;

var date = DateTime.Now;

var games = new List<string>();

string name = GetName();

var menu = new Menu();


menu.ShowMenu(name, date);


string GetName()
{
    Console.WriteLine("Please type your name:");

    var name = Console.ReadLine();
    return name;
}
