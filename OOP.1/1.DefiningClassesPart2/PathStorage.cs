using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _1.DefiningClassesPart2
{
    [Serializable]
    static class PathStorage
    {
        public static void SavePath(Path path, string filePath, string fileName)
        {
            string fullPath = filePath + fileName;

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            formatter.Serialize(stream, path);
        }

        public static Path LoadPath(string location)
        {
            Path path = new Path();

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(location, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            path = (Path)formatter.Deserialize(stream);

            return path;
        }
    }
}