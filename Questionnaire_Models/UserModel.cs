﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Models
{
    public class UserModel
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

    }
}
