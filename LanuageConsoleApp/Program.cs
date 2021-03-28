using System;
using System.Collections.Generic;
using System.Linq;
using LanguageLibrary;

namespace LanguageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            if (args.Count() == 0)
            {
                PrintUsage();
            }
            else if (args[0] == "-lists")
            {
                foreach (string s in WordList.GetLists())
                {
                    Console.WriteLine(s);
                }
            }
            else if (args[0] == "-practice")
            {
                throw new NotImplementedException();
            }
            else if (args[0] == "-remove")
            {
                if (args.Count() < 2)
                {
                    Console.WriteLine("A list name must be specified in order to remove words.");
                }
                else
                {
                    var words = WordList.LoadList(args[1]);

                    if (words == null)
                    {
                        Console.WriteLine($"There is no wordlist named '{args[1]}'");
                    }
                    else
                    {
                        if (args.Count() >= 4)
                        {
                            // Remove word from wordlist, then re-save list

                            words.Save();

                        }
                        else
                        {
                            Console.WriteLine($"A list name, a language, and at least one word to remove must be specified.");
                        }
                    }
                }
            }
            else if (args[0] == "-words")
            {
                if (args.Count() < 2)
                {
                    Console.WriteLine("A list name must be specified in order to display words.");
                }
                else
                {
                    var words = WordList.LoadList(args[1]);

                    if (words == null)
                    {
                        Console.WriteLine($"There is no wordlist named '{args[1]}'");
                    }
                    else
                    {
                        if (args.Count() == 3)
                        {
                            throw new NotImplementedException();
                        }
                        else
                        {
                            PrintList(0, words);
                        }
                    }
                }
            }
            else if (args[0] == "-count")
            {
                if (args.Count() < 2)
                {
                    Console.WriteLine("A list name must be specified in order to count words.");
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else if (args[0] == "-add")
            {
                if (args.Count() < 2)
                {
                    Console.WriteLine("A list name must be specified in order to add words.");
                }
                else
                {
                    var words = WordList.LoadList(args[1]);

                    if (words == null)
                    {
                        Console.WriteLine($"There is no wordlist named '{args[1]}'");
                    }
                    else
                    {
                        AddWords(words);
                    }
                }
            }
            else if (args[0] == "-new")
            {
                if (args.Count() < 4)
                {
                    Console.WriteLine("A list must have a name and at least two languages.");
                }
                else
                {
                    string[] languages = new string[args.Count() - 2];

                    for (int i = 0; i < languages.Count(); i++)
                    {
                        languages[i] = args[i + 2];
                    }

                    WordList words = new WordList(args[1], languages);

                    AddWords(words);
                }
            }
            else
            {
                PrintUsage();
            }
            Console.ReadLine();
            Console.WriteLine();
        }

        static void PrintUsage()
        {
            Console.WriteLine("Use any of the following parameters:");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2> .. <langauge n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
            Console.WriteLine("-words <listname> <sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }

        static WordList NewWordList()
        {
            return new WordList("myList", "English", "Swedish");
        }

        static void AddWords(WordList words)
        {
            Console.WriteLine("Press enter (empty line) to stop input of new words.");
            Console.WriteLine();

            bool abort = false;
            string[] translations = new string[words.Languages.Count()];
            int wordCount = 0;

            while (!abort)
            {
                for (int i = 0; i < words.Languages.Count(); i++)
                {
                    if (i == 0)
                    {
                        Console.Write($"Add new word ({words.Languages[0]}): ");
                    }
                    else
                    {
                        Console.Write($"Add {words.Languages[i]} translation: ");
                    }

                    translations[i] = Console.ReadLine();

                    if (translations[i] == "")
                    {
                        abort = true;
                        break;
                    }
                }

                if (abort)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{wordCount} word{(wordCount == 1 ? "" : "s")} was added to list '{words.Name}'.");
                }
                else
                {
                    words.Add(translations);
                    wordCount++;
                }
            }

            words.Save();
        }

        static void Practice(WordList words)
        {
            int wordCount = 0;
            int correctWords = 0;

            while (true)
            {
                // Do some magic

                wordCount++;
            }

            Console.WriteLine();
            Console.WriteLine($"You practiced {wordCount} word{(wordCount == 1 ? "" : "s")}.");
            Console.WriteLine($"{(int)((float)correctWords / (float)wordCount * 100)}% of your answers where correct!");
        }
        static void PrintList(int sortByTranslation, WordList words)
        {
            foreach (string s in words.Languages)
            {
                Console.Write(s.ToUpper().PadRight(20));
            }
            Console.WriteLine();

            words.List(sortByTranslation, trans =>
            {
                foreach (string s in trans)
                {
                    Console.Write(s.ToLower().PadRight(20));
                }
                Console.WriteLine();
            });
        }
    }
}
