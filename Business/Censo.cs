using DataAccess;
using Models.Contracts;
using Models.Data;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Censo : ICenso
    {
        private readonly AppDBContext _dbContext;

        public Censo(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
        }
        public Response DeleteCensos(Models.Data.Censo censo)
        {
            throw new NotImplementedException();
        }

        public Models.Data.Censo GetCensoById()
        {
            throw new NotImplementedException();
        }

        public List<Models.Data.Censo> GetCensos()
        {
            List<Models.Data.Censo> censos = new List<Models.Data.Censo>();
            try
            {
                censos = _dbContext.censo.ToList();
                if( censos == null ) 
                {
                    return [];
                }
                
                return censos;
                
            }
            catch (Exception ex)
            {
                //throw;
                return [];
            }
        }

        public Response InsertCenso(Models.Data.Censo data)
        {
            Response response = new Response();
            try
            {

                Models.Data.Censo censo = new Models.Data.Censo
                {
                  fecha_recepcion_censo = data.fecha_recepcion_censo,
                  nit_ips = data.nit_ips,
                  ips_primaria = data.ips_primaria,
                  sucursal = data.sucursal,
                  tipo_identifi_afiliado = data.tipo_identifi_afiliado,
                  num_identifi_afil = data.num_identifi_afil,
                  apellidos = data.apellidos,
                  nombres = data.nombres
                };

                _dbContext.censo.Add(censo);
                _dbContext.SaveChanges();

                response.Id = 1;
                response.message = "Proceso exitoso";
                return response;


            }
            catch (Exception ex)
            {
                response.Id = 0;
                response.message = "Algo fallo!";
                return response;
                throw;
            }
        }

        public Response UpdateCensos(Models.Data.Censo censo)
        {
            throw new NotImplementedException();
        }
    }
}
