using COMMON.Entidades;
using COMMON.Interfaces;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FabricRepository
    {
        private readonly string _cadenaConexion;
        private readonly TipoBD _tipo;

        public FabricRepository(string cadenaConexion, TipoBD tipo)
        {
            _cadenaConexion = cadenaConexion;
            _tipo = tipo;
        }

        public IDB<Clases> ClasesRepository()
        {
            switch (_tipo)
            {
                case TipoBD.MySQL:
                    return new DBMySQL<Clases>(_cadenaConexion, new ClasesValidador(), "Id", true);
                default:
                    return null;
            }

        }

        public IDB<Entrenadores> EntrenadoresRepository()
        {
            switch (_tipo)
            {
                case TipoBD.MySQL:
                    return new DBMySQL<Entrenadores>(_cadenaConexion, new EntrenadoresValidador(), "Id", true);
                default:
                    return null;
            }

        }

        public IDB<Membresias> MembresiasRepository()
        {
            switch (_tipo)
            {
                case TipoBD.MySQL:
                    return new DBMySQL<Membresias>(_cadenaConexion, new MembresiasValidador(), "Id", true);
                default:
                    return null;
            }

        }

        public IDB<Pagos> PagosRepository()
        {
            switch (_tipo)
            {
                case TipoBD.MySQL:
                    return new DBMySQL<Pagos>(_cadenaConexion, new PagosValidador(), "Id", true);
                default:
                    return null;
            }

        }

        public IDB<Reservas> ReservasRepository()
        {
            switch (_tipo)
            {
                case TipoBD.MySQL:
                    return new DBMySQL<Reservas>(_cadenaConexion, new ReservasValidador(), "Id", true);
                default:
                    return null;
            }

        }

        public IDB<Usuarios> UsuariosRepository()
        {
            switch (_tipo)
            {
                case TipoBD.MySQL:
                    return new DBMySQL<Usuarios>(_cadenaConexion, new UsuariosValidador(), "Id", true);
                default:
                    return null;
            }

        }
    }

    public enum TipoBD
    {
        SQL_SERVER,
        MySQL
    }
}
