using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Platform.Modeler.Entity;

namespace Platform.Modeler.DAO
{

    public class EstudentController
    {

        EntityStudentDataContext db;

        public EstudentController()
        {
            db = new EntityStudentDataContext();
        }

        public bool guardar(String codigo, String nombre, String apellido, int edad, String carrera, String semestre)
        {
            //db.guardarEstudiante(codigo, nombre, apellido, edad, carrera, Convertsemestre);
            return true;
        }


    }
}
