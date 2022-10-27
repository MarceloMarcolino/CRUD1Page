using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TestePraticoProgramacaoWEB.Models
{
    [Table("tblCategoriaProduto")]
    public class CategoriaProduto
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Column("Descricao")]
        public string Descricao { get; set; }

        [Display(Name = "Ativo")]
        [Column("Ativo")]
        public bool Ativo { get; set; }
    }
}
