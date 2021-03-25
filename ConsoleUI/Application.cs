using DemoLibrary;

namespace ConsoleUI
{
    public class Application : IApplication
    {
        private readonly IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            this._businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
