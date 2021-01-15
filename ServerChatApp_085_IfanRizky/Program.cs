using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_085;

namespace ServerChatApp_085_IfanRizky
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;
            try
            {
                hostObjek = new ServiceHost(typeof(ServiceCallback));
                hostObjek.Open();

                Console.WriteLine("Server ON, Ready to Use!");
                Console.ReadLine();

                hostObjek.Close();
            }

            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
