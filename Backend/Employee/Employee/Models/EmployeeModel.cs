using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}
}
