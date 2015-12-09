using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleFood
{
    class cls_network
    {
        //Variablen
        const int port = 9653;
        private UdpClient receivingClient;
        private UdpClient sendingClient;
        public string result = "";
        public Boolean isRunning = false;
        private Boolean isReceiving = false;

        private void InitializeReceiver()
        {
            isReceiving = true;
            receivingClient = new UdpClient(port);
            ThreadPool.QueueUserWorkItem(Receiver);
        }

        private void InitializeSender(string ip)
        {
            isRunning = true;
            sendingClient = new UdpClient(ip, port);
            sendingClient.EnableBroadcast = true;
        }

        private void Receiver(object stateInfo)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            do
            {
              byte[] data;

            } while (true);

        }
    }
}
