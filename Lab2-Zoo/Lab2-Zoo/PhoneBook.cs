using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Zoo
{
    internal class PhoneBook
    {
      public  Dictionary<int, string> dic = new Dictionary<int, string>();
        public string this[int key]
        {
            set
            {
                dic[key] = value;
            }
            get
            {
                return dic[key];
            }
        }
        public int this[string val]
        {
            set
            {
                dic.Add(value, val);
            }
            get
            {
                foreach(KeyValuePair<int,string>item in dic)
                {
                    if (item.Value == val)
                    {
                        return item.Key;
                    }
                }
                return -1;
            }
        }

    }
}
