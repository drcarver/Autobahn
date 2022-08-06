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
        public static List<RefMedicalAlertIndicator> RefMedicalAlertIndicatorList = new List<RefMedicalAlertIndicator> =
        {
            new RefMedicalAlertIndicator { Id=Guid.Parse("1009a1cb-b132-4834-b05d-cb4566c67266"), Code="The person has an alert indicator for a chronic medical/health condition.", Description="Chronic", Definition="", SortOrder=0 },
            new RefMedicalAlertIndicator { Id=Guid.Parse("73daeff8-e551-420b-832d-f7256f320a35"), Code="The person has an alert indicator for an acute medical/health condition.", Description="Acute", Definition="", SortOrder=0 },
            new RefMedicalAlertIndicator { Id=Guid.Parse("a63de77e-bf1a-497b-b938-5da68a2a63a4"), Code="The person does not have an alert indicator for a medical/health condition.", Description="None", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMedicalAlertIndicator Pick List
         /// </summary>
        public static List<RefMedicalAlertIndicator> RefMedicalAlertIndicatorPickList = new List<RefMedicalAlertIndicator> =
        {
            new RefMedicalAlertIndicator { Id=Guid.Parse("1009a1cb-b132-4834-b05d-cb4566c67266"), Code="The person has an alert indicator for a chronic medical/health condition.", SortOrder=0 },
            new RefMedicalAlertIndicator { Id=Guid.Parse("73daeff8-e551-420b-832d-f7256f320a35"), Code="The person has an alert indicator for an acute medical/health condition.", SortOrder=0 },
            new RefMedicalAlertIndicator { Id=Guid.Parse("a63de77e-bf1a-497b-b938-5da68a2a63a4"), Code="The person does not have an alert indicator for a medical/health condition.", SortOrder=0 },
       };
   }
}
