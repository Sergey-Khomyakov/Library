using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.DAL.Interface;

namespace Library.DAL
{
    /// <summary>
    /// Repository for working with roles
    /// </summary>
    public class RolesRepository : IRolesRepository
    {
        /// <summary>
        /// Returns an indication that whether the user is in a specific role
        /// </summary>
        public Task ChangeUserRoleAsync(int userId, string role)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list of user roles.
        /// </summary>
        public IEnumerable<string> GetRolesFromUser(string login)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes the role to the user.
        /// </summary>
        public bool IsUserInRole(string login, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
