using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEntity
{
    public class Profession
    {
        public int Id { get; set; }
        public string ProfessionName { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Salary> Salary {get ; set; }
    }
}
