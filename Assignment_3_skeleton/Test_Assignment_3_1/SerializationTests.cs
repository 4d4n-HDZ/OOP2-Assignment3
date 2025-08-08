using Assignment_3;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Test_Assignment_3_1
{
    [TestFixture]
    public class SerializationTests
    {
        private string f;
        [SetUp]
        public void SetUp() => f = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        [TearDown]
        public void TearDown() { if (File.Exists(f)) File.Delete(f); }
        [Test]
        public void SerializeAndDeserialize()
        {
            var users = new List<User> { new User("A"), new User("B"), new User("C") };
            SerializationHelper.SerializeUsers(users, f);
            var loaded = SerializationHelper.DeserializeUsers(f);
            Assert.That(loaded.Count, Is.EqualTo(users.Count));
            for (int i = 0; i < users.Count; i++)
                Assert.That(loaded[i], Is.EqualTo(users[i]));
        }
    }
}
