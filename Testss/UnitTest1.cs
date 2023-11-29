using UniqueTry;

namespace Testss
{
    public class UnitTest1
    {
        [Fact]
        public void SimplePass()
        {
            var u = new UniqueNums();
            List<int> list = new List<int> { 1,2,3,4 ,4};
            HashSet<int> actualHashSet=u.filter(list);
            HashSet<int> expectedHashSet = new HashSet<int> { 1, 2, 3, 4 };
            Assert.Equal(expectedHashSet, actualHashSet);
        }
        [Fact]
        public void SimpleFail()
        {
            var u = new UniqueNums();
            List<int> list = new List<int> { 1, 2, 3 };
            HashSet<int> actualHashSet = u.filter(list);
            HashSet<int> expectedHashSet = new HashSet<int> { 1, 2, 3, 4 } ;
            Assert.Equal(expectedHashSet, actualHashSet);
        }
        [Fact]
        public void Test()
        {
            var u = new UniqueNums();
            List<int> list = new List<int> { 1, 2, 3, 4, 4,4,4,4,4,4 };
            HashSet<int> actualHashSet = u.filter(list);
            HashSet<int> expectedHashSet = new HashSet<int> { 1, 2, 3, 4 };
            Assert.Equal(expectedHashSet, actualHashSet);
        }
        [Fact]
        public void Test2()
        {
            var u = new UniqueNums();
            List<int> list = new List<int> {0,0,0,0,0,0, 1, 2, 3, 4, 4, 4, 4, 4, 4, 4 };
            HashSet<int> actualHashSet = u.filter(list);
            HashSet<int> expectedHashSet = new HashSet<int> { 0,1, 2, 3, 4 };
            Assert.Equal(expectedHashSet, actualHashSet);
        }
        [Fact]
        public void TestEmptyList()
        {
            var u = new UniqueNums();
            List<int> list = new List<int> ();
            HashSet<int> actualHashSet = u.filter(list);
            HashSet<int> expectedHashSet = new HashSet<int> ();
            Assert.Equal(expectedHashSet, actualHashSet);
        }


        [Fact]
        public void TestWithNoDuplicatesPass()
        {
            var u = new UniqueNums();
            List<int> list = new List<int> {1,2,3 };
            HashSet<int> actualHashSet = u.filter(list);
            HashSet<int> expectedHashSet = new HashSet<int> { 1,2,3 };
            Assert.Equal(expectedHashSet, actualHashSet);
        }
        [Fact]
        public void TestWithNoDuplicatesFail()
        {
            var u = new UniqueNums();
            List<int> list = new List<int> { 1, 2, 3 };
            HashSet<int> actualHashSet = u.filter(list);
            HashSet<int> expectedHashSet = new HashSet<int> { 1, 2 };
            Assert.Equal(expectedHashSet, actualHashSet);
        }
    }
}