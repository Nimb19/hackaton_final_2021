using System.IO;
using System.Text;

namespace AccentureClient.Adapter
{
    public static class FilesAdapter
    {
        internal static Encoding Encoding = Encoding.UTF8;

        public static string ReadFile(string fileName, Encoding encoding = null)
        {
            if (!File.Exists(fileName))
                return null;

            using (var sr = new StreamReader(fileName, encoding ?? Encoding))
                return sr.ReadToEnd();
        }

        public static void WriteToFile(string fileName, string text, Encoding encoding = null)
        {
            using (var sw = new StreamWriter(fileName, false, encoding ?? Encoding))
                sw.WriteLine(text);
        }
    }
}
