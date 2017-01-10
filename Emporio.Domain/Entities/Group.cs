using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emporio.Domain.Entities
{
    public class Group
    {
        public Group()
        {
            Devices = new List<Device>();
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Device> Devices { get; }
        public bool SendFeatureEmails { get; set; }
    }
}
