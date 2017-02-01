using PracticeVelocity.CodingProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.CodingProblem.Services
{
    public class OutputService
    {
        private IOutputService outputservice;
        
        public OutputModel Get(EnumEventType eventType)
        {
            switch (eventType)
            {
                case EnumEventType.Diagnose:
                    outputservice = new DiagnoseOutputService();
                    break;
                case EnumEventType.Register:
                    outputservice = new RegisterOutputService();
                break;
                default:
                    throw new Exception("Not a valid event type. Please provide a valid event type and try again.");       
             }
            return outputservice.Get();
        }
    }
}
