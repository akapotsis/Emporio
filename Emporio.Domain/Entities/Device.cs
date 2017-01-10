using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.Domain.Entities
{
    public class Device
    {
        public Device()
        {

        }
        public string Name { get; set; }

        public DateTime InstalledDate { get; set; }
        public DateTime LastUsedDate { get; set; }
        public bool isActive { get; set; }
    }
}
