using System.Collections.Generic;
using System.Linq;

namespace ClashofClans.Files.CsvReader
{
    public class Column
    {
        private readonly List<string> _values;

        public Column()
        {
            this._values = new List<string>();
        }

        public static int GetArraySize(int offset, int nOffset)
        {
            return nOffset - offset;
        }

        public void Add(string value)
        {
            if (value == null)
            {
                this._values.Add(this._values.Count > 0 ? this._values.Last() : string.Empty);
            }
            else
            {
                this._values.Add(value);
            }
        }

        public string Get(int row)
        {
            return this._values[row];
        }

        public int GetSize()
        {
            return this._values.Count;
        }
    }
}
