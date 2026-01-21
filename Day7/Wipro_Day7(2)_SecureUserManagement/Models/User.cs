using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Day7_2_SecureUserManagement.Models
{
    public class User
    {
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public string EncryptedEmail { get; set; }
    }
}

