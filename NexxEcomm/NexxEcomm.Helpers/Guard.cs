using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexxEcomm.Helpers
{
    public class Guard
    {
        public static void ForNullOrEmpty(string value, string msgErro)
        {
            if (value=="")
            {
                throw new Exception(Exception, msgErro);
            }

        }
    }
}
