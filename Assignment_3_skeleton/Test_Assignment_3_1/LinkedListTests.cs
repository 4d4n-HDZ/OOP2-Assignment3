using Assignment_3;
using NUnit.Framework;

namespace Test_Assignment_3_1
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void EmptyList()
        {
            var l = new SLL();
            Assert.That(l.IsEmpty(), Is.True);
            Assert.That(l.Size(), Is.EqualTo(0));
        }
        [Test]
        public void Prepend()
        {
            var l = new SLL();
            l.Prepend("x");
            Assert.That(l.Size(), Is.EqualTo(1));
            Assert.That(l.Retrieve(0), Is.EqualTo("x"));
        }
        [Test]
        public void Append()
        {
            var l = new SLL();
            l.Append(1);
            l.Append(2);
            Assert.That(l.Size(), Is.EqualTo(2));
            Assert.That(l.Retrieve(1), Is.EqualTo(2));
        }
        [Test]
        public void Insert()
        {
            var l = new SLL();
            l.Append("a");
            l.Append("c");
            l.Insert("b", 1);
            Assert.That(l.Retrieve(1), Is.EqualTo("b"));
        }
        [Test]
        public void Replace()
        {
            var l = new SLL();
            l.Append("a");
            l.Replace("z", 0);
            Assert.That(l.Retrieve(0), Is.EqualTo("z"));
        }
        [Test]
        public void DeleteFirst()
        {
            var l = new SLL();
            l.Append(1);
            l.Append(2);
            l.Delete(0);
            Assert.That(l.Retrieve(0), Is.EqualTo(2));
        }
        [Test]
        public void DeleteLast()
        {
            var l = new SLL();
            l.Append(1);
            l.Append(2);
            l.Delete(1);
            Assert.That(l.Retrieve(0), Is.EqualTo(1));
        }
        [Test]
        public void DeleteMiddle()
        {
            var l = new SLL();
            l.Append("a");
            l.Append("b");
            l.Append("c");
            l.Delete(1);
            Assert.That(l.Retrieve(1), Is.EqualTo("c"));
        }
        [Test]
        public void IndexOfAndContains()
        {
            var l = new SLL();
            l.Append("x");
            l.Append("y");
            Assert.That(l.IndexOf("y"), Is.EqualTo(1));
            Assert.That(l.Contains("z"), Is.False);
        }
        [Test]
        public void Clear()
        {
            var l = new SLL();
            l.Append(1);
            l.Clear();
            Assert.That(l.IsEmpty(), Is.True);
        }
        [Test]
        public void ReverseEmpty()
        {
            var l = new SLL();
            l.Reverse();
            Assert.That(l.Size(), Is.EqualTo(0));
        }
        [Test]
        public void ReverseOne()
        {
            var l = new SLL();
            l.Append(1);
            l.Reverse();
            Assert.That(l.Retrieve(0), Is.EqualTo(1));
        }
        [Test]
        public void ReverseMany()
        {
            var l = new SLL();
            l.Append("a");
            l.Append("b");
            l.Append("c");
            l.Reverse();
            Assert.That(l.Retrieve(0), Is.EqualTo("c"));
            Assert.That(l.Retrieve(2), Is.EqualTo("a"));
        }
        [Test]
        public void ReverseThenAppend()
        {
            var l = new SLL();
            l.Append(1);
            l.Append(2);
            l.Reverse();
            l.Append(3);
            Assert.That(l.Retrieve(2), Is.EqualTo(3));
        }
        [Test]
        public void ReverseThenPrepend()
        {
            var l = new SLL();
            l.Append(1);
            l.Append(2);
            l.Reverse();
            l.Prepend(0);
            Assert.That(l.Retrieve(0), Is.EqualTo(0));
        }
    }
}
