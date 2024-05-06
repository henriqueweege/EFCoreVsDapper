using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreVsDapper
{
    internal static class Settings
    {
        public static string ConnectionString = "Server=localhost\\MSSQLSERVER01;Database=DapperVsEfCore; TrustServerCertificate=True; Trusted_Connection=True;";
    }
}
