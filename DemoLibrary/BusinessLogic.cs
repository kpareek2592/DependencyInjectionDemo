using DemoLibrary.Utilities;
using System;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            this._logger = logger;
            this._dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
