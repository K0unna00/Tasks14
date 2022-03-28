using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks14
{
    internal class User
    {
        public User(string name)
        {
            this._name = name;
        }



        private string _name = "No Name";
        private string _password = "No Password";



        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    _name = value;
                }
            }

        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 8 && value.Length <= 25)
                {
                    bool[] boolarr = { false, false, false };
                    foreach (var item in value)
                    {
                        if (char.IsDigit(item))
                        {
                            boolarr[0] = true;
                        }
                        else if (char.IsLower(item))
                        {
                            boolarr[0] = true;
                        }
                        else if (char.IsUpper(item))
                        {
                            boolarr[0] = true;
                        }
                        if (boolarr[0] && boolarr[1] && boolarr[2])
                        {
                            Console.WriteLine("Isledi");
                            _password = value;
                            break;
                        }
                    }
                    

                }
            }
        }
        public void GetInfo()
        {
            Console.WriteLine(_name + " " + _password);
        }
        public bool HasDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item)) return true;
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            foreach (var item in str)
            {
                if (char.IsUpper(item)) return true;
            }
            return false;
        }
        public bool HasLower(string str)
        {
            foreach (var item in str)
            {
                if (char.IsLower(item)) return true;
            }
            return false;
        }
    }
}
