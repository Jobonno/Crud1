using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.ViewModels
{
    public class GetDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public TypeEnum Type { get; set; }
    }
}
