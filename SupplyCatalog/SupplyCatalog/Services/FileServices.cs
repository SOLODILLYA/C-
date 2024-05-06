using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SupplyCatalog.Services
{
    public class FileService
    {
        public string ReadFileContent(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public void WriteFileContent(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}
