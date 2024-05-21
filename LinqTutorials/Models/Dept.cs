using System.Collections.Generic;

namespace LinqTutorials.Models
{
    public class Dept
    {
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }
        public List<Emp> Emps { get;  set; }
    }
}