using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SkillInfo
    {

        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public int CategoryID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

    }
}
