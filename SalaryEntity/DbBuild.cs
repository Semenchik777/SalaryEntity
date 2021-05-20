using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEntity
{
    public class DbBuild
    {
        
        static public void DbCraft()
        {
            using (var context = new MyDbContext())
            {
                var profession = new Profession()
                {
                    ProfessionName = "Director",
                    Name = "Наталья Краснова"

                };
                var profession2 = new Profession()
                {
                    ProfessionName = "Accountant",
                    Name = "Ольга Муравьёва"

                };
                var profession3 = new Profession()
                {
                    ProfessionName = "Manager",
                    Name = "Ольга Архипецкая"

                };
                var profession4 = new Profession()
                {
                    ProfessionName = "Security",
                    Name = "Иван Петров"
                    
                };

                context.Professions.Add(profession);
                context.Professions.Add(profession2);
                context.Professions.Add(profession3);
                context.Professions.Add(profession4);
                context.SaveChanges();

                var salary = new List<Salary>()
                {
                    new Salary() {SalaryBlack = 60000, ProfessionId = profession.Id},
                    new Salary() {SalaryBlack = 45000, ProfessionId = profession2.Id},
                    new Salary() {SalaryBlack = 40000, ProfessionId = profession3.Id},
                    new Salary() {SalaryBlack = 25000, ProfessionId = profession4.Id},
                };
                context.Salaries.AddRange(salary);
                context.SaveChanges();
            }
        }
    }
}
