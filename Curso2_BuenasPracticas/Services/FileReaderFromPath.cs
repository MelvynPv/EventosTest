using Curso2_BuenasPracticas.Services.Interfaces;
using System;
using System.IO;

namespace Curso2_BuenasPracticas.Services
{
    public class FileReaderFromPath : IFileReaderEvent
    {
        static readonly string _fileUrlDefault = Path.GetFullPath("eventos.txt");

        public string ReadFile(string filePath = null)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = _fileUrlDefault;
            }

            if (!File.Exists(filePath))
            {
                return null;
            }

            return File.ReadAllText(filePath);
        }
    }
}
