using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Features.Brands.Commands.Create
{
    public class CreatedBrandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
