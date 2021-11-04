namespace Builder.Properties
{
    public interface Builder
    {
        void BuildCap();
        void BuildCapBody();
        void BuildString();
        Cap GetResult();
    }
}