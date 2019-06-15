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
    public class IPConnection
    {
        private const String node = "IPs/";

        private FirebaseClient firebase;

        public IPConnection()
        {
            this.firebase = new FirebaseClient(Database.databaseUrl,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(Database.databaseSecret)
                });
        }

        public async Task<Dictionary<string, IP>> GetAll()
        {
            var results = await firebase.Child(node).OnceAsync<IP>();
            Dictionary<string, IP> lstData = new Dictionary<string, IP>();
            foreach (var item in results)
            {
                lstData.Add(item.Key, new IP
                {
                    ipAddress = item.Key,
                    availability = item.Object.availability,
                    ports = item.Object.ports
                });
            }
            return lstData;
        }

        public async Task<IP> GetFirstElement()
        {
            var results = await firebase.Child(node).OnceAsync<IP>();
            foreach (var item in results)
            {
                return new IP
                {
                    ipAddress = item.Key,
                    availability = item.Object.availability,
                    ports = item.Object.ports
                };
            }
            return null;
        }

        public async Task<IP> GetWithKey(string ipAddress)
        {
            var result = await firebase.Child(node).Child(ipAddress).OnceSingleAsync<IP>();
            IP ip = result;
            return ip;
        }

        public async Task Insert(IP ip)
        {
            await firebase.Child(node).Child(ip.ipAddress).PutAsync<IP>(ip);
        }

        public async void Update(IP ip)
        {
            await firebase.Child(node).Child(ip.ipAddress).PutAsync<IP>(ip);
        }

        public async Task Delete(string ipAddress)
        {
            await firebase.Child(node).Child(ipAddress).DeleteAsync();
        }
    }
}
