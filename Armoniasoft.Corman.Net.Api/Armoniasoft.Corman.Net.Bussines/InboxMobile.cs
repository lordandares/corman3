using Armoniasoft.Corman.Net.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armoniasoft.Corman.Net.Bussines
{
    public class InboxMobile
    {
        public List<pa_bandeja_usuario_original_fast_Result> GetInboxMobile(int type, int user)
        {
            using (var context = new CormanEntities())
            {
                var typeq = new SqlParameter("@tipob", type);
                var userq = new SqlParameter("@usua", user);

                List<pa_bandeja_usuario_original_fast_Result> result = context.pa_bandeja_usuario_original_fast(type,user).ToList();
                return result;
            }
        }
    }
}
