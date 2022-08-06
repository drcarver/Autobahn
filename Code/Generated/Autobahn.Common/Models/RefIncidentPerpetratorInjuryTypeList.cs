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
        public static List<RefIncidentPerpetratorInjuryType> RefIncidentPerpetratorInjuryTypeList = new List<RefIncidentPerpetratorInjuryType>
        {
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("c21d33a5-1997-4a58-8f7d-7cf7a5aa7bc4"), Code="MajorInjury", Description="Major injury", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("0dc255cc-6473-47da-b730-dd623f64e5f5"), Code="MinorInjury", Description="Minor injury", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("9e5084b9-2fdd-405c-8edc-1b6ad1f08d8f"), Code="NoInjury", Description="No injury", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("5b8bbde1-de3a-4471-8003-a407dfb90cdd"), Code="SeriousBodilyInjury", Description="Serious bodily injury", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("92b1239e-81b6-4ee9-aac7-99c8089b457f"), Code="FatalInjury", Description="Fatal injury", Definition="", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefIncidentPerpetratorInjuryType Pick List
         /// </summary>
        public static List<RefIncidentPerpetratorInjuryType> RefIncidentPerpetratorInjuryTypePickList = new List<RefIncidentPerpetratorInjuryType>
        {
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("c21d33a5-1997-4a58-8f7d-7cf7a5aa7bc4"), Code="MajorInjury", Description="Major injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("0dc255cc-6473-47da-b730-dd623f64e5f5"), Code="MinorInjury", Description="Minor injury", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("9e5084b9-2fdd-405c-8edc-1b6ad1f08d8f"), Code="NoInjury", Description="No injury", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("5b8bbde1-de3a-4471-8003-a407dfb90cdd"), Code="SeriousBodilyInjury", Description="Serious bodily injury", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("92b1239e-81b6-4ee9-aac7-99c8089b457f"), Code="FatalInjury", Description="Fatal injury", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
