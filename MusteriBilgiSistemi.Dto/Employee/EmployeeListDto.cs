using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgiSistemi.Dto.Employee
{
    public class EmployeeListDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? Tarih { get; set; }
        public bool Onay { get; set; }
    }
}
