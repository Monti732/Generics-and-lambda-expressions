namespace Generics_and_lambda_expressions;

class Program {
  static void Main() {
    var tree = new BinaryTree<int>();
    var menu = new Menu(Data.MenuItems);
    var menuManager = new MenuManager(Data.MenuItems.Length - 1);
    int menuChoice = -1;
    menu.OnItemSelected += choice => menuChoice = choice;
    //while (true) {
    menu.Show();
    Console.WriteLine(menuChoice);
    //}
  }
}