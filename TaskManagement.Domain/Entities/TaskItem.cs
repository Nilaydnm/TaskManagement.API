using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Guid AssignedUserId { get; set; }
        public User AssignedUser { get; set; }

        public Guid TeamId { get; set; }
        public Team Team { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
