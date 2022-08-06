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
        public static List<RefTuitionResidencyType> RefTuitionResidencyTypeList = new List<RefTuitionResidencyType> =
        {
            new RefTuitionResidencyType { Id=Guid.Parse("24042ddc-2ca4-4df7-bea5-ee71ea07ff6a"), Code="The person's residency status for tuition purposes is: In-district.", Description="InDistrict", Definition="", SortOrder=0 },
            new RefTuitionResidencyType { Id=Guid.Parse("38428afe-f31e-4dbc-8b78-d8d0d6eb37d8"), Code="The person's residency status for tuition purposes is: In-state.", Description="InState", Definition="", SortOrder=0 },
            new RefTuitionResidencyType { Id=Guid.Parse("e64fc440-a6ac-46e3-b19a-81e378a55a43"), Code="The person's residency status for tuition purposes is: Out-of-state.", Description="OutOfState", Definition="", SortOrder=0 },
            new RefTuitionResidencyType { Id=Guid.Parse("d8de66a4-1c72-4864-8509-b2dbe4190456"), Code="No differential tuition based on residency is provided.", Description="NoDifferential", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTuitionResidencyType Pick List
         /// </summary>
        public static List<RefTuitionResidencyType> RefTuitionResidencyTypePickList = new List<RefTuitionResidencyType> =
        {
            new RefTuitionResidencyType { Id=Guid.Parse("24042ddc-2ca4-4df7-bea5-ee71ea07ff6a"), Code="The person's residency status for tuition purposes is: In-district.", SortOrder=0 },
            new RefTuitionResidencyType { Id=Guid.Parse("38428afe-f31e-4dbc-8b78-d8d0d6eb37d8"), Code="The person's residency status for tuition purposes is: In-state.", SortOrder=0 },
            new RefTuitionResidencyType { Id=Guid.Parse("e64fc440-a6ac-46e3-b19a-81e378a55a43"), Code="The person's residency status for tuition purposes is: Out-of-state.", SortOrder=0 },
            new RefTuitionResidencyType { Id=Guid.Parse("d8de66a4-1c72-4864-8509-b2dbe4190456"), Code="No differential tuition based on residency is provided.", SortOrder=0 },
       };
   }
}
