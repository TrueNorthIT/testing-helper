using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace TrueNorth.Testing.Helper
{
    public sealed class MyFactAttribute : Xunit.FactAttribute
    {
        public MyFactAttribute([CallerMemberName] string memberName = null)
        {
            DisplayName = memberName;
        }
    }
}
