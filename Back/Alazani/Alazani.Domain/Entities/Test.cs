using Alazani.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alazani.Domain.Entities
{
    public class Test : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
