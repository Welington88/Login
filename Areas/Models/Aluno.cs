using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginAspNet.Areas.Models
{
    [Table("Aluno")]
    public class CadastroAluno
    {
        private bool aprovado;

        [Key]
        public int IdAluno { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public String Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public float Nota { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Currency)]
        public float Valor { get; set; }


        [Display(Name = "Inscrisão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Inscricao { get; set; }

        public bool Aprovado {
            get => aprovado = Nota >= 7 ? true : false;
            set => aprovado = value;
        }
    }
}
