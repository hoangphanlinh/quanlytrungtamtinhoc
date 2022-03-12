using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=QLHocPhan;Integrated Security=True");
    }
}
