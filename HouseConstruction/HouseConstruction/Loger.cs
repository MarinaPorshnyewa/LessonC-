using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HouseConstruction
{
    public class Loger
    {
        string _path;

        public Loger(string path)
        {
            _path = path;
        }
        public void WriteToLog(string message)
        {
            using (FileStream fs = new FileStream(_path, FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(message);
                fs.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан");

            }
        }
    }
}
