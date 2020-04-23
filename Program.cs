using System;
using ComparerApp.LibrarySnd.Services;

namespace ComparerApp.ForConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();

            var decisionManager = new DecisionManager();
            var preparator = new ComparerPreparator();

            app.Run(decisionManager, preparator);
        }
    }
}
