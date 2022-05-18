using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Infrastructure.Repositories
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        public IDepreciationDbContext depreciationDbContext;
        public void Create(Employee t)
        {
            try
            {
                depreciationDbContext.Employees.Add(t);
                depreciationDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(Employee t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentException("El Objeto Asset no puede ser null");
                }
                Employee employee = FIndByDni(t.Dni);
                if (employee == null)
                {
                    throw new Exception($"El Objeto con Id {t.Dni} no existe");
                }
                depreciationDbContext.Employees.Remove(employee);
                int result = depreciationDbContext.SaveChanges();
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Employee FIndByDni(string dni)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dni))
                {
                    throw new ArgumentException($"");
                }
                return depreciationDbContext.Employees.FirstOrDefault(x => x.Dni.Equals(dni));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Employee FindByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Employee> FindByLastNames(string lastnames)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lastnames))
                {
                    throw new ArgumentException($"");
                }
                return depreciationDbContext.Employees.Where(x => x.Lastnames.Equals(lastnames, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Employee> GetAll()
        {
            try
            {
                return depreciationDbContext.Employees.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Update(Employee t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException($"El Objeto no se puede ser null");
                }
                Employee employee = FIndByDni(t.Dni);
                if (employee == null)
                {
                    throw new Exception($"El objeto asset con id {t.Dni} no existe");
                }
                employee.Names = t.Names;
                employee.Lastnames = t.Lastnames;
                employee.Adress = t.Adress;
                //asset.AmountResidual = t.AmountResidual;
                employee.Phone = t.Phone;
                employee.Email = t.Email;
                employee.Status = t.Status;
                //asset.Code = t.Code;

                depreciationDbContext.Employees.Update(employee);
                return depreciationDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public int xd(Employee t)
        {
            throw new NotImplementedException();
        }
        public void validateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException($"");
            }
            if (string.IsNullOrWhiteSpace(employee.Email))
            {
                throw new Exception($"");
            }
            if (string.IsNullOrWhiteSpace(employee.Names))
            {
                throw new Exception($"");
            }
        }
    }
}
