namespace Generics_and_lambda_expressions;

class Program {
  static void Main() {
    var tree = new BinaryTree<int>();
    var menu = new Menu(Data.MenuItems);
    var menuManager = new MenuManager<int>(tree, int.Parse);
    menu.OnItemSelected += choice => menuManager.MenuChoice(choice);
    while (true) {
      Console.Clear();
      menu.Show();
    }
  }
}