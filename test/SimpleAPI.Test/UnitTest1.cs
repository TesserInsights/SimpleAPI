using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
       
    public class UnitTest1
    {
        
        ValuesController Controllers=new ValuesController();

        [Fact]
        public void GetReturnMyName(){

            var returnvalue=Controllers.Get(1);
            Assert.Equal("A Murugiah",returnvalue.Value);
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
