namespace Builder.Properties
{
    public abstract class Builder
    {
        protected Cap cap = new Cap();
        public abstract void BuildCap(string _cap);
        public abstract void BuildCapBody(string _capBody);
        public abstract void BuildString(string _string);

        public Cap GetResult()
        {
            return cap;
        }
    }
}