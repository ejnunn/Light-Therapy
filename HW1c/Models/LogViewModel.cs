using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1c.Models
{
    public class LogViewModel
    {
        /// <summary>
        /// List of Logs
        /// </summary>
        public List<LogModel> LogList { get; set; } = new List<LogModel>();
    }
}