using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApplication.Models
{
    public class Employee
    {
        //Primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }

        // Scaler Property
        public DateTime EmployeeAddedDate { get; set; }


        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("JobId")]
        public int JobId { get; set; }
        [ForeignKey("MgrId")]
        public int MgrId { get; set; }

        public Job Job { get; set; }
        public Manager Manager { get; set; }
       



    }

}
