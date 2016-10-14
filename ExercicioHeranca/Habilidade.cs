using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    public class Habilidade
    {

        string nome;
        public string Nome
        {
            get { return nome; }
        }

        public Habilidade(string nome )
        {
            this.nome = nome;
        }

        public virtual void Usar()
        {
            System.Console.WriteLine("Usou Habilidade Basica");
        }



    }
}