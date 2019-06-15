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
    public class LinkConnection
    {
        private string node = "IPs";

        private FirebaseClient firebase;

        public LinkConnection(string ipAddress, string portNumber)
        {
            node = node + "/" + ipAddress + "/ports/" + portNumber + "/links/";
            this.firebase = new FirebaseClient(Database.databaseUrl,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(Database.databaseSecret)
                });
        }

        public async Task<Dictionary<string, Link>> GetAll()
        {
            var results = await firebase.Child(node).OnceAsync<Link>();
            Dictionary<string, Link> lstData = new Dictionary<string, Link>();
            foreach (var item in results)
            {
                Link link = new Link
                {
                    key = item.Key,
                    link = item.Object.link,
                    linkThumbnail = item.Object.linkThumbnail,
                    title = item.Object.title,
                    tag = item.Object.tag,
                    description = item.Object.description,
                    linkAff = item.Object.linkAff,
                    type = item.Object.type
                };
                lstData.Add(item.Key, link);
                await Update(link);
            }
            return lstData;
        }

        public async Task<Link> GetWithKey(string key)
        {
            var result = await firebase.Child(node).Child(key).OnceSingleAsync<Link>();
            Link link = result;
            return link;
        }

        public async Task Insert(Link link)
        {
            await firebase.Child(node).PostAsync<Link>(link);
        }

        public async Task Update(Link link)
        {
            await firebase.Child(node).Child(link.key).PutAsync<Link>(link);
        }

        public async Task Delete(string key)
        {
            await firebase.Child(node).Child(key).DeleteAsync();
        }
    }
}
