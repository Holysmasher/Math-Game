using MyFirstProgram;
using System.Threading.Tasks.Sources;

var date = DateTime.Now;

var games = new List<string>();

string name = Helpers.GetName();

var menu = new Menu();


menu.ShowMenu(name, date);
