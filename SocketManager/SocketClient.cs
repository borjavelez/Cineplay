using Cineplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cineplay.SocketManager
{
    class SocketClient
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Form1 form1;

        public SocketClient(Form1 form1)
        {
            this.form1 = form1;
            LoopConnect();
            form1.clientLabel("Connected");
        }

        private void SendLoop(String text)
        {
            while (true)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(text);
                _clientSocket.Send(buffer);

                //byte[] receivedBuf = new byte[1024];
                //int rec = _clientSocket.Receive(receivedBuf);

                //byte[] data = new byte[rec];
                //Array.Copy(receivedBuf, data, rec);
                //textBox2.Text = Encoding.ASCII.GetString(data);
                break;

            }
        }

        private static void LoopConnect()
        {
            int attemps = 0;
            while (!_clientSocket.Connected)
            {

                try
                {
                    attemps++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);

                }
                catch (SocketException)
                {

                }
            }
        }

        public void sendCommand(String text)
        {
            SendLoop(text);
        }
    }
}
