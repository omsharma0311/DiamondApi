using DiamondApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondApi.Services
{
    public class DiamondService : IDiamondService
    {
        public List<Diamond> GetAllDiamond()
        {
            return Diamond;
        }
        public Diamond GetDiamondById(int id)
        {
            return Diamond.FirstOrDefault(x => x.BookId == id);
        }
        public List<Diamond> AddDiamond(Diamond newDiamond)
        {
            Diamond.Add(newDiamond);
            return Diamond;
        }
        public List<Diamond> UpdateDiamond(Diamond updateDiamond)
        {
            Diamond Diamond = Diamond.FirstOrDefault(x => x.DiamondId == updateDiamond.DiamondId);
            Diamond.DiamondName = updateDiamond.DiamondName;
            return Diamond;
        }

        public List<Diamond> DeleteDiamond(Diamond updateDiamond)
        {
            Diamond.Delete(newDiamond);
            return Diamond;
        }
    }
}
