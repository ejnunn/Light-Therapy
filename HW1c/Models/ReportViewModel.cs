using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1c.Models
{
    public class ReportViewModel
    {
        // The List of Logs
        public LogViewModel LogViewModel { get; set; }

        // The Number of Users
        public int NumberOfUsers { get; set; }
    }
}