using Employee.Models;

namespace Employee.Services
{
    public class EmployeeService
    {

        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(EmployeeModel entity)
        {
            _context.employee.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<EmployeeModel> GetEmployee()
        {
            return _context.employee.ToList();
        }
    }
}
