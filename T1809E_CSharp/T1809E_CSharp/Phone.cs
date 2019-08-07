using System.Collections.Generic;

namespace T1809E_CSharp
{
    public abstract class Phone
    {
        public abstract bool InsertPhone(string name, string phone);
        public abstract bool RemovePhone(string name);
        public abstract bool UpdatePhone(string name,string oldphone, string newphone);
        public abstract PhoneNumber<List<string>> SearchPhone(string name);
    }
}