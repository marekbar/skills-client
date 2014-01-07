/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */

namespace SkillsAndTasksDesktopClient
{
    /// <summary>
    /// Data types
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// From Skill table
        /// </summary>
        Skills,

        /// <summary>
        /// From Task table
        /// </summary>
        Tasks,

        /// <summary>
        /// From User table
        /// </summary>
        Users,

        /// <summary>
        /// From UserSkill table
        /// </summary>
        UserSkills
    }
}
