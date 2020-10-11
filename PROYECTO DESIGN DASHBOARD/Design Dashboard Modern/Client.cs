using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern
{
    class Client
    {

        private TcpClient _client;
        private StreamReader _sReader;
        private StreamWriter _sWriter;
        private Boolean _isConnected;
        public Client(String ipAddress, int portNum)
        {
            _client = new TcpClient();
            _client.Connect(ipAddress, portNum);
        }

        public void SendData(string data)
        {
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);
            _sWriter.WriteLine(data);
            _sWriter.Flush();
        }

        public string ReceiveData()
        {
            while (true)
            {
                _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);
                string sDataIncomming = _sReader.ReadLine();
                if (sDataIncomming != null)
                {
                    return sDataIncomming;
                    _client.Close();
                }

            }
        }

        public static string StringToJSONWithJSONNet(string data)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(data);
            return JSONString;
        }

        public void HandleCommunication()
        {
            String sData = null;
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);
            _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);
            _isConnected = true;

            while (_isConnected)
            {
                Console.Write("> ");
                sData = Console.ReadLine();
                _sWriter.WriteLine(sData);
                // nhận dữ liệu
                String sDataIncomming = _sReader.ReadLine();
                Console.Write("Server" + sDataIncomming);
                sDataIncomming = _sReader.ReadLine();
                Console.Write("Server" + sDataIncomming);
            }
        }
    }
}
