using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace pc04.Models{


[Table("t_file")]
    public class file{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int ID { get; set; }


    [Required(ErrorMessage = "Por favor ingrese su Nombre")]
    [Display(Name = "Nombre")]
     public string Name { get; set; }
    
    
    [Required(ErrorMessage = "Por favor la imagen")]
    
    public String ImagenName { get; set; }

    public string Comentario{ get; set; }


}


}