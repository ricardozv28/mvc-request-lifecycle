using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCPresentation.Models
{
    [ModelBinder(BinderType = typeof(MovieBinder))]
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
    }
}
