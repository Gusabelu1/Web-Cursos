using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP11___Web_Cursos.Models
{
    public class Curso
    {
        private int _IdCurso;
        public int IdCurso {
            get {
                return _IdCurso;
            }
            set {
                _IdCurso = value;
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

        private string _Descripcion;
        public string Descripcion {
            get {
                return _Descripcion;
            }
            set {
                _Descripcion = value;
            }
        }

        private string _Imagen;
        public string Imagen {
            get {
                return _Imagen;
            }
            set {
                _Imagen = value;
            }
        }
        private string _UrlCurso;
        public string UrlCurso {
            get {
                return _UrlCurso;
            }
            set {
                _UrlCurso = value;
            }
        }

        private int _CantidadVotos;
        public int CantidadVotos {
            get {
                return _CantidadVotos;
            }
            set {
                _CantidadVotos = value;
            }
        }

        private int _AcumuladorEstrellas;
        public int AcumuladorEstrellas {
            get {
                return _AcumuladorEstrellas;
            }
            set {
                _AcumuladorEstrellas = value;
            }
        }

        private int _IdEspecialidad;
        public int IdEspecialidad {
            get {
                return _IdEspecialidad;
            }
            set {
                _IdEspecialidad = value;
            }
        }

        public Curso(int IdCurso, string Nombre, string Descripcion, string Imagen, string UrlCurso, int CantidadVotos, int AcumuladorEstrellas, int IdEspecialidad) {
            _IdCurso = IdCurso;
            _Nombre = Nombre;
            _Descripcion = Descripcion;
            _Imagen = Imagen;
            _UrlCurso = UrlCurso;
            _CantidadVotos = CantidadVotos;
            _AcumuladorEstrellas = AcumuladorEstrellas;
            _IdEspecialidad = IdEspecialidad;
        }
    }
}