using System;

namespace Builder.Properties
{
    public class Cap
    {
        private string name;
        private string cap;
        private string capBody;


        public void SetString(string _name)
        {
            this.name = _name;
        }

        public void SetCap(string _cap)
        {
            this.cap = _cap;
        }

        public void SetCapBody(string _capBody)
        {
            this.capBody = _capBody;
        }

        public void Show()
        {
            Console.WriteLine(string.Format("name = {0}, cap = {1}, capBody = {2}", name, cap, capBody));
        }
    }
}