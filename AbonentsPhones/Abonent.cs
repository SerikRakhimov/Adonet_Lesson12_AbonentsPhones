using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonentsPhones
{
    public class Abonent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Fio { get; set; }
        public string Number { get; set; }
        public int? CitiesId { get; set; }
        public City City { get; set; }
    }
}
