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

        private int _MeGusta;
        public int MeGusta {
            get {
                return _MeGusta;
            }
            set {
                _MeGusta = value;
            }
        }

        private int _NoMeGusta;
        public int NoMeGusta {
            get {
                return _NoMeGusta;
            }
            set {
                _NoMeGusta = value;
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

        public Curso(int IdCurso, string Nombre, string Descripcion, string Imagen, string UrlCurso, int MeGusta, int NoMeGusta, int IdEspecialidad){
            _IdCurso = IdCurso;
            _Nombre = Nombre;
            _Descripcion = Descripcion;
            _Imagen = Imagen;
            _UrlCurso = UrlCurso;
            _MeGusta = MeGusta;
            _NoMeGusta = NoMeGusta;
            _IdEspecialidad = IdEspecialidad;
        }
    }
}