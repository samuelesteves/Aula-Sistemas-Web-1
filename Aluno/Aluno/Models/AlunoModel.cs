using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Aluno.Models
{
    public class AlunoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o curso")]
        public string Curso { get; set; }

        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public string Email { get; set; }

        public string Sexo { get; set; }
    }
}