using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Sockets;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Text;
using System.IO;

namespace Update
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private const int BUFFER_SIZE = 1024;

        private const int PORT_NUMBER = 9999;

        static ASCIIEncoding encoding = new ASCIIEncoding();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public void GetAppInfo()
        {
            //socket
            try

            {

                IPAddress address = IPAddress.Parse("127.0.0.1");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                // 1. listen

                listener.Start();

                Socket socket = listener.AcceptSocket();

                NetworkStream stream = new NetworkStream(socket);

                StreamReader reader = new StreamReader(stream);

                StreamWriter writer = new StreamWriter(stream);

                writer.AutoFlush = true;

                while (true)

                {

                    // 2. receive

                    string str = reader.ReadLine();

                    if (str.ToUpper() == "EXIT")

                    {

                        writer.WriteLine("bye");

                        break;

                    }

                    // 3. send

                    writer.WriteLine("Hello " + str);

                }

                // 4. close

                stream.Close();

                socket.Close();

                listener.Stop();

            }

            catch (Exception ex)

            {

                Console.WriteLine("Error: " + ex);

            }
        }
    }
}
