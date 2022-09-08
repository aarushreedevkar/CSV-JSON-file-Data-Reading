namespace ThirdPartyLibrary1
{
    class program
    {
        public static void Main(string[] args)
        {
            LibraryReading.ImplementCSVDataHandling();
            
            string importjsonfilepath= @"C:\Users\test\Desktop\Reviews\ThirdPartyLibrary1\ThirdPartyLibrary1\Address.json"


            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sw = new StreamWriter(importjsonFilePath);
            using(JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.serialize(writer, records);
            }
        }
    }
}
