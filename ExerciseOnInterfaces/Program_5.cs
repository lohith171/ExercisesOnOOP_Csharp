using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOnInterfaces
{
    class Program_5
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine();
            var EncodeVideos = new WorkFlow();

            EncodeVideos.RegisterActivity(new UploadVideo());
            
            EncodeVideos.RegisterActivity(new SendEmailToUser());

            workFlowEngine.Run(EncodeVideos);
            Console.ReadLine();
        }
    }
}
