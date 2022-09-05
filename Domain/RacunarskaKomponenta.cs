using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum Tip {
        Izlazna, Ulazna, UlaznoIzlazna, Ostalo
    }
    [Serializable]
    public class RacunarskaKomponenta : IDomainObject
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public Tip Tip { get; set; }

        public string TableName => "RacunarskaKomponenta";

        public string TableAlias => "rc";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string WhereCondition => "";

        public string GeneralCondition => "";

        public object SelectValues => "*";

        public string UpdateValues => "";

        public string InsertValues => $"'{Naziv}', '{Opis}', '{Tip}'";

        public string OutputInserted => "";

        public string SearchCondition { get => searchCondition; set => searchCondition = value; }

        private string searchCondition;
        
        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new RacunarskaKomponenta
                {
                    Id = (int)reader["Id"],
                    Naziv = (string)reader["Naziv"],
                    Opis = (string)reader["Opis"],
                    Tip = (Tip)Enum.Parse(typeof(Tip), (string)reader["Tip"]),

                });
            }
            return result;
        }
    }
}
