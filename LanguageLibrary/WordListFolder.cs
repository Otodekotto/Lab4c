using System;
using System.IO;


namespace LanguageLibrary
{
    public static class WordListFolder
    {
        public static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static string filesInDirectory = Path.Combine(filePath, "LanguagePractice");

        public static void CreateMap()
        {
            Directory.CreateDirectory(filesInDirectory);
        }

        public static string GetFilePath(string name)
        {
            return $"{filesInDirectory}\\{name}.dat";
        }
    }
}
