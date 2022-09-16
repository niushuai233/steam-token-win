using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steam_token.Entity
{
    public class Config
    {
        public Config()
        {
            SteamGuard = new SteamGuard();
        }
        public SteamGuard SteamGuard { get; set; }

    }
}
