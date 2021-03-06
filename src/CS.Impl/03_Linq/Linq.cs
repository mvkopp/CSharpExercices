﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS.Impl._03_Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {
            var filter = from word in strings
                         where (word.Substring(0,1).Equals(startCharacter)) && (word.Substring(word.Length-1,1).Equals(endCharacter))
                         select word;

            return filter;
        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
            var filter = from nb in numbers
                         where nb > limit
                         select nb;
            return filter;
        }

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
            var filter = (from nb in numbers
                         orderby nb descending
                         select nb).Take(limit);

            return filter;
        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            var filter = files.Select(file => file.Substring(file.IndexOf(".")+1).ToLower())
                .GroupBy(grp => grp, (ext, nb) => new { Extension = ext, Nombre = nb.Count() });

            return filter.ToDictionary(d => d.Extension, d=> d.Nombre);
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            throw new NotImplementedException();
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
