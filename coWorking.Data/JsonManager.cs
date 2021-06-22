using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace coWorking.Data
{
    public class JsonManager<T>
    {
        public List<T> GetCollection(){

            string currentPath = Directory.GetCurrentDirectory();
            string collectionPath = $"{currentPath}//{typeof(T)}.josn";

            List<T> myCollection = new List<T>();

            if (File.Exists(collectionPath)) {

                var streamrReader = new StreamReader(collectionPath);
                var currentContent = streamrReader.ReadToEnd();

                myCollection = JsonConvert.DeserializeObject<List<T>>(currentContent);

                streamrReader.Close();
            } 
            else {

                var jsonCollection = JsonConvert.SerializeObject(myCollection);

                var streamWriter = new StreamWriter(collectionPath);
                streamWriter.WriteLine(jsonCollection);
                streamWriter.Close();
            }

            return myCollection;
        }

        public bool SaveCollection(List<T> collection) {
            string currentPath = Directory.GetCurrentDirectory();
            string collectionPath = $"{currentPath}//{typeof(T)}.josn";

            try
            {
                var jsonCollection = JsonConvert.SerializeObject(collection);

                var streamWriter = new StreamWriter(collectionPath);
                streamWriter.WriteLine(jsonCollection);
                streamWriter.Close();   

                return true;
            }
            catch
            {
                return false;
            }
   
        }
    }
}