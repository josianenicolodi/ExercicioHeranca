using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class Lutador
    {
        #region Variaveis
        protected string nomeLutador;
        protected float forca;
        protected float velocidade;
        protected float energia;
        protected float vida;
        #endregion

        #region Propriedades
        public string NomeLutador
        {
            get
            {
                return nomeLutador;
            }
        }

        public float Forca
        {
            get
            {
                return forca;
            }
        }

        public float Velocidade
        {
            get
            {
                return velocidade;
            }
        }

        public float Energia
        {
            get
            {
                return energia;
            }
        }

        public float Vida
        {
            get
            {
                return vida;
            }
            protected set
            {
                vida = value;
                if (vida < 0)
                {
                    vida = 0;
                }
            }
        }
        #endregion

    
        public Lutador(float forca, float velocidade, float agilidade, float vida, string nomeLutador)
        {
            this.forca = forca;
            this.velocidade = velocidade;
            this.energia = agilidade;
            this.vida = vida;
            this.nomeLutador = nomeLutador;
        }

        #region MetodosPublicos
        public virtual void Ataque(Lutador outro)
        {
            outro.SofreDano(this.Forca);
        }

        public virtual void Defesa()
        {
            throw new NotImplementedException();
        }

        public virtual void SofreDano(float qt)
        {
            Vida -= qt;
        }
        #endregion

    }
}
