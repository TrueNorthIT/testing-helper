using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TrueNorth.Testing.Helper
{
    public class MyTheoryAttribute :  Xunit.TheoryAttribute
    {
        public MyTheoryAttribute([CallerMemberName] string memberName = null)
        {
            DisplayName = memberName;
        }
    }
}
