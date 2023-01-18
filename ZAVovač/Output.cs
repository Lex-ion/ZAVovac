using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAVovač
{
    internal class Output
    {

        public static void Send(char znak, int interval)
        {
            switch (znak)
            {
                default:
                    SendKeys.Send(znak.ToString());
                    break;

                case '+':
                    SendKeys.Send("{+}");
                    break;

                case '^':
                    SendKeys.Send("{^}");
                    break;

                case '%':
                    SendKeys.Send("{%}");
                    break;

                case '~':
                    SendKeys.Send("{~}");
                    break;

                case '(':
                    SendKeys.Send("{(}");
                    break;

                case ')':
                    SendKeys.Send("{)}");
                    break;
            }

            Thread.Sleep(interval);
        }
    }
}
