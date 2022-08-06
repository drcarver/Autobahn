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
        /// The complete <see cref="RefBarrierToEducatingHomeless"> List
         /// </summary>
        public static List<RefBarrierToEducatingHomeless> RefBarrierToEducatingHomelessList = new List<RefBarrierToEducatingHomeless>
        {
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("60428f5e-f475-4905-a694-768612eda111"), Code="Eligibility", Description="Eligibility for homeless services", Definition="Eligibility for homeless services is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("4bb9cbfb-8b48-4a2b-9560-95027585d8e5"), Code="SchoolSelection", Description="School selection", Definition="School selection is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("433e5ac1-be17-496d-81ea-34130a2a797f"), Code="Transportation", Description="Transportation", Definition="Transportation is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("ea59127f-7645-4071-8e1f-c6e235e397f9"), Code="SchoolRecords", Description="School records", Definition="School records is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("e1450921-6415-4dc6-9b9a-56a99fd55968"), Code="Immunizations", Description="Immunizations", Definition="Immunizations is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("2a6bff9a-c8d2-4e2f-9775-918ba69d460a"), Code="OtherMedicalRecords", Description="Other medical records", Definition="Other medical records is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("35f1c42c-84cd-497b-98f6-4fdccc6ccce2"), Code="OtherBarriers", Description="Other barriers", Definition="Other barriers is specified as a barrier to the enrollment and success of a homeless child or youth.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefBarrierToEducatingHomeless Pick List
         /// </summary>
        public static List<RefBarrierToEducatingHomeless> RefBarrierToEducatingHomelessPickList = new List<RefBarrierToEducatingHomeless>
        {
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("60428f5e-f475-4905-a694-768612eda111"), Code="Eligibility", Description="Eligibility for homeless services", SortOrder=Convert.ToDecimal("1.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("4bb9cbfb-8b48-4a2b-9560-95027585d8e5"), Code="SchoolSelection", Description="School selection", SortOrder=Convert.ToDecimal("2.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("433e5ac1-be17-496d-81ea-34130a2a797f"), Code="Transportation", Description="Transportation", SortOrder=Convert.ToDecimal("3.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("ea59127f-7645-4071-8e1f-c6e235e397f9"), Code="SchoolRecords", Description="School records", SortOrder=Convert.ToDecimal("4.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("e1450921-6415-4dc6-9b9a-56a99fd55968"), Code="Immunizations", Description="Immunizations", SortOrder=Convert.ToDecimal("5.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("2a6bff9a-c8d2-4e2f-9775-918ba69d460a"), Code="OtherMedicalRecords", Description="Other medical records", SortOrder=Convert.ToDecimal("6.00") },
            new RefBarrierToEducatingHomeless { Id=Guid.Parse("35f1c42c-84cd-497b-98f6-4fdccc6ccce2"), Code="OtherBarriers", Description="Other barriers", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
