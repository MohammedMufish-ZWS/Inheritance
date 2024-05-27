using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{   //we have to make singleton thread safe
    //singleton means i want only single instance of that class to be created
    //example if a class is there with 3 three instances of that class,in singleton we don't do that
    //what we do instead is create only single instance of that class
    sealed class UploadService
    {   
        private UploadService(){    }
        //we have made it private Because only the classitseld should be create an instance so we should not be able create object of that class from outside of the class 
        public int Id { get; private set; }
        private static UploadService _instance;
        private static readonly object _lock = new object();
        public static UploadService Instance(int id)
        {
            if (_instance==null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                    _instance = new UploadService();
                    _instance.Id = id;
                    }
                }
            }
            return _instance;
        }

    }
}
