using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePraticoProgramacaoWEB.Models
{
    [Table("tblProduto")]
    public class Produto
    {
        [Display(Name ="Id")]
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

        [Display(Name = "Perecível")]
        [Column("Perecivel")]
        public bool Perecivel { get; set; }

        [Display(Name = "Categoria do Produto")]
        [Column("CategoriaID")]
        public int CategoriaID { get; set; }

        [ForeignKey("CategoriaID")]
        public virtual CategoriaProduto CategoriaProduto { get; set; }
    }
}
