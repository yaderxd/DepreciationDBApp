using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Applications.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        IEmployeeRepository employeeRepository;
        IAssetEmployeeRepository assetEmployeeRepository;
        public EmployeeService(IEmployeeRepository assetRepository)
        {
            this.employeeRepository = assetRepository;
        }
        public void Create(Employee t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El Asset no puede ser null.");


            }

            employeeRepository.Create(t);
        }
        public bool Delete(Employee t)
        {
            throw new NotImplementedException();
        }
        public Employee FIndByDni(string dni)
        {
            throw new NotImplementedException();
        }
        public Employee FindByEmail(string email)
        {
            throw new NotImplementedException();

        }
        public IEnumerable<Employee> FindByLastName(string lastname)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Employee> FindByLastNames(string lastnames)
        {
            throw new NotImplementedException();
        }
        public List<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }
        public bool SetAssetsToEmployee(Employee employee, List<Asset> asset)
        {
            throw new NotImplementedException();
        }
        public bool SetAssetToEmployee(Employee employee, Asset asset, DateTime efectiveDate)
        {
            try
            {
                AssetEmployee AssetEmployee = new AssetEmployee()
                {
                    AssetId = asset.Id,
                    EmployeeId = employee.Id,
                    Date = efectiveDate,
                    IsActive = true

                };
                assetEmployeeRepository.Create(AssetEmployee);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Update(Employee t)
        {
            throw new NotImplementedException();
        }
        public int xd(Employee t)
        {
            throw new NotImplementedException();
        }
    }
}

