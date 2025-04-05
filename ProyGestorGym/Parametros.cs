using DAL;
namespace ProyGestorGym
{
    public class Parametros
    {

        //public static string cadenaConexion = @"Server=localhost;UserId=root1;Password=21021192;Port=3306;Database=GestorReservasGimnasio;";

#if DEBUG
        public static string cadenaConexion = @"Server=localhost;UserId=root1;Password=21021192;Port=3306;Database=GestorReservasGimnasio;";
#else
public static string cadenaConexion = @"Server=db16343.databaseasp.net; Database=db16343; User Id=db16343; Password=Ka4_6E@sFc9#; Encrypt=False; MultipleActiveResultSets=True;";
#endif
        public static TipoBD TipoBD = TipoBD.MySQL;

        public static FabricRepository FabricaRepository = new FabricRepository(cadenaConexion, TipoBD);
    }
}
