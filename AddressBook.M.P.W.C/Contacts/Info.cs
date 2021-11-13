using System;
namespace AddressBook.M.P.W.C.Contacts
{
    public class Info
    {

        private string _address;

        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                if (value.Length > 6)
                {
                    this._address = value;
                }
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public string Telephone { get; set; }

        //private string _telephone;

        //public string Telephone
        //{
        //    get
        //    {
        //        return this._telephone;
        //    }
        //    set
        //    {
        //        if (value.Length > 10)
        //        {
        //            this._telephone = value;
        //        }
        //    }
        //}

        public Info()
        {
        }
    }
}
