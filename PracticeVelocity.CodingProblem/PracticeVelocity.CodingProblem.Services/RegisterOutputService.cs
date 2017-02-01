using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeVelocity.CodingProblem.Models;

namespace PracticeVelocity.CodingProblem.Services
{
    internal class RegisterOutputService : IOutputService
    {
        private MultiplesService multipleService;

        public RegisterOutputService()
        {
            multipleService = new MultiplesService();
        }

        public OutputModel Get()
        {
            OutputModel outputModel = new OutputModel();
            outputModel.EventType = EnumEventType.Diagnose;
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            outputModel.Result = new List<string>();

            foreach (var number in numbers)
            {
                if (multipleService.IsMultiple(number, 2) && multipleService.IsMultiple(number, 7))
                {
                    outputModel.Result.Add(CodingProblemConstants.Print.Register + " " + CodingProblemConstants.Print.Patient);
                    continue;
                }
                if (multipleService.IsMultiple(number, 3))
                {
                    outputModel.Result.Add(CodingProblemConstants.Print.Register);
                    continue;
                }
                if (multipleService.IsMultiple(number, 5))
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
