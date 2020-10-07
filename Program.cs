using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using NewRelic.Api.Agent;


namespace SampleApp
{
    public static class Program
    { 

        public static void Main()
        {
            Demo demo = new Demo();
            for (int i =  0; i < 20; i ++)
            {
                demo.RunDemo(i);
                Thread.Sleep(15000);
            }
        }
    }
}
