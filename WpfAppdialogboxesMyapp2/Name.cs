using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppdialogboxesMyapp2
{
    public class Name
    {
        private string firstname;

        private string lastname;

        public Name(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string FirstName
        {
            get { return firstname; }

        }

        public string LastName
        {

            get { return lastname; }
        }

        public override string ToString()
        {
            return firstname + " " + lastname;
        }

    }
}
