using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    class UserInfo
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public bool Valid;
        public bool Marked;

        public UserInfo()
        {
            init();
        }

        public UserInfo(string name)
        {
            init();
            _Name = name;
        }

        private void init()
        {
            Valid = false;
            Marked = false;
        }
    }
}
