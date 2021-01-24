using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DersOdevi
{
    interface IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string TcNumber { get; set; }
        public string BirthDate { get; set; }

    }
}
