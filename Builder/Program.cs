using Builder.Properties;

namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Director director = new Director(new SportCapBuilder());
            director.Creator("呢绒绳", "不锈钢冒", " 玻璃杯体");
            
            Director classDirector = new Director(new ClassCapBuilder());
            classDirector.Creator("塑料弹性绳", "塑料冒", "塑料杯体");
        }
    }
}