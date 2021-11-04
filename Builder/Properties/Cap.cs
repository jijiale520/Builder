using System;

namespace Builder.Properties
{
    public class Cap
    {
        private string rope;
        private string cap;
        private string capBody;


        public void SetString(string _rope)
        {
            this.rope = _rope;
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
            Console.WriteLine(string.Format("rope = {0}, cap = {1}, capBody = {2}", rope, cap, capBody));
        }
    }
}