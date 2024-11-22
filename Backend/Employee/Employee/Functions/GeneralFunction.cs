using System.Text;

namespace Employee.Functions
{
    public class GeneralFunction
    {
        public GeneralFunction(IConfiguration configuration)

        {


        }
        public void AddLog(string newLog)
        {
            string carpetaLog = AppDomain.CurrentDomain.BaseDirectory + "Log//";
            if (!Directory.Exists(carpetaLog))
            {
                Directory.CreateDirectory(carpetaLog);
            }
            string RutaLog = carpetaLog + AppDomain.CurrentDomain.FriendlyName + "_" + DateTime.Now.ToString("dd-MM-yyy") + ".Log";
            var registro = DateTime.Now + "" + newLog + "\n";
            var BytsNewlog = new UTF8Encoding(true).GetBytes(registro);
            using (FileStream Log = File.Open(RutaLog, FileMode.Append))
            {
                Log.Write(BytsNewlog, 0, BytsNewlog.Length);
            }
        }
    }
}
