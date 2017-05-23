using System.Collections;
using System.Collections.Generic;

namespace ExampleCodeLibraryTests.TestLists
{
    internal abstract class TestListBase : IEnumerable<object[]>
    {
        private List<object[]> testlist = new List<object[]>();
        protected List<object[]> Testlist { get => testlist; }

        public IEnumerator<object[]> GetEnumerator()
        {
            return Testlist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
