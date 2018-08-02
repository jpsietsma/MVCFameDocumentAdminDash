using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFameDocs.Models
{

    public class UserModel
    {

        #region Account Information

        public string UserName { get; set; }
        public string UserEmail { get; set; }

        #endregion

        #region Profile Information

        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        #endregion

        #region Permissions properties

        public bool UserRead { get; set; } = true;
        public bool UserWrite { get; set; } = false;
        public bool UserCreate { get; set; } = false;
        public bool UserDelete { get; set; } = false;
        public bool UserChange { get; set; } = false;
        public bool UserGuest { get; set; } = false;

        #endregion

    }
}