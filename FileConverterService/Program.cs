﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace FileConverterService
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HostFactory.Run(serviceConfig =>
            { serviceConfig.Service<ConverterService>(serviceInstance =>
            {
                serviceInstance.ConstructUsing(
                    () => new ConverterService());
                serviceInstance.WhenStarted(
                    execute => execute.Start());
                serviceInstance.WhenStopped(
                    execute => execute.Stop());
            });
                serviceConfig.SetServiceName("AwsomeFileConverter");
                serviceConfig.SetDisplayName("Awsome File Converter");
                serviceConfig.SetDescription("a Service Demo");

                serviceConfig.StartAutomatically(); 

            });
                
        }
    }
}
