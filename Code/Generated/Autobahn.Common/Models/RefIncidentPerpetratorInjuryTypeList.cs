//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentPerpetratorInjuryTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentPerpetratorInjuryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentPerpetratorInjuryType"> List
         /// </summary>
        public static List<RefIncidentPerpetratorInjuryType> RefIncidentPerpetratorInjuryTypeList = new List<RefIncidentPerpetratorInjuryType> =
        {
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("c9177d69-0060-4f7e-8afc-c7eea6397294"), Code="", Description="MajorInjury", Definition="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("b77b3a1d-7cf9-4c0a-9753-a2f6f8e3bd4f"), Code="", Description="MinorInjury", Definition="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("0d2e6b05-d1bd-4833-ac76-94b684165e19"), Code="", Description="NoInjury", Definition="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("dfb19f86-8588-4e92-8fc0-c90367b775a5"), Code="", Description="SeriousBodilyInjury", Definition="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("a705b6a8-7a39-478c-89f5-3de6dac53f4c"), Code="", Description="FatalInjury", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIncidentPerpetratorInjuryType Pick List
         /// </summary>
        public static List<RefIncidentPerpetratorInjuryType> RefIncidentPerpetratorInjuryTypePickList = new List<RefIncidentPerpetratorInjuryType> =
        {
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("c9177d69-0060-4f7e-8afc-c7eea6397294"), Code="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("b77b3a1d-7cf9-4c0a-9753-a2f6f8e3bd4f"), Code="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("0d2e6b05-d1bd-4833-ac76-94b684165e19"), Code="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("dfb19f86-8588-4e92-8fc0-c90367b775a5"), Code="", SortOrder=0 },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("a705b6a8-7a39-478c-89f5-3de6dac53f4c"), Code="", SortOrder=0 },
       };
   }
}
