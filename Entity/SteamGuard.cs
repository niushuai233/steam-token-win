using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steam_token.Entity
{
    public class SteamGuard
    {
        public string shared_secret { get; set; }
        public string serial_number { get; set; }
        public string revocation_code { get; set; }
        public string uri { get; set; }
        public string server_time { get; set; }
        public string account_name { get; set; }
        public string token_gid { get; set; }
        public string identity_secret { get; set; }
        public string secret_1 { get; set; }
        public string status { get; set; }
        public string steamguard_scheme { get; set; }
        public string steamid { get; set; }
    }
}
