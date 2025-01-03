using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO.Exercicio_1
{
    public class MuscaDomestica : Animalia
    {
        // Contrutor
        public MuscaDomestica()
       : base("Arthropoda", "Insecta", "Muscidae", "Carnidae", "Musca", "Canis", "Cani Familiares")
        {

        }

        public override string ObterDescricao()
        {
            return $"Reino: {Reino}\nFilo: {Filo}\nClasse: {Classe}\nOrdem: {Ordem}\nFamilia: {Familia}\nGenero: {Genero}\nEspecie: {Especie}";
        }
    }
}