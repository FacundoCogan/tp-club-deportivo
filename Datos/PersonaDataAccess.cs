﻿using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace Datos
{
    public abstract class PersonaDataAccess : DataAccessBase
    {
        protected PersonaDataAccess(string tableName) : base(tableName)
        {
        }

        protected DataTable GetAll()
        {
            return GetAll("Activo = TRUE");
        }

        public bool Delete(int id)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("ID", id)
            };

            return Delete("ID = ?", parameters);
        }

        public bool Insert(int dni, string nombre, string apellido,
            params OleDbParameter[] additionalParameters)
        {
            OleDbParameter[] baseParameters =
            {
                new OleDbParameter("DNI", dni),
                new OleDbParameter("Nombre", nombre),
                new OleDbParameter("Apellido", apellido)
            };

            var combinedParameters = baseParameters.Concat(additionalParameters).ToArray();

            return Insert(combinedParameters);
        }

        public bool Update(int id, int dni, string nombre, string apellido,
            params OleDbParameter[] additionalParameters)
        {
            OleDbParameter[] baseParameters =
            {
                new OleDbParameter("DNI", dni),
                new OleDbParameter("Nombre", nombre),
                new OleDbParameter("Apellido", apellido)
            };

            var combinedParameters =
                baseParameters.Concat(additionalParameters).ToArray();

            return Update(combinedParameters, "ID = ?", new OleDbParameter("ID", id));
        }

        public bool Exists(int dni)
        {
            OleDbParameter[] parameters =
            {
                new OleDbParameter("DNI", dni)
            };

            return Exists(parameters);
        }
    }
}