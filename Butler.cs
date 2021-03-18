using System.IO;

namespace ChatButler
{
    public class Butler
    {
        public Butler()
        {
            // json file inlezen
            string json = File.ReadAllText("greetings.json");
        }

        public string Greet()
        {
            return "Hi";
        }
    }
}