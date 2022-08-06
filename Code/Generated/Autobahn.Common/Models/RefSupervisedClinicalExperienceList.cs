//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSupervisedClinicalExperienceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSupervisedClinicalExperience Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSupervisedClinicalExperience"> List
         /// </summary>
        public static List<RefSupervisedClinicalExperience> RefSupervisedClinicalExperienceList = new List<RefSupervisedClinicalExperience>
        {
            new RefSupervisedClinicalExperience { Id=Guid.Parse("253b65c7-972e-4f96-be0f-3e0161361341"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("6e51f0fa-dfa9-4cd2-bed0-77ce757b42b5"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("4d1839fb-b155-40a7-8840-2fc661bf93f7"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefSupervisedClinicalExperience Pick List
         /// </summary>
        public static List<RefSupervisedClinicalExperience> RefSupervisedClinicalExperiencePickList = new List<RefSupervisedClinicalExperience>
        {
            new RefSupervisedClinicalExperience { Id=Guid.Parse("253b65c7-972e-4f96-be0f-3e0161361341"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("6e51f0fa-dfa9-4cd2-bed0-77ce757b42b5"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("4d1839fb-b155-40a7-8840-2fc661bf93f7"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
