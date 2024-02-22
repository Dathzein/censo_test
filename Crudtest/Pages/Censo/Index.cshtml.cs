using Azure;
using Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Models.Contracts;
using Models.Data;

namespace Crudtest.Pages.Censo
{
    public class IndexModel : PageModel
    {
		private readonly ICenso _censo;

        public IndexModel( ICenso censo)
        {
            _censo = censo;
        }

        
        public void OnGet()
        {
        }

        public List<Models.Data.Censo> getCensos()
        {
            try
            {
                var censos = _censo.GetCensos();
                return censos;
            }
			catch (Exception ex)
			{
                return [];
                throw;
            }
        }

        public bool InsertCenso(Models.Data.Censo censo)
        {
            bool response = false;
            try
            {
                var censos = _censo.InsertCenso(censo);
                if (censos.Id == 0) { return response; }
                
                response = true;
                return response;
            }
            catch (Exception ex)
            {
                return response;
                throw;
            }
        }
    }
}
