using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MusicServiceHost
{
    class Program
    {
        /// <summary>
        /// Host opens for service to client 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MusicService.MusicService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
