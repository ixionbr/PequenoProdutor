using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PequenoProdutor.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "ntext")]
        public string Descricao { get; set; }
        public float Preco { get; set; }

    }
}