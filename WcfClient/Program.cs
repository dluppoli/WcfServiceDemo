using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.ServiceReference;

namespace WcfClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Service1Client();
            string risultato1 = client.GetData(12);
            Console.WriteLine(risultato1);

            CompositeType compositeType = new CompositeType
            {
                BoolValue = true,
                StringValue = "Hello World!"
            };
            var risultato2 = client.GetDataUsingDataContract(compositeType);
            Console.WriteLine($"{risultato2.BoolValue} - {risultato2.StringValue}");

            Console.ReadLine();
        }
    }
}
