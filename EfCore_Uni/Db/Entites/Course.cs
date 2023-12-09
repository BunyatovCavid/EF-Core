using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Uni.Db.Entites
{
    internal class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }


        public List<StudentsGrade> StudentsGrade { get; set; }
    }
}
