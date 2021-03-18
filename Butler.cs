using System.IO;
using System.Text.Json;

namespace ChatButler
{
    public class Butler
    {
        private Greetings _greetings;

        public Butler()
        {
            // json file inlezen
            string json = File.ReadAllText("greetings.json");
            _greetings = JsonSerializer.Deserialize<Greetings>(json);
        }

        public string Greet()
        {
            if(_greetings.language.Equals("nl"))
            {
                return _greetings.nl;
            }

            else if(_greetings.language.Equals("en"))
            {
                return _greetings.en;
            }

            return string.Empty; 
        }

        public class Greetings
        {
            public string language { get; set; }
            public string nl { get; set; }
            public string en { get; set; }

        }
    }
}