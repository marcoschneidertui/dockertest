using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    public class Worker
    {
        private HttpListenerContext context;

        public Worker(HttpListenerContext context)
        {
            this.context = context;
        }

        public void ProcessRequest()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body><h1>Hello World from C# and Docker</h1>");

            byte[] b = Encoding.UTF8.GetBytes(sb.ToString());
            context.Response.ContentLength64 = b.Length;
            context.Response.OutputStream.Write(b, 0, b.Length);
            context.Response.OutputStream.Close();
        }
    }
}
