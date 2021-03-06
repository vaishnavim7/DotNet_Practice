﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;

using System.ServiceModel;
namespace HostWCFServiceInConsoleAppWithCode
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Hello();
    }
    public class HelloService : IService
    {
        #region IService Members
        public string Hello()
        {
            return "Hello World";
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(HelloService),new Uri("http://localhost:8000/HelloService"));
            //base address -> http://localhost:8000/HelloService

            host.AddServiceEndpoint(typeof(IService), new BasicHttpBinding(),"");
            //endpoint address -> Base Address + EndPoint Address
            //http://localhost:8000/HelloService

            ServiceMetadataBehavior behaviour = new ServiceMetadataBehavior();
            behaviour.HttpGetEnabled = true;

            host.Description.Behaviors.Add(behaviour);

            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            //http://localhost:8000/HelloService/mex

            host.Open();
            Console.WriteLine("service running...");
            Console.ReadLine();
            host.Close();
        }
    }
}
