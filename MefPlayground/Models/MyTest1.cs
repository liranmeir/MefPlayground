using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;

namespace MefPlayground.Models
{
    public interface IMyTest
    {
        String GetMessage();
    }

    
    [Export(typeof(IMyTest))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MyTest1 : IMyTest
    {
        public MyTest1()
        {
            creationDate = DateTime.Now;
        }

        public string GetMessage()
        {
            return String.Format("MyTest1 created at {0}", creationDate.ToString("hh:mm:ss"));
        }

        private DateTime creationDate;
    }
}