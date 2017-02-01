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
        private MathService mathService;

        public RegisterOutputService()
        {
            mathService = new MathService();
        }

        public OutputModel Get()
        {
            OutputModel outputModel = new OutputModel();
            outputModel.EventType = EnumEventType.Register;
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            outputModel.Result = new List<string>();

            foreach (var number in numbers)
            {
                if (mathService.IsMultiple(number, 3) && mathService.IsMultiple(number, 5))
                {
                    outputModel.Result.Add(CodingProblemConstants.Print.Register + " " + CodingProblemConstants.Print.Patient);
                    continue;
                }
                if (mathService.IsMultiple(number, 3))
                {
                    outputModel.Result.Add(CodingProblemConstants.Print.Register);
                    continue;
                }
                if (mathService.IsMultiple(number, 5))
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
