using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientController controller = new ClientController();
            //           controller.InsertClient();
                      controller.SelectAllClients();
            //           controller.SelectClientById();
            //            controller.DeleteClient();
        //    controller.UpdateClient();
            Console.ReadKey();
        }
    }
}
