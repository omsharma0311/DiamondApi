using DiamondApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondApi.Services
{
    public interface IDiamondService
    {
        List<Diamond> GetAllDiamond();
        Diamond GetDiamondById(int id);
        List<Diamond> AddDiamond(Diamond newDiamond);
        List<Diamond> UpdateDiamond(Diamond updateDiamond);
        List<Diamond> DeleteDiamond(Diamond updateDiamond);
    }
}
