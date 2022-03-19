using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using BusinessLayer.ValidationRules;

namespace MehmetDevBlog.Models
{

    public class CitiesExample
    {
        public static Writer Writer { get; set; }
       
        public int cityId { get; set; }
        public string cityName { get; set; }

        public static IEnumerable<CitiesExample> exampleCities = new List<CitiesExample> {
            new CitiesExample {
                cityId = 1,
                cityName = "Hatay"
                },
            new CitiesExample {
                cityId = 2,
                cityName = "Mersin"
                },
            new CitiesExample {
                cityId = 3,
                cityName = "Krakow"
                },
            new CitiesExample {
                cityId = 4,
                cityName = "Amsterdam"
                },
            new CitiesExample {
                cityId = 5,
                cityName = "Berlin"
                }

    };
    }

}
