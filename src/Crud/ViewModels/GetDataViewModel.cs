using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Models;

namespace Crud.ViewModels
{
    public class GetDataViewModel
    {
        public IEnumerable<Product> List { get; set; }
        public int Total { get; set; }
        public DateTime Time { get; set; }
    }
}
