using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiRacunarskeKomponenteSO : SystemOperationBase
    {
        public List<RacunarskaKomponenta> Result { get; private set; }
        public List<RacunarskaKomponenta> RacunarskeKomponente { get; set; }
        protected override void Execute(IDomainObject domainObject)
        {
            foreach (RacunarskaKomponenta r in RacunarskeKomponente)
            {
                repository.Save(r);
            }
            Result = RacunarskeKomponente;
        }
    }
}
