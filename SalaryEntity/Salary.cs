using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEntity
{
    public class Salary
    {
        public int Id { get; set; }
        public int SalaryBlack { get; set; }
        public int ProfessionId { get; set; }
        public virtual Profession Profession { get; set; }
                       
    }
}
