using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using RpgApi.Models;

namespace Aula09_DS.Models
{
    public class Arma
    {
        public int id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Dano { get; set; }
        public Personagem? Personagem { get; set; } = null!;
        public int? PersonagemId { get; set; }
    }
}