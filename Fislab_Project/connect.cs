using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Fislab_Project
{
    public class connect
    {
        private bool _internet;
        public bool internet
        {
            get { return _internet; }
            set { _internet = value; }
        }
        private IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KTkJ63vqljTTmt53tb8a4A93lrgN3sAuFG7q5t72",
            BasePath = "https://fislabproject-default-rtdb.firebaseio.com/"
        };
        private IFirebaseClient client;
        public bool check()
        {
            client = new FireSharp.FirebaseClient(config);
            if(client != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IFirebaseClient Client
        {
            get { return client; }
        }
    }
}