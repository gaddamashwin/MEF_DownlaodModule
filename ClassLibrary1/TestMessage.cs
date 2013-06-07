using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Export(typeof(ITestMessage))]
    public class TestMessage : ITestMessage
    {
        public string HelloWorld()
        {
            return "Hello World!";
            
        }
    }

    public interface ITestMessage
    {
        string HelloWorld();
    }
}
