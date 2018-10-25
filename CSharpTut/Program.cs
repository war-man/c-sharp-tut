using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Text;

namespace CSharpTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string folderName = @"\Users\joshuawaheed";
            string pathString = Path.Combine(folderName, "c-sharp-data");

            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo joshuasDir =
                new DirectoryInfo(folderName);

            Console.WriteLine(joshuasDir.FullName);
            Console.WriteLine(joshuasDir.Name);
            Console.WriteLine(joshuasDir.Parent);
            Console.WriteLine(joshuasDir.Attributes);
            Console.WriteLine(joshuasDir.CreationTime);

            Directory.CreateDirectory(pathString);
            // Directory.Delete(pathString);

            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = Path.Combine(pathString, "testfile1.txt");

            File.WriteAllLines(textFilePath, customers);

            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            DirectoryInfo myDataDir = new DirectoryInfo(pathString);

            FileInfo[] txtFiles =
                myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Matches : {0}", txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }

            string textFilePath2 = Path.Combine(pathString, "testfile2.txt");

            FileStream fs = File.Open(textFilePath2, FileMode.Create);

            string randString = "This is a random string";

            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);

            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            fs.Close();

            string textFilePath3 = Path.Combine(pathString, "testfile3.txt");

            StreamWriter sw = File.CreateText(textFilePath3);

            sw.Write("This is a random ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");

            sw.Close();

            StreamReader sr = File.OpenText(textFilePath3);

            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String : {0}", sr.ReadLine());

            Console.WriteLine("Everything : {0}", sr.ReadToEnd());

            sr.Close();

            string textFilePath4 = Path.Combine(pathString, "testfile4.dat");

            FileInfo datFile = new FileInfo(textFilePath4);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;

            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());

            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();
        }
    }
}