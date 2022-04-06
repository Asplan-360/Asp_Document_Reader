using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp_Document_Reader.Shared;

[Table("viewGer_Menu")]
public class MenuItem
{
    [Key]
    [Column("GER_Rotina_Id")]
    [Display(Name = "Rotina ID")]
    public int RotinaId { get; set; }

    [Column("GER_Menu_ID")]
    [Display(Name = "Menu ID")]
    public int MenuId { get; set; }

    [Column("DescMenu")]
    [Display(Name = "Tipo")]
    public string DescMenu { get; set; }

    [Required]
    [Column("titulo")]
    [Display(Name = "Titulo")]
    public string Titulo { get; set; }

    [Column("OrdemMenu")]
    [Display(Name = "OrdemMenu")]
    public int OrdemMenu { get; set; }

    [Column("DescRotina")]
    [Display(Name = "Rotina")]
    public string Rotina { get; set; }

    [Column("OrdemRotina")]
    [Display(Name = "Ordem Rotina")]
    public int OrdemRotina { get; set; }

    [Column("acesspadm")]
    [Display(Name = "Tipo de Acesso")]
    public bool Acess { get; set; }

    [Column("icone")]
    [Display(Name = "Icone")]
    public string Icone { get; set; }

    [Column("janela")]
    [Display(Name = "Janela")]
    public string Janela { get; set; }

    [Required]
    [Column("descricao")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Column("rota")]
    [Display(Name = "Rota")]
    public string Rota { get; set; }

    [Column("paramauxiliar")]
    [Display(Name = "Parametro Auxiliar")]
    public string Auxiliar { get; set; }

    [Column("Action")]
    [NotMapped]
    public string? Action { get; set; }


 



}
