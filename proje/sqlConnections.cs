using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proje
{
    internal class sqlConnections
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Server=tcp:denemesql.database.windows.net,1433;Initial Catalog=proje;Persist Security Info=False;User ID=Nakamoz55;Password=Namik_556677;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            baglan.Open();
            return baglan;
        }
    }
}
