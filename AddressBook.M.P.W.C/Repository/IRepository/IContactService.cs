using System;
using AddressBook.M.P.W.C.Contacts;

namespace AddressBook.M.P.W.C.Repository.IRepository
{
    public interface IContactService
    {
        Info New(Info info);

        Info Update(int id, Info info);

        bool Delete(int id);

        Info Find(int id);

        int FindId();

        Info[] ShowInfo();
    }
}
