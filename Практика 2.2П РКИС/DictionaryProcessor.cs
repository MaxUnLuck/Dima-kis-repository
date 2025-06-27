using System;
using System.Collections.Generic;

namespace SimpleDictionaryApp
{
    public class DictionaryProcessor
    {
        public Dictionary<string, string> Dictionary { get; private set; } = new Dictionary<string, string>();

        public List<string> ParseInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentException("Список не может быть пустым");

            List<string> result = new List<string>();
            string[] items = input.Split(new char[] { ',', ';', ' ' });

            foreach (string item in items)
            {
                result.Add(item.Trim());
            }
            return result;
        }
        public void FillDictionary(List<string> keys, List<string> values)
        {
            if (keys == null || values == null)
                throw new ArgumentNullException("Списки не могут быть пустыми");

            if (keys.Count != values.Count)
                throw new ArgumentException("Количество ключей и значений должно быть одинаковым");

            Dictionary.Clear();
            for (int i = 0; i < keys.Count; i++)
            {
                if (Dictionary.ContainsKey(keys[i]))
                    throw new ArgumentException($"Ключ '{keys[i]}' уже существует");
                Dictionary.Add(keys[i], values[i]);
            }
        }
        public Dictionary<string, int> FindDuplicates()
        {
            Dictionary<string, int> valueCounts = new Dictionary<string, int>();
            foreach (string value in Dictionary.Values)
            {
                if (valueCounts.ContainsKey(value))
                    valueCounts[value]++;
                else
                    valueCounts.Add(value, 1);
            }
            Dictionary<string, int> duplicates = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> pair in valueCounts)
            {
                if (pair.Value > 1)
                    duplicates.Add(pair.Key, pair.Value);
            }

            return duplicates;
        }
    }
}