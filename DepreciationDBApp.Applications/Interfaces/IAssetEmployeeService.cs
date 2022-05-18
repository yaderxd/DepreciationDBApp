using DepreciationDBApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Applications.Interfaces
{
    public interface IAssetEmployeeService : IService<AssetEmployee>
    {
        List<AssetEmployee> FindByEmployeeId(int EmployeeId);
        List<AssetEmployee> FindByAssetId(int AssetId);
    }

}
