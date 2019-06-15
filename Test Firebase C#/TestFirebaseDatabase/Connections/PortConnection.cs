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
        private string node = "IPs";

        private FirebaseClient firebase;

        public PortConnection(string ipAddress)
        {
            node = node + "/" + ipAddress + "/ports";
            this.firebase = new FirebaseClient(Database.databaseUrl,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(Database.databaseSecret)
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
                    links = item.Object.links,
                    language = item.Object.language
                });
            }
            return lstData;
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

        public async void Update(Port port)
        {
            await firebase.Child(node).Child(port.portNumber).PutAsync<Port>(port);
        }

        public async Task Delete(string portNumber)
        {
            await firebase.Child(node).Child(portNumber).DeleteAsync();
        }
    }
}
