﻿using ChromeDevTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChromeDevTools.Protocol;
using WebSocket4Net;

namespace AutoWebPerf
{
    class Program
    {
        static void Main(string[] args)
        {

            IChromeProcess chromeProcess = null;
            try
            {
                var chromeProcessFactory = new ChromeProcessFactory();
                chromeProcess = chromeProcessFactory.Create(9222);
                var endpointUrl = chromeProcess.GetSessions().Result.LastOrDefault();
                var chromeSessionFactory = new ChromeSessionFactory();

                var chromeSession = chromeSessionFactory.Create(endpointUrl);
                var pageEnableResult = chromeSession.SendAsync<ChromeDevTools.Protocol.Page.EnableCommand>().Result;
                chromeSession.Subscribe<ChromeDevTools.Protocol.Network.ResponseReceivedEvent>((o, e) =>
                    {
                        Console.WriteLine("Response Received");
                    });

                Console.ReadLine();
            }
            finally
            {
                if (null != chromeProcess)
                { 
                    chromeProcess.Dispose();
                }
            }

        }
        
    }
}