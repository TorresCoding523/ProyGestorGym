using DAL;
namespace ProyGestorGym
{
    public class Parametros
    {

        //public static string cadenaConexion = @"Server=localhost;UserId=root1;Password=21021192;Port=3306;Database=GestorReservasGimnasio;";

#if DEBUG
        public static string cadenaConexion = @"Server=localhost;UserId=root1;Password=21021192;Port=3306;Database=GestorReservasGimnasio;";
#else
        public static string cadenaConexion = @"Server=db16794.public.databaseasp.net; Database=db16794; Uid=db16794; Pwd=Bo9!+2XkF#x3; SslMode=Preferred; ";
#endif
        public static TipoBD TipoBD = TipoBD.MySQL;

        public static FabricRepository FabricaRepository = new FabricRepository(cadenaConexion, TipoBD);
    }
}
