using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDesignPatternIntro.Models
{
    public class UserData
    {

        public UserData(Int32 UserID)
        {

        }

        private string pLastName = "Jerry";

        public string LastName 
        {
            get { return pLastName;}
            set { pLastName= value;}
        }

    }
}