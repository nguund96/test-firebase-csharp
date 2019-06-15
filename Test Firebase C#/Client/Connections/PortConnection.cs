using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFirebaseDatabase.Models;

namespace TestFirebaseDatabase.Connections
{
    public class PortConnection
    {
        private const String databaseUrl = "https://ff-e88a5.firebaseio.com";
        private const String databaseSecret = "b0aKnIBMLnKA8VZAxhqi2PEnQJcOqFoGE4YwnuXY";
        private string node = "IPs";

        private FirebaseClient firebase;

        public PortConnection(string ipAddress)
        {
            node = node + "/" + ipAddress + "/ports";
            this.firebase = new FirebaseClient(databaseUrl,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(databaseSecret)
                });
        }

        public async Task<Dictionary<string, Port>> GetAll()
        {
            var results = await firebase.Child(node).OnceAsync<Port>();
            Dictionary<string, Port> lstData = new Dictionary<string, Port>();
            foreach (var item in results)
            {
                lstData.Add(item.Key, new Port
                {
                    portNumber = item.Key,
                    active = item.Object.active,
                    die = item.Object.die,
                    data = item.Object.data,
                    port = item.Object.port,
                    links = item.Object.links
                });
            }
            return lstData;
        }
        public async Task<Port> GetNextPort(string previousPortNumber)
        {
            var results = await firebase.Child(node).OnceAsync<Port>();
            List<Port> lstData = new List<Port>();
            foreach (var item in results)
            {
                lstData.Add(new Port
                {
                    portNumber = item.Key,
                    active = item.Object.active,
                    die = item.Object.die,
                    data = item.Object.data,
                    port = item.Object.port,
                    links = item.Object.links
                });
            }
            for (int i = 0; i < lstData.Count; i++)
            {
                if (lstData[i].portNumber == previousPortNumber)
                {
                    if ((i + 1) > lstData.Count - 1) return lstData[0];
                    else return lstData[i + 1];
                }
            }
            return null;
        }

        public async Task<Port> GetWithKey(string portNumber)
        {
            var result = await firebase.Child(node).Child(portNumber).OnceSingleAsync<Port>();
            Port port = result;
            return port;
        }

        public async Task Insert(Port port)
        {
            await firebase.Child(node).Child(port.portNumber).PutAsync<Port>(port);
        }

        public async Task Update(Port port)
        {
            await firebase.Child(node).Child(port.portNumber).PutAsync<Port>(port);
        }

        public async Task Delete(string portNumber)
        {
            await firebase.Child(node).Child(portNumber).DeleteAsync();
        }
    }
}
