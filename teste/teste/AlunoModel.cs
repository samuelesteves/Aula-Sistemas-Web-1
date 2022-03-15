using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace teste
{
    public class AlunoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe o Curso")]
        public String Curso { get; set; }

        public String Telefone { get; set; }

        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public String Email { get; set; }

        public String Sexo { get; set; }

    }
}