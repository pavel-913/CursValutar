using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursValutar
{
    public class History
    {
        public string Valuta { get; set; }

        public decimal M1 { get; set; }
        public decimal M2 { get; set; }

        public decimal M3 { get; set; }

        public decimal M4 { get; set; }

        public decimal M5 { get; set; }

        public decimal M6 { get; set; }
        public decimal M7 { get; set; }

        public decimal M8 { get; set; }

        public decimal M9 { get; set; }

        public decimal M10 { get; set; }

        public decimal M11 { get; set; }
        public decimal M12 { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
