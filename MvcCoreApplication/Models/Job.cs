using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApplication.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public DateTime JobAddedDate { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
