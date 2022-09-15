using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steam_token.Util
{
    public class SteamTwoFactorToken
    {
        private static byte[] s_rgchSteamguardCodeChars = { 50, 51, 52, 53, 54, 55, 56, 57, 66, 67, 68, 70, 71, 72, 74, 75, 77, 78, 80, 81, 82, 84, 86, 87, 88, 89 };
        private byte[] mSecret;

        public SteamTwoFactorToken(String sharedSecret)
        {
            if (!string.IsNullOrEmpty(sharedSecret))
            {
                this.mSecret = Convert.FromBase64String(sharedSecret);
            }
            else
            {
                MessageBox.Show("未知的shared_secret");
            }
        }

        public static string GenerateSteamGuardCode(String sharedSecret)
        {
            return new SteamTwoFactorToken(sharedSecret).GenerateSteamGuardCode();
        }

        public string GenerateSteamGuardCode()
        {
            return GenerateSteamGuardCodeForTime(CurrentTime());
        }

        private string GenerateSteamGuardCodeForTime(long calcTime)
        {
            if (this.mSecret == null)
            {
                return "";
            }
            byte[] bArr = new byte[8];
            long j2 = calcTime / 30;

            int i = 8;
            while (true)
            {
                int i2 = i - 1;
                if (i <= 0)
                {
                    break;
                }
                bArr[i2] = (byte)((int)j2);
                j2 = RightMove(j2, 8);
                i = i2;
            }

            HMACSHA1 hmacsha1 = new HMACSHA1();
            hmacsha1.Key = (this.mSecret);

            byte[] doFinal = hmacsha1.ComputeHash(bArr);
            int i3 = doFinal[19] & 15;
            int i4 = (doFinal[i3 + 3] & 255) | ((doFinal[i3 + 2] & 255) << 8) | ((doFinal[i3] & 127) << 24) | ((doFinal[i3 + 1] & 255) << 16);
            byte[] bArr2 = new byte[5];
            for (int i5 = 0; i5 < 5; i5++)
            {
                byte[] bArr3 = s_rgchSteamguardCodeChars;
                bArr2[i5] = bArr3[i4 % bArr3.Length];
                i4 /= bArr3.Length;
            }

            return System.Text.Encoding.UTF8.GetString(bArr2);
        }

        public long CurrentTime()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000;
        }


        /// <summary>
        /// 无符号右移, 相当于java里的 value>>>pos
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public long RightMove(long value, int pos)
        {
            //移动 0 位时直接返回原值
            if (pos != 0)
            {
                // int.MaxValue = 0x7FFFFFFF 整数最大值
                int mask = int.MaxValue;
                //无符号整数最高位不表示正负但操作数还是有符号的，有符号数右移1位，正数时高位补0，负数时高位补1
                value = value >> 1;
                //和整数最大值进行逻辑与运算，运算后的结果为忽略表示正负值的最高位
                value = value & mask;
                //逻辑运算后的值无符号，对无符号的值直接做右移运算，计算剩下的位
                value = value >> pos - 1;
            }

            return value;
        }
    }
}
