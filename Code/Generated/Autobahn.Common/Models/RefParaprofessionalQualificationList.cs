//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParaprofessionalQualificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefParaprofessionalQualification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefParaprofessionalQualification"> List
         /// </summary>
        public static List<RefParaprofessionalQualification> RefParaprofessionalQualificationList = new List<RefParaprofessionalQualification>
        {
            new RefParaprofessionalQualification { Id=Guid.Parse("ab420bae-457a-421a-a362-acb20eb62cee"), Code="Qualified", Description="Qualified", Definition="The paraprofessional is qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("1.00") },
            new RefParaprofessionalQualification { Id=Guid.Parse("105c0267-8510-4263-a77f-f90c8600f59f"), Code="NotQualified", Description="Not Qualified", Definition="The paraprofessional is NOT qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefParaprofessionalQualification Pick List
         /// </summary>
        public static List<RefParaprofessionalQualification> RefParaprofessionalQualificationPickList = new List<RefParaprofessionalQualification>
        {
            new RefParaprofessionalQualification { Id=Guid.Parse("ab420bae-457a-421a-a362-acb20eb62cee"), Code="Qualified", Description="Qualified", SortOrder=Convert.ToDecimal("1.00") },
            new RefParaprofessionalQualification { Id=Guid.Parse("105c0267-8510-4263-a77f-f90c8600f59f"), Code="NotQualified", Description="Not Qualified", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
