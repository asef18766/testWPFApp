using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
namespace testingApp.DataModel.User
{
    public class UserModel : XPObject
    {
        public UserModel(Session session) : base(session) { }

        string _username;
        [Size(10)]
        [Nullable(false)]
        public string username {
            get { return _username; }
            set { SetPropertyValue(nameof(username), ref _username, value); }
        }

        string _address;
        [Size(10)]
        [Nullable(false)]
        public string address
        {
            get { return _username; }
            set { SetPropertyValue(nameof(address), ref _address, value); }
        }

        int _age;
        [Nullable(false)]
        public int age
        {
            get { return _age; }
            set { SetPropertyValue(nameof(address), ref _age, value); }
        }

    }
}
