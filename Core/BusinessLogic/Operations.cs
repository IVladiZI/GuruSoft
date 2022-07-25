using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessLogic
{
    public class Operations : IOperations
    {
        public string Problema1(string x)
        {
            return x.Substring(((x.Length % 2) == 0 ? (x.Length/2)-1 : (x.Length / 2)), ((x.Length % 2) == 0 ? 2:1));
        }

        public string Problema2(int n,int i)
        {
            string m=$"Los {n} primeros números apartir de {i}{Environment.NewLine}";
            for (int y = i; y <= n; y++)
            {
                if (Primo(y))
                {
                    m =m + y + ',';
                }
            }
            return m.TrimEnd(',');
        }
        private bool Primo(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if ((x % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
