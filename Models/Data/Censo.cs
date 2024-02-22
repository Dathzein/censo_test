using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    [Table("censo")]
    public class Censo
    {
        [Key]
        public int id_censo { get; set; }
        public DateTime fecha_recepcion_censo { get; set; }
        public decimal nit_ips { get; set; }
        public string ips_primaria { get; set; }
        public int sucursal { get; set; }
        public string tipo_identifi_afiliado { get; set; }
        public string num_identifi_afil { get; set; }
        public string apellidos { get; init; }
        public string nombres { get; init; }

    }
}
