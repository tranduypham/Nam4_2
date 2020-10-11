using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern
{
    class DataToSend
    {
        public DataToSend()
        {

        }
        public DataToSend(string flag)
        {
            this.Flag = flag;
        }

        public DataToSend(string flag, string username, string password)
        {
            this.Flag = flag;
            this.UserName = username;
            this.PassWord = password;
        }

        public DataToSend(string flag, string username)
        {
            this.Flag = flag;
            this.UserName = username;
        }

        public DataToSend(string flag, string username, string password, string npassword) : this(flag, username, password)
        {
            this.NPassword = npassword;
        }

        private string flag;
        private string userName;
        private string passWord;
        private string nPassword;

        public string Flag { get => flag; set => flag = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string NPassword { get => nPassword; set => nPassword = value; }
    }
}
