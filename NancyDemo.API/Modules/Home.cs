using Nancy;
namespace NancyDemo.API.Modules
{
    public sealed class Home : NancyModule
    {
        public Home() : base("Home")
        {
            Get("", args => "Hello Nancy!");
        }
    }
}