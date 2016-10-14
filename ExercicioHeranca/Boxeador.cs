using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class Boxeador : Lutador
    {
        protected float stamina;
        
    

        public Boxeador(float forca, float velocidade,  
                        float agilidade, float vida, string nomeLutador,
                        float stamina)
            : base(forca, velocidade, agilidade, vida, nomeLutador)
        {
            this.stamina = stamina;
        }
    }
}
