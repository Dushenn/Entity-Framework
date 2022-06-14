using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVezba
{
    public class WorkerProject
    {
        [Key, Column(Order = 1)]
        [ForeignKey("Worker")]
        public string WorkerId { get; set; }
        public virtual Worker Worker { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public int WorkHours { get; set; }

    }
}
