using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsTool.Web.Models
{
    public class YearFilter
    {
        public int Year { get; set; }
        public YearFilter()
        {
            this.Year = DateTime.Now.Year;
        }
    }
}
