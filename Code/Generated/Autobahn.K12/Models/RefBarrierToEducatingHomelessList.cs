//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefBarrierToEducatingHomelessList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefBarrierToEducatingHomeless Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBarrierToEducatingHomelessModel"> List
         /// </summary>
        public static List<RefBarrierToEducatingHomelessModel> RefBarrierToEducatingHomelessList = new List<RefBarrierToEducatingHomelessModel>
        {
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("dfaad4ea-5ceb-4ce1-b770-1e9183ff9597"), Code="Eligibility", Description="Eligibility for homeless services", Definition="Eligibility for homeless services is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("b8355180-4662-43d3-92d3-8c93e0073bdf"), Code="SchoolSelection", Description="School selection", Definition="School selection is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("ef4509cd-72fa-4b0e-9714-816394cb281e"), Code="Transportation", Description="Transportation", Definition="Transportation is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("b0a9897b-8ee4-40be-bd98-5c0ba6c4985e"), Code="SchoolRecords", Description="School records", Definition="School records is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("2ba6c837-06df-4ad8-be41-5cd2994fd537"), Code="Immunizations", Description="Immunizations", Definition="Immunizations is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("5f9b39c2-2d86-45f2-a810-53304d2ec7e4"), Code="OtherMedicalRecords", Description="Other medical records", Definition="Other medical records is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("0f122e6c-4663-4e22-b4c3-4a9c24f0c673"), Code="OtherBarriers", Description="Other barriers", Definition="Other barriers is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefBarrierToEducatingHomeless Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBarrierToEducatingHomelessViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("dfaad4ea-5ceb-4ce1-b770-1e9183ff9597"), Description="Eligibility for homeless services", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("b8355180-4662-43d3-92d3-8c93e0073bdf"), Description="School selection", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("ef4509cd-72fa-4b0e-9714-816394cb281e"), Description="Transportation", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("b0a9897b-8ee4-40be-bd98-5c0ba6c4985e"), Description="School records", SortOrder=Convert.ToDecimal("4.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("2ba6c837-06df-4ad8-be41-5cd2994fd537"), Description="Immunizations", SortOrder=Convert.ToDecimal("5.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("5f9b39c2-2d86-45f2-a810-53304d2ec7e4"), Description="Other medical records", SortOrder=Convert.ToDecimal("6.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("0f122e6c-4663-4e22-b4c3-4a9c24f0c673"), Description="Other barriers", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
