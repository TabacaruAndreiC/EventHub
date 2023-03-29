using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class EventUpdateDto
    {
        /// <summary>
        ///     Avem nevoie pentru a putea gasi studentul.
        ///     Aceasta proprietate este ceruta in acelasi "body" pentru consecventa,
        ///     chiar daca nu face parte din update.
        /// </summary>
        /// 
        public int Id { get; set; }

        /// <summary>
        ///     'Required' - obliga ca prin requestul http 
        ///     sa fie pasat si acest atribut in json
        ///     
        ///     'MaxLength'- ne protejeaza impotriva 
        ///     utilizarii malitioase - introducerea a 1mil. de caractere nu are sens
        /// </summary>
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
