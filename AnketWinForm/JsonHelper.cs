using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketWinForm
{
    public static class JsonFileHelper
    {
        public static void JSONSerialization(Human human, string filename)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, human);
                }
            }
        }
        public static void JSONDeSerialization(ref Human human, string filename)
        {
            var serializer = new JsonSerializer();

            using (StreamReader streamReader = new StreamReader(filename))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    human = serializer.Deserialize<Human>(jsonTextReader);
                }
            }
        }

    }
}
