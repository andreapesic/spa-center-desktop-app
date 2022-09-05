using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class KriterijumPretrage : IDomainObject
    {
        public string Tekst { get; set; }

        public KriterijumPretrage(string tekst)
        {
            Tekst = tekst;
        }
        public string TableName => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string GeneralCondition => throw new NotImplementedException();

        public object SelectValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string OutputInserted => throw new NotImplementedException();

        public string SearchCondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
