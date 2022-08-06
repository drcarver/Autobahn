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
        public static List<RefSupervisedClinicalExperience> RefSupervisedClinicalExperienceList = new List<RefSupervisedClinicalExperience> =
        {
            new RefSupervisedClinicalExperience { Id=Guid.Parse("07fd6b4d-a49e-41fe-b2a7-1f56c3d0de80"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("44660b67-6c03-4608-afb2-6ba1c8234624"), Code="", Description="No", Definition="", SortOrder=0 },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("a02c026a-54d0-4d78-8d9b-ae6f7e4f9608"), Code="", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSupervisedClinicalExperience Pick List
         /// </summary>
        public static List<RefSupervisedClinicalExperience> RefSupervisedClinicalExperiencePickList = new List<RefSupervisedClinicalExperience> =
        {
            new RefSupervisedClinicalExperience { Id=Guid.Parse("07fd6b4d-a49e-41fe-b2a7-1f56c3d0de80"), Code="", SortOrder=0 },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("44660b67-6c03-4608-afb2-6ba1c8234624"), Code="", SortOrder=0 },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("a02c026a-54d0-4d78-8d9b-ae6f7e4f9608"), Code="", SortOrder=0 },
       };
   }
}
