using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList
{
    class ContactInfo
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

        public ContactInfo()
        {
            Id = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Photo = string.Empty;
        }

        public ContactInfo(string line)
        {
            string[] pieces = line.Split('|');
            Id = pieces[0];
            FirstName = pieces[1];
            LastName = pieces[2];
            Email = pieces[3];
            Photo = pieces[4];
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
