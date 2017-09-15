namespace _9.HTTP_Server
{
    using System;
    using System.IO;
    using System.Net.Sockets;

    public class HTTPServer
    {
        public static void Main()
        {

            Console.WriteLine("Choose a port:");
            var port = int.Parse(Console.ReadLine());
            var listener = new TcpListener(port);
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

                using (var reader = new StreamReader(client.GetStream()))
                {
                    using (var writer = new StreamWriter(client.GetStream()))
                    {
                        var request = reader.ReadLine();
                        Console.WriteLine(request);
                        var tokens = request.Split(' ');
                        var page = tokens[1];

                        if (page == "/")
                        {
                            page = "index.html";
                        }
                        else if (File.Exists("../../" + tokens[1]))
                        {
                            page = tokens[1];
                        }
                        else
                        {
                            page = "error.html";
                        }

                        using (var file = new StreamReader("../../" + page))
                        {
                            writer.WriteLine("HTTP/1.0 200 OK\n");

                            var data = file.ReadLine();

                            while (data != null)
                            {
                                writer.WriteLine(data);
                                writer.Flush();
                                data = file.ReadLine();
                            }

                        }
                    }
                }
                client.Close();
            }
        }
    }
}
