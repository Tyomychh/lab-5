using System;
using System.IO;

namespace DocumentWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @$"D:{Path.DirectorySeparatorChar}\НАВЧАННЯЯЯЯЯЯ{Path.DirectorySeparatorChar}papochkaVS{Path.DirectorySeparatorChar}Текстовый документ.txt";
            string line = "Мене звати Артем";
            string extension = ".txt";
            int password = Convert.ToInt32(Console.ReadLine());
            int result = password % 5;
            switch (result)
            {
                case 0:
                    {
                        DocumentWorker worker = new DocumentWorker();
                        worker.Path = path;
                        worker.OpenDocument();
                        worker.SaveDocument();
                        worker.EditDocument();
                        break;
                    }
                case 1:
                    {
                        ProDocumentWorker proworker = new ProDocumentWorker();
                        proworker.Path = path;
                        proworker.Line = line;
                        proworker.OpenDocument();
                        proworker.EditDocument();
                        proworker.SaveDocument();
                        break;
                    }
                case 2:
                    {
                        ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                        expertDocumentWorker.Path = path;
                        expertDocumentWorker.Line = line;
                        expertDocumentWorker.Extension = extension;
                        expertDocumentWorker.OpenDocument();
                        expertDocumentWorker.EditDocument();
                        expertDocumentWorker.SaveDocument();
                        if (File.Exists(path))
                        {
                            Console.WriteLine("Якщо хочете можете видалити файл натиснiть: + ");
                            string askingAboutDelet = Console.ReadLine();
                            if (askingAboutDelet.ToLower() == "yes")
                            {
                                File.Delete(path);
                            }
                            else
                            {
                                Console.WriteLine($"Файл не видалено");
                            }
                        }
                        break;
                    }
                default:
                    {
                        DocumentWorker worker = new DocumentWorker();
                        worker.Path = path;
                        worker.OpenDocument();
                        worker.SaveDocument();
                        worker.EditDocument();
                        break;
                    }
            }
        }
    }
}
