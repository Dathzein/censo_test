using Models.Data;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contracts
{
    public interface ICenso
    {
        List<Censo> GetCensos(); 
        Censo GetCensoById(); 
        Response InsertCenso(Models.Data.Censo censo); 
        Response UpdateCensos(Models.Data.Censo censo); 
        Response DeleteCensos(Models.Data.Censo censo);
    }
}
