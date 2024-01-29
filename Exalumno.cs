using System;

namespace Clase1{
    public class Exalumno : MiembroDeLaComunidad
    {
        public void Trabajar()
        {
            // Console.WriteLine("Estoy trabajando");
        }
        public override void Comer()
        {
            throw new NotImplementedException();
        }

        public override void Trotar()
        {
            throw new NotImplementedException();
        }

        public override void Reirse()
        {
            throw new NotImplementedException();
        }

        public void Leer(){
            
            // Estoy leyendo el libro de la bella y la bestia.

        }

    }

}