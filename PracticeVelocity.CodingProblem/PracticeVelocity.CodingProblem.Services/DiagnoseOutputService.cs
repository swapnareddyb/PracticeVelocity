using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeVelocity.CodingProblem.Models;
using PracticeVelocity.CodingProblem.Services;

namespace PracticeVelocity.CodingProblem.Services
{
    internal class DiagnoseOutputService : IOutputService
    {
        private MultiplesService multipleService;

        public DiagnoseOutputService()
        {
            multipleService = new MultiplesService();
        }

        public OutputModel Get()
        {
            OutputModel outputModel = new OutputModel();
            outputModel.EventType = EnumEventType.Diagnose;
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            outputModel.Result = new List<string>();
            
            foreach(var number in numbers)
            {
                if (multipleService.IsMultiple(number, 2) && multipleService.IsMultiple(number, 7))
                {
                    outputModel.Result.Add(CodingProblemConstants.Print.Diagnose + " " + CodingProblemConstants.Print.Patient);
                    continue;
                }
                if (multipleService.IsMultiple(number, 2))
                {
                    outputModel.Result.Add(CodingProblemConstants.Print.Diagnose);
                    continue;
                }
                if (multipleService.IsMultiple(number, 7))
                {
                    outputModel.Result.Add(CodingProblemConstants.Print.Patient);
                    continue;
                }
                outputModel.Result.Add(number.ToString());
            }

            return outputModel;
        }
    }
}
