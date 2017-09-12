using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NCrunchDistribFodyBug
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void should_do_this()
        {
            var c = new Class2();
        }
    }

    [ToString]
    class Class2
    {
        public int i { get; set; }
    }
}
