using Nancy;
namespace NancyDemo.API.Modules {
    public class Home : NancyModule {
        public Home () : base ("Home") {
            Get ("", async args => {
                return "Hello Nancy!";
            });
        }
    }
}