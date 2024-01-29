using System;

namespace Clase1{

    public class Estudiante : MiembroDeLaComunidad
    {
        public String MatriculaEstudiante { get; set; }
        public void Estudiar(){
            // Console.WriteLine("Estoy estudiando");
            base.GetMiembro();
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
    }




}