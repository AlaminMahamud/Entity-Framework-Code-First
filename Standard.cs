using System.Collections.Generic;

namespace WebApplication9.Models
{
    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }

        ///
        /// Relation
        /// 
        public ICollection<Student> Students { get; set; }
    }
}