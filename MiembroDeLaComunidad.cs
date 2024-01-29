using System;

namespace Clase1{

    public abstract class MiembroDeLaComunidad : IMiembroDeLaComunidad{
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Saludar(){
            // Console.WriteLine("Hola soy un miembro de la comunidad");
        }

        public abstract  void Reirse();

        public abstract void Trotar();

        public abstract void Comer();

        public MiembroDeLaComunidad GetMiembro()
        {
            throw new NotImplementedException();
        }
    }

}