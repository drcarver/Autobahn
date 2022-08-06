//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTuitionResidencyTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTuitionResidencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTuitionResidencyType"> List
         /// </summary>
        public static List<RefTuitionResidencyType> RefTuitionResidencyTypeList = new List<RefTuitionResidencyType>
        {
            new RefTuitionResidencyType { Id=Guid.Parse("c8d34401-7122-4192-a568-4a8514609020"), Code="InDistrict", Description="In-district", Definition="The person's residency status for tuition purposes is: In-district.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("b766dbea-434d-43a8-b8fa-280ff92b061c"), Code="InState", Description="In-state", Definition="The person's residency status for tuition purposes is: In-state.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("2abb9ec1-9a5d-4be2-8df9-a757bf280cf5"), Code="OutOfState", Description="Out-of-state", Definition="The person's residency status for tuition purposes is: Out-of-state.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("ed99a945-f48c-4171-a86c-2633c1fb7357"), Code="NoDifferential", Description="No differential tuition based on residency", Definition="No differential tuition based on residency is provided.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefTuitionResidencyType Pick List
         /// </summary>
        public static List<RefTuitionResidencyType> RefTuitionResidencyTypePickList = new List<RefTuitionResidencyType>
        {
            new RefTuitionResidencyType { Id=Guid.Parse("c8d34401-7122-4192-a568-4a8514609020"), Code="InDistrict", Description="In-district", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("b766dbea-434d-43a8-b8fa-280ff92b061c"), Code="InState", Description="In-state", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("2abb9ec1-9a5d-4be2-8df9-a757bf280cf5"), Code="OutOfState", Description="Out-of-state", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("ed99a945-f48c-4171-a86c-2633c1fb7357"), Code="NoDifferential", Description="No differential tuition based on residency", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
