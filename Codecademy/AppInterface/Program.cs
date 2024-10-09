using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Doing chores");
      tdl.Display();
      tdl.Reset();

      PasswordManager pm = new PasswordManager("iluv", false);
      pm.Display();
      pm.ChangePassword("dddd", "ffff");
      pm.ChangePassword("dddddddd", "iluvcookies");
      pm.Display();
    }
  }
}
