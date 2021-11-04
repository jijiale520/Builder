namespace Builder.Properties
{
    public class Director
    {
        private Builder builder;


        public Director(Builder _builder)
        {
            this.builder = _builder;
        }
        public void Creator(string _string, string _cap, string _capBody)
        {
            builder.BuildString(_string);
            builder.BuildCap(_cap);
            builder.BuildCapBody(_capBody);
            builder.GetResult().Show();
        }
    }
}