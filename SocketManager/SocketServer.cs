using Cineplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Cineplay;

namespace Cineplay.SocketManager
{
    class SocketServer
    {
        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Form1 form1;

        public SocketServer(Form1 form1)
        {
            this.form1 = form1;
            SetupServer();
        }


        private void SetupServer()
        {
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(1);
            form1.serverLabel("Listening");
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            form1.serverLabel("Connected");
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _clientSockets.Add(socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);

            string text = Encoding.ASCII.GetString(dataBuf);
            //textBox1.Text = text;

            if (text.ToLower() == "play")
            {
                form1.play();
                //SendText(DateTime.Now.ToLongTimeString(), socket);
            }
            if (text.ToLower() == "pause")
            {
                form1.pause();
                //SendText(DateTime.Now.ToLongTimeString(), socket);
            }
            else
            {
                SendText("Invalid Request", socket);
            }

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }

        private void SendText(string text, Socket socket)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
        }

        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }
    }
}
