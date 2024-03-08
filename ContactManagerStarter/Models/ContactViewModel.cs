using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Data;

namespace ContactManager.Models
{
    public class ContactViewModel
    {
        public List<Contact> Contacts { get; set; }
        public List<EmailViewModel> EmailAddresses { get; set; }//Added by Jordan (may need to do Emails instead of EmailAddresses)
        
    }
}
