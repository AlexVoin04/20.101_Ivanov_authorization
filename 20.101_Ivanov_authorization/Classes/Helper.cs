using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._101_Ivanov_authorization.Classes
{
    internal class Helper
    {
        private static Model.Entities s_bankEntities;
        public static Model.Entities GetContext()
        {
            if (s_bankEntities == null)
            {
                s_bankEntities = new Model.Entities();
            }
            return s_bankEntities;
        }
        
    }
}
