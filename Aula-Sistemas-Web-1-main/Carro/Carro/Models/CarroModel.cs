using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Carro.Models
{
    public class CarroModel
    {
        [Key]
        public int cod { get; set; }

        [Required(ErrorMessage = "Informe o Modelo do Veículo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Informe a cor do veículo")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Informe o Ano do Veículo")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Informe a Marca do Veículo")]
        public String Marca { get; set; }
    }
}