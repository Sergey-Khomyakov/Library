using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL.Interface;
using Library.DAL.Interface;

namespace Library.BLL
{
    /// <summary>
    /// Service for working with roles.
    /// </summary>
    public class RolesService : IRolesService
    {
        private readonly IRolesRepository _rolesRepository;
        public RolesService(IRolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        /// <summary>
        /// Returns an indication that whether the user is in a specific role
        /// </summary>
        public async Task ChangeUserRoleAsync(int userId, string role)
        {
            await _rolesRepository.ChangeUserRoleAsync(userId, role);
        }

        /// <summary>
        /// Returns a list of user roles.
        /// </summary>
        public IEnumerable<string> GetRolesFromUser(string login)
        {
            return _rolesRepository.GetRolesFromUser(login);
        }

        /// <summary>
        /// Changes the role to the user.
        /// </summary>
        public bool IsUserInRole(string login, string roleName)
        {
            return _rolesRepository.IsUserInRole(login, roleName);
        }
    }
}
