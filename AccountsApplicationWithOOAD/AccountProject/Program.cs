using AccountLibrary.Controller;
using AccountProject.Presentation;

namespace AccountProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountManager manager = new AccountManager();
            AccountStore.DisplayMenu();
        }
    }
}
