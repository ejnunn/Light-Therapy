using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW1c.Models;
namespace HW1c.Backend
{
    public class LogBackend
    {

        /// <summary>
        ///  Returns the List of Logs
        /// </summary>
        /// <returns></returns>
        public LogViewModel Index()
        {
            var myData = new LogViewModel();

            // TODO:  Populate some Log Data here...
            myData.LogList.Add(new LogModel { AppVersion = "1",PhoneID = "ABC",RecordedDateTime = DateTime.Now });
            myData.LogList.Add(new LogModel { AppVersion = "2", PhoneID = "MNO", RecordedDateTime = DateTime.Parse("01/23/2019") });
            myData.LogList.Add(new LogModel { AppVersion = "3", PhoneID = "ZYX", RecordedDateTime = DateTime.Now.AddDays(-2) });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "ZYXa", RecordedDateTime = DateTime.Now.AddYears(-1) });
            return myData;
        }

    }
}