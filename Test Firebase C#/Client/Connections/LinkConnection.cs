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
        private const String databaseUrl = "https://ff-e88a5.firebaseio.com";
        private const String databaseSecret = "b0aKnIBMLnKA8VZAxhqi2PEnQJcOqFoGE4YwnuXY";
        private string node = "IPs";

        private FirebaseClient firebase;

        public LinkConnection(string ipAddress, string portNumber)
        {
            node = node + "/" + ipAddress + "/ports/" + portNumber + "/links/";
            this.firebase = new FirebaseClient(databaseUrl,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(databaseSecret)
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
                    description = item.Object.description,
                    type = item.Object.type
                };
                lstData.Add(item.Key, link);
                await Update(link);
            }
            return lstData;
        }

        public async Task<Link> GetFirstElement()
        {
            var results = await firebase.Child(node).OnceAsync<Link>();
            foreach (var item in results)
            {
                return new Link
                {
                    key = item.Key,
                    link = item.Object.link,
                    linkThumbnail = item.Object.linkThumbnail,
                    title = item.Object.title,
                    description = item.Object.description,
                    type = item.Object.type
                };
            }
            return null;
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
