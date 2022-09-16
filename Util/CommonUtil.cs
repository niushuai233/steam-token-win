using steam_token.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace steam_token.Util
{
    public class CommonUtil
    {

        public static bool FIRST_ENABLE  = true;
        public static Config GetConfig()
        {
            return ConfigUtil.Read<Config>();
        }
    }
}
