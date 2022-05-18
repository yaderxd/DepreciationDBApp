using DepreciationDBApp.Domain.Entities;
using DepreciationDBApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Infrastructure.Repositories
{
    public class AssetEmployyeREpository : IAssetEmployeeRepository
    {
        public IDepreciationDbContext depreciationDbContext;
        public void Create(AssetEmployee t)
        {
            depreciationDbContext.Assets.Add(t);
            depreciationDbContext.SaveChanges();
        }

        public bool Delete(AssetEmployee t)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> FindByAssetId(int assetId)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> FindByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<AssetEmployee> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(AssetEmployee t)
        {
            throw new NotImplementedException();
        }

        public int xd(AssetEmployee t)
        {
            throw new NotImplementedException();
        }
        public void validateAssetEmployye(Employee employee,Asset asset)
        {
            if (employee is null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            if (asset is null)
            {
                throw new ArgumentNullException(nameof(asset));
            }
        }
    }
}
