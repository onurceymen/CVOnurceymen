using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;


namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }
        public void Tadd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TgetList()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
