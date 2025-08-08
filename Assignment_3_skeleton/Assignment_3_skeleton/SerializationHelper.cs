using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Assignment_3
{
    public static class SerializationHelper
    {
        public static void SerializeUsers(List<User> users, string path)
        {
            if (users == null) throw new ArgumentNullException(nameof(users));
            if (path == null) throw new ArgumentNullException(nameof(path));
            using (var fs = new FileStream(path, FileMode.Create))
            {
                var f = new BinaryFormatter();
                f.Serialize(fs, users);
            }
        }
        public static List<User> DeserializeUsers(string path)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));
            using (var fs = new FileStream(path, FileMode.Open))
            {
                var f = new BinaryFormatter();
                return (List<User>)f.Deserialize(fs);
            }
        }
    }
}
