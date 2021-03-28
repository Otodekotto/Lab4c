using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LanguageLibrary
{
    public class WordList
    {
        #region Properties
        public string[] Languages { get; }  // The names of the languages, read from the first line of the data file
        public string Name { get; } // The name of the language file we are currently using
        #endregion

        #region Fields
        private List<Word> words = new List<Word>();    // The list of words and their translations. An element of this array might be "flower;blomma;"
        private Random rnd = new Random();
        #endregion

        #region Constructors
        public WordList(string name, params string[] languages)
        {
            if (languages.Length < 2)
            {
                throw new ArgumentException("A Wordlist must have at least two languages");
            }

            Name = name;
            Languages = languages;
        }
        #endregion

        public static string[] GetLists() 
        {
            WordListFolder.CreateMap();
            string[] filePath = Directory.GetFiles(WordListFolder.filesInDirectory).Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
            return filePath;
        }

        public static WordList LoadList(string name) 
        {
            WordListFolder.CreateMap();
            if (File.Exists(WordListFolder.GetFilePath(name)))
            {
                using StreamReader streamReader = new StreamReader(WordListFolder.GetFilePath(name));
                string[] languages = streamReader.ReadLine().TrimEnd(';').Split(';');
                WordList wordList = new WordList(name, languages);
                while (!streamReader.EndOfStream)
                {
                    string[] translations = streamReader.ReadLine().TrimEnd(';').Split(';');
                    wordList.Add(translations);
                }
                return wordList;
            }
            return null;
        }

        public void Save()
        {
            LoadList(Name);
            string filePath = WordListFolder.GetFilePath(Name);
            using var fileStream = File.Create(WordListFolder.GetFilePath(Name));
            fileStream.Close();
            foreach (var language in Languages)
            {
                File.AppendAllText(filePath, language + ";");
            }
            foreach (var words in words)
            {
                File.AppendAllText(filePath, "\n");

                for (int i = 0; i < Languages.Length; i++)
                {
                    File.AppendAllText(filePath, words.Translations[i] + ";");
                }
            }
        }

        public void Add(params string[] translations) 
        {
            if (translations.Length == Languages.Length)
            {
                words.Add(new Word(translations));
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool Remove(int translation, string word) //
        {
            bool wasRemoved = false;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations[translation] == word)
                {
                    words.RemoveAt(i);
                    wasRemoved = true;
                    return wasRemoved;
                }
            }
            return wasRemoved;
        }
        public int Count() 
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            Word[] sorting = words.OrderBy(x => x.Translations[sortByTranslation]).ToArray();
            foreach (var translation in sorting)
            {
                showTranslations(translation.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            LoadList(Name);
            Random random = new Random();
            int randomWord = random.Next(words.Count);
            int fromLanguage = random.Next(Languages.Length);
            int toLanguage = random.Next(Languages.Length);

            while (fromLanguage == toLanguage)
            {
                toLanguage = random.Next(Languages.Length);
            }

            Word randomLanguageWords = new Word(fromLanguage, toLanguage, words[randomWord].Translations);

            return randomLanguageWords;
        }
    }
}
