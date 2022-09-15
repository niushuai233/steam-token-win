using steam_token.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace steam_token
{
    public class XXXSteamTwoFactorToken
    {
        private static byte[] s_rgchSteamguardCodeChars = { 50, 51, 52, 53, 54, 55, 56, 57, 66, 67, 68, 70, 71, 72, 74, 75, 77, 78, 80, 81, 82, 84, 86, 87, 88, 89 };
        private byte[] mSecret;

        public XXXSteamTwoFactorToken(String sharedSecret)
        {
            if (string.IsNullOrEmpty(sharedSecret))
            {
                this.mSecret = Convert.FromBase64String(sharedSecret);
            }
            else
            {
                MessageBox.Show("未知参数 shared_secret");
            }
        }

        public static String GenerateSteamGuardCode()
        {
            string sharedSecret = ConfigUtil.Read<Config>().SteamGuard.shared_secret;

            return new XXXSteamTwoFactorToken(sharedSecret).GenerateSteamGuardCodeForTime(CurrentTime());
        }

        private String GenerateSteamGuardCodeForTime(long calcTime)
        {

            return null;
        }

        private static long CurrentTime()
        {
            return DateTime.Now.Millisecond / 1000;
        }
    }
}
