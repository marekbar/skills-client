/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using System;
using System.Collections.Generic;

namespace SkillsAndTasksDesktopClient
{
    /// <summary>
    /// User for combobox
    /// </summary>
    public class UserWho
    {
        /// <summary>
        /// User - original
        /// </summary>
        private SkillsAndTasksDesktopClient.MBService.User user;

        /// <summary>
        /// UserWho list
        /// </summary>
        public IList<UserWho> Users { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="user"></param>
        public UserWho(SkillsAndTasksDesktopClient.MBService.User user)
        {
            Users = new List<UserWho>();
            this.user = user;
        }

        /// <summary>
        /// User name to display
        /// </summary>
        public String Who
        {
            get 
            {
                return user.Name + " " + user.Surname + " (" + user.Login + ")";            
            }
        }

        /// <summary>
        /// User id
        /// </summary>
        public int Id
        {
            get
            {
                return user.Id;
            }
        }

    }

    /// <summary>
    /// UserWho extensions
    /// </summary>
    public static class ComboboxUserExtension
    {
        /// <summary>
        /// Convert User list to UserWho list
        /// </summary>
        /// <param name="users">User list</param>
        /// <returns>UserWho list</returns>
        public static List<UserWho> Convert(this List<SkillsAndTasksDesktopClient.MBService.User> users)
        {
            List<UserWho> list = new List<UserWho>();
            foreach (var user in users)
                list.Add(new UserWho(user));
            return list;
        }
    }
}
