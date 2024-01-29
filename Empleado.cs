using System;

namespace Clase1{
    public abstract class Empleado : MiembroDeLaComunidad
    {
        public String CodigoEmpleado { get; set; }
        public abstract void Trabajar();
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

            public abstract class Docente : Empleado
        {
            public override abstract void Trabajar();
            public class Maestro : Docente
            {
                public void Permiso()
                {
                    // Console.WriteLine("Tome un permiso para ir al dentista.");
                }

                public override void Trabajar()
                {
                    throw new NotImplementedException();
                }
            }

            public class Administrador : Docente
            {
                public void Explicar()
                {
                    // Console.WriteLine("Estoy explicando los ejercicios de matematicas.");
                }

                public override void Trabajar()
                {
                    throw new NotImplementedException();
                }
            }
        }

            public class Administrativo : Empleado
        {
            public void Gestionar()
            {
                // Console.WriteLine("Estoy gestionando las vacaciones de este año.");
            }

            public override void Trabajar()
            {
                throw new NotImplementedException();
            }
        }

    }

}