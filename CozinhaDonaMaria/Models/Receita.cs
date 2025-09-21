using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozinhaDonaMaria.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoCozinha Tipo { get; set; }
        public List<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();
        public string ModoPreparo { get; set; }
    }
}
