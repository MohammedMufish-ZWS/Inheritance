using System.Collections.Generic;

namespace CSharp
{
    internal class StudentDBContext
    {
        public object Database { get; internal set; }
        public IEnumerable<object> Students { get; internal set; }
    }
}