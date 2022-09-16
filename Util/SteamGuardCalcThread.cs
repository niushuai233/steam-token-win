using steam_token.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace steam_token.Util
{
    public class SteamGuardCalcThread
    {
        private static Thread thread;
        private static Label label_guard;
        private static ProgressBar progressBar_refresh;
        internal static void StartThread(Label label, ProgressBar progressBar)
        {
            label_guard = label;
            progressBar_refresh = progressBar;

            StartThread();
        }

        private static void StartThread()
        {
            if (thread != null && thread.IsAlive)
            {
                // 先停止原先的线程
                thread.Abort();
                Console.WriteLine("中止线程");
            }
            // 等1s 保证停止
            // Thread.Sleep(1000);

            // 初始化线程
            thread = new Thread(Calc);
            thread.Name = "SteamGuardCalcThread";
            // 开启线程
            thread.Start();
        }

        private static void Calc()
        {
            Config config = ConfigUtil.Read<Config>();
            string shared_secret = config.SteamGuard.shared_secret;
            if (string.IsNullOrEmpty(shared_secret))
            {
                Console.WriteLine("未发现配置的秘钥");
                return;
            }
            CalcOnce();
            for (int i = 30; i >= 0; i--)
            {
                Thread.Sleep(1000);
                if (i == 0)
                {
                    CalcOnce();
                    i = 30;
                }

                progressBar_refresh.Value = i;
            }
        }


        private static string CalcOnce()
        {
            Config config = ConfigUtil.Read<Config>();
            string guard = SteamTwoFactorToken.GenerateSteamGuardCode(config.SteamGuard.shared_secret);
            Console.WriteLine("calc once guard = " + guard);
            label_guard.Text = guard;
            return guard;
        }
    }
}
