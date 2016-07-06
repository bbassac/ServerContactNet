using ServerNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerNet.Repository
{
    public interface IContactsRepository
    {
        void Save(Contacts item);
        IEnumerable<Contacts> GetAll();
        Contacts Find(long key);
        void Remove(long Id);
        void Update(Contacts item);
    }
}
