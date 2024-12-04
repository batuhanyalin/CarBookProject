using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerMail { get; set; }
        public List<RentACarProcess> RentACarProcesses { get; set; }
    }
}
