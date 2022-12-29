 using System.Collections.Generic;

namespace Indexer
{
    public class HttpCookie
    {
        //specifing keys should be type string, and value should be type string 
        //name of dictionary = "_dictionary"
        
        private readonly Dictionary<string, string> _dictionary;
        
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }




        //now creating a indexer - does not have a name, we use this keyword 
        //we use string to represent the keys 
        public string this[string key]
        {
            get { return _dictionary[key]; }


            set { _dictionary[key] = value; }
        }


    }
}
