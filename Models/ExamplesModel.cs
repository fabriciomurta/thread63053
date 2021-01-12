using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtMVC1.Models
{
    public class ExamplesModel
    {
        public enum Roles
        {
            Guest,
            User,
            Admin,
            Approver
        }

        public static Roles CachedRole = Roles.Guest;

        public Roles Role
        {
            get => CachedRole;
        }

        public static void SetUser() => CachedRole = Roles.User;
        public static void SetAdmin() => CachedRole = Roles.Admin;
        public static void SetApprover() => CachedRole = Roles.Approver;
        public static void Logout() => CachedRole = Roles.Guest;
    }
}
