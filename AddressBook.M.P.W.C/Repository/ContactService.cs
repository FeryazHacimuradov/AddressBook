using System;
using AddressBook.M.P.W.C.Contacts;
using AddressBook.M.P.W.C.Repository.IRepository;
using System.Linq;


namespace AddressBook.M.P.W.C.Repository
{
    public class ContactService: IContactService
    {
        private Info[] fullInfo  = new Info[0];

        public bool Delete(int id)
        {
            fullInfo = Array.FindAll(fullInfo, e => e.Id != id);
            return true;
        }

        public Info Find(int id)
        {
            Info foundInfo = Array.Find(fullInfo, e => e.Id == id);
            return foundInfo;
        }

        public int FindId()
        {
            if (fullInfo.Length == 0)
            {
                return 1;
            }
            return fullInfo[fullInfo.Length - 1].Id + 1;
        }

        public Info New(Info info)
        {
            Array.Resize(ref fullInfo, fullInfo.Length + 1);

            fullInfo[fullInfo.Length - 1] = info;
            return info;
        }

        public Info[] ShowInfo()
        {
            return this.fullInfo;
        }

        public Info Update(int id, Info info)
        {
            Info updatedInfo = Array.Find(fullInfo, e => e.Id == id);
            updatedInfo = info;
            return updatedInfo;
        }

        
    }
}
