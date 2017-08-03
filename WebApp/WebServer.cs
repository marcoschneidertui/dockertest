using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApp
{
    class WebServer
    {
        private readonly HttpListener _listener = new HttpListener();

        public WebServer()
        {
            if (!HttpListener.IsSupported)
                throw new NotSupportedException("Needs Windows XP SP2, Server 2003 or later.");

            _listener.Prefixes.Add("http://*:8080/");
        }

        static void Main()
        {
            Console.WriteLine("Starting Webserver");
            WebServer webServer = new WebServer();
            webServer.Start();
        }

        public void Start()
        {
            _listener.Start();
            while(true)
            {
                HttpListenerContext ctx = _listener.GetContext();
                new Thread(new Worker(ctx).ProcessRequest).Start();
            }
        }

        public void Stop()
        {
            _listener.Stop();
            _listener.Close();
        }

    }
}
