using MamasChecker.Abstract;

namespace ScubaChecker
{
    public class TestCase : ITestCase
    {
        public string TestContent { get; set; }
        public int Id { get; set; }

        public TestCase(string content, int id)
        {
            TestContent = content;
            Id = id;
        }
        public bool Run()
        {
            return true;
        }
        public TestCase()
        {

        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
    }
}