using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delege_3
{
    internal class TextFileProceser
    {
        private string _path;

        public TextFileProceser(string path)
        { 
            _path = path;
        }

        public void GenerateList(int count)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            for(int i  = 0; i < count; i++)
            {
                list.Add(random.Next(0 , 100));
            }

            WriteToFile(list);
        }

        public string ReadDataLine()
        {
            using (StreamReader sr = new StreamReader(_path))
            { 
                return sr.ReadLine();
            }
        }

        private void WriteToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(path: _path, append: true))
            { 
                sw.WriteLine(text);
            }
        }

        private void WriteToFile(List<int> array)
        {
            using (StreamWriter sw = new StreamWriter(path: _path, append: true))
            {
                foreach (int item in array)
                {
                    sw.Write(item + " ");
                }

                sw.Write('\n');
            }
        }
    }
}
