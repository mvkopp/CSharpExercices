using System;
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
            var filter = from nb in numbers
                         where nb > limit
                         orderby nb descending
                         select nb;

            return filter;
        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            //var filter = from file in files
            //             group file by file.Substring(file.IndexOf(".")) into i
            //             select new { Key = file, Value = i.Count() };

            var filter = files.Select(file => file.Substring(file.IndexOf(".")))
                .GroupBy(grp => grp, (ext, nb) => new { Extension = ext, Nombre = ext.Count() });

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
