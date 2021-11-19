using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP11___Web_Cursos.Models
{
    public class Especialidad
    {
        private int _IdEspecialidad;
        public int IdEspecialidad {
                get {
                    return _IdEspecialidad;
                }
                set {
                    _IdEspecialidad = value;
                }
        }

        private string _Nombre;
        public string Nombre {
            get {
                return _Nombre;
            }
            set {
                _Nombre = value;
            }
        }

        private string _Materia;
        public string Materia {
            get {
                return _Materia;
            }
            set {
                _Materia = value;
            }
        }
    }
}