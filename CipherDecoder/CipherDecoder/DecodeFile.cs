using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherDecoder
{
    public class DecodeFile
    {
        public static string Path { get; } = AppDomain.CurrentDomain.BaseDirectory + @"\LogDecoded\";
        public static string FilePath { get; } = Path + "Logfile.txt";

        public void TranslateFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(FilePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string decryptedString = Cipher.Decrypt(lines[i]);
                    Console.WriteLine(decryptedString);
                    sw.WriteLine(decryptedString);
                }
                sw.Flush();
                sw.Close();

                Console.WriteLine("Created file at: " + FilePath);
            }
            catch
            {

                throw;
            }

        }
    }
}
