﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Common;

namespace Library.DAL.Interface
{
    /// <summary>
    /// Repository for working with roles
    /// </summary>
    public interface IRolesRepository
    {
        /// <summary>
        /// Returns an indication that whether the user is in a specific role
        /// </summary>
        bool IsUserInRole(string login, string roleName);

        /// <summary>
        /// Returns a list of user roles.
        /// </summary>
        IEnumerable<string> GetRolesFromUser(string login);

        /// <summary>
        /// Changes the role to the user.
        /// </summary>
        Task ChangeUserRoleAsync(int userId, string role);
    }
}
