using System;
using Xunit;
using TrueNorth.Testing.Helper;

namespace TrueNorth.Testing.Tests
{
    public class ExtenionTests
    {
        [MyFact]
        public void JSONTests()
        {
            var a = new {surname = "Smith", firstname = "Fred"};

            var result = a.ToJsonString();

            Assert.Equal("{\r\n  \"surname\": \"Smith\",\r\n  \"firstname\": \"Fred\"\r\n}", result);
        }
    }
}
