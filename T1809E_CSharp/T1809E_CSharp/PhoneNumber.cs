namespace T1809E_CSharp
{
    public class PhoneNumber<X>
    {    
        private string name;
        private X phone;

        public PhoneNumber(string name, X phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public X Phone
        {
            get => phone;
            set => phone = value;
        }
    }
}