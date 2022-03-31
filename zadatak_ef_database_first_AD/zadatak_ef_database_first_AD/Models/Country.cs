using System;
using System.Collections.Generic;

namespace zadatak_ef_database_first_AD.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? Simbol { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
