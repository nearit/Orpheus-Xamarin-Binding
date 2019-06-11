using System;
namespace OrpheusSample
{
    public class EmptyClass: IT.Near.Sdk.Jsonapiparser.Resource
    {
        public EmptyClass()
        {
        }

        public string Name 
        {
            set;
            get;
        }
    }
}
