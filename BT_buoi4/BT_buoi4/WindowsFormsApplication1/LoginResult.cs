using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum LoginResult
    {
        /// <summary>
        /// Wrong username or password
        /// </summary>
        Invalid,
        /// <summary>
        /// User had been disabled
        /// </summary>
        Disabled,
        /// <summary>
        /// Loging success
        /// </summary>
        Success
    }
}
