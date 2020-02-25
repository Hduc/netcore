using System.Collections.Generic;
using System.Linq;
using core.Models.Repository;

namespace core.Models.DataManager
{
    public class EmployeeManager : IRepository<Employee>
    {
        readonly DBContext _DBContext;

        public EmployeeManager(DBContext context)
        {
            _DBContext = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _DBContext.Employees.ToList();
        }

        public Employee Get(long id)
        {
            return _DBContext.Employees
                  .FirstOrDefault(e => e.EmployeeId == id);
        }

        public void Add(Employee entity)
        {
            _DBContext.Employees.Add(entity);
            _DBContext.SaveChanges();
        }

        public void Update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.PhoneNumber = entity.PhoneNumber;

            _DBContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _DBContext.Employees.Remove(employee);
            _DBContext.SaveChanges();
        }
    }
}