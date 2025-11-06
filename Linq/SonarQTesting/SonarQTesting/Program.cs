using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataProcessingApplication
{
    public class DataProcessor
    {
        private readonly List<string> data = new List<string>();
        private int counter = 0;
        private const int MAX_ITEMS_THRESHOLD = 100;

        public void ProcessFile(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                string[] lines = content.Split('\n');
                
                // Упрощение циклов с помощью LINQ 
                var filteredLines = lines.Where(line => 
                    !string.IsNullOrEmpty(line) && 
                    !line.Contains("error") && 
                    line.StartsWith("INFO"));
                
                foreach (var line in filteredLines)
                {
                    data.Add(line.ToUpper());
                    counter++;
                }
            }
            catch (Exception)
            {
                // Логируем исключение, но продолжаем работу приложения
                // В реальном приложении здесь должно быть логирование
                Console.WriteLine("An error occurred while processing the file.");
            }
        }

        public void PrintResults()
        {
            foreach (var item in data.Where(item => item != null))
            {
                Console.WriteLine(item);
            }
            
            if (counter > MAX_ITEMS_THRESHOLD)
            {
                Console.WriteLine("Too many items!");
            }
        }

        public void ResetData()
        {
            data.Clear();
            counter = 0;
        }
        
        // Убираем дублирование - оставляем только один метод
        public void ClearData()
        {
            ResetData(); // Делегируем выполнение существующему методу
        }
    }
}