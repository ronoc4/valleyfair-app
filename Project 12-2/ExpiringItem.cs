using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
    class ExpiringItem
    {
        private string text;
        public ExpiringItem(string text)
        {
            this.text = text;
            this.Added = DateTime.Now;
        }
        public DateTime Added { get; private set; }
        public override string ToString()
        {
            return text;
        }
    }


}
