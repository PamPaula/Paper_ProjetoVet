using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ProjetoVetMVCNew.Models
{
    [Table("Animais")]
    public class Animais
    {

        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Responsavel")]
        [Column("Responsavel")]
        public string Responsavel { get; set; }

        [Display(Name = "Genero")]
        [Column("Genero")]
        public string Genero { get; set; }

        [Display(Name = "Porte")]
        [Column("Porte")]
        public string Porte { get; set; }

        [Display(Name = "Pelagem")]
        [Column("Pelagem")]
        public string Pelagem { get; set; }

        [Display(Name = "Raça")]
        [Column("Raca")]
        public string Raca { get; set; }

        [Display(Name = "Idade")]
        [Column("Idade")]
        public string Idade { get; set; }

        [Display(Name = "Castrado")]
        [Column("Castrado")]
        public string Castrado { get; set; }

        [Display(Name = "Observação")]
        [Column("Observação")]
        public string Observacao { get; set; }

    }

}

