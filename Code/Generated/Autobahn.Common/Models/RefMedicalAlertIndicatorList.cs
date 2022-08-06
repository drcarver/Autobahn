//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMedicalAlertIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMedicalAlertIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMedicalAlertIndicator"> List
         /// </summary>
        public static List<RefMedicalAlertIndicator> RefMedicalAlertIndicatorList = new List<RefMedicalAlertIndicator>
        {
            new RefMedicalAlertIndicator { Id=Guid.Parse("68372dcb-9e7c-41d0-a50c-1ad74d9f90e6"), Code="Chronic", Description="Chronic", Definition="The person has an alert indicator for a chronic medical/health condition.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("8c7d32f8-0956-4794-8c21-0b4539e81666"), Code="Acute", Description="Acute", Definition="The person has an alert indicator for an acute medical/health condition.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("aa387e44-52cf-4bcc-8892-9dd3f8d868d7"), Code="None", Description="None", Definition="The person does not have an alert indicator for a medical/health condition.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefMedicalAlertIndicator Pick List
         /// </summary>
        public static List<RefMedicalAlertIndicator> RefMedicalAlertIndicatorPickList = new List<RefMedicalAlertIndicator>
        {
            new RefMedicalAlertIndicator { Id=Guid.Parse("68372dcb-9e7c-41d0-a50c-1ad74d9f90e6"), Code="Chronic", Description="Chronic", SortOrder=Convert.ToDecimal("1.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("8c7d32f8-0956-4794-8c21-0b4539e81666"), Code="Acute", Description="Acute", SortOrder=Convert.ToDecimal("2.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("aa387e44-52cf-4bcc-8892-9dd3f8d868d7"), Code="None", Description="None", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
