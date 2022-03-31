using System;
using System.Collections.Generic;

namespace zadatak_ef_database_first_AD.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public string? CitySimbol { get; set; }
        public int? CountryId { get; set; }

        public virtual Country? Country { get; set; }
    }
}
