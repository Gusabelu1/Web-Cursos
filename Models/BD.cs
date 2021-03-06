using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SqlClient;

namespace TP11___Web_Cursos.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=GUSABELU1\SQLEXPRESS;DataBase=BDWebCursos;Trusted_Connection=True;";
        private static List<Curso> _listaCursos = new List<Curso>();
        private static List<Especialidad> _listaEspecialidades = new List<Especialidad>();

        public static Curso ConsultaCurso(int IdCurso){
            Curso TempCurso = null;
            string sql = "SELECT * FROM Cursos WHERE IdCurso = @pCurso";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                TempCurso = db.QueryFirstOrDefault<Curso>(sql, new{ pCurso = IdCurso });
            }
            return TempCurso;
        }

        public static Especialidad ConsultaEspecialidad(int IdEspecialidad){
            Especialidad TempEspecialidad = null;
            string sql = "SELECT * FROM Especialidades WHERE IdEspecialidad = @pEspecialidad";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                TempEspecialidad = db.QueryFirstOrDefault<Especialidad>(sql, new{ pEspecialidad = IdEspecialidad });
            }
            return TempEspecialidad;
        }

        public static List<Curso> ListarCursos(int IdEspecialidad){
            if(IdEspecialidad == -1){
                string sql = "SELECT * FROM Cursos";
                using(SqlConnection db = new SqlConnection(_connectionString)){
                    _listaCursos = db.Query<Curso>(sql).ToList();
                }   
            }
            else{
                string sql = "SELECT * FROM Cursos WHERE IdEspecialidad = @pEspecialidad";
                using(SqlConnection db = new SqlConnection(_connectionString)){
                    _listaCursos = db.Query<Curso>(sql, new{ pEspecialidad = IdEspecialidad }).ToList();
                }
            }
            return _listaCursos;
        }

        public static List<Especialidad> ListarEspecialidades(){
            string sql = "SELECT * FROM Especialidades";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                _listaEspecialidades = db.Query<Especialidad>(sql).ToList();
            }
            return _listaEspecialidades;
        }

        public static void AgregarCurso(Curso TempCurso){
            string sql = "INSERT INTO Cursos VALUES (@pNombre, @pDescripcion, @pImagen, @pUrlCurso, 0, 0, @pIdEspecialidad)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(sql, new{ pNombre = TempCurso.Nombre, pDescripcion = TempCurso.Descripcion, pImagen = TempCurso.Imagen, pUrlCurso = TempCurso.UrlCurso, pIdEspecialidad = TempCurso.IdEspecialidad });
            }
        }

        public static bool CalificarCurso(int IdCurso, bool Calificacion){
            int contadorRegistros = 0;
            if(Calificacion){
                string sql = "UPDATE Cursos SET MeGusta = MeGusta+1 WHERE IdCurso = @pCurso";
                using(SqlConnection db = new SqlConnection(_connectionString)){
                    contadorRegistros = db.Execute(sql, new{ pCurso = IdCurso });
                }  
            }
            else{
                string sql = "UPDATE Cursos SET NoMeGusta = NoMeGusta+1 WHERE IdCurso = @pCurso";
                using(SqlConnection db = new SqlConnection(_connectionString)){
                    contadorRegistros = db.Execute(sql, new{ pCurso = IdCurso });
                }  
            }
            return contadorRegistros != 0;
        }
    }
}