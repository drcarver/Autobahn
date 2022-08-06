//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGoalStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGoalStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGoalStatusType"> List
         /// </summary>
        public static List<RefGoalStatusType> RefGoalStatusTypeList = new List<RefGoalStatusType>
        {
            new RefGoalStatusType { Id=Guid.Parse("08731976-d418-46e2-9e83-e2c8ecff95a8"), Code="Completed", Description="Completed", Definition="Completed is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("ce1584e1-0887-4f43-807e-f9f29cbbe08d"), Code="Other", Description="Other", Definition="The status toward achievement of the annual goal or short-term objectives is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("426c0246-95fa-44e2-8ba3-134723684743"), Code="SatisfactoryProgress", Description="Satisfactory Progress", Definition="Satisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("f755491b-c143-4a7b-8a4a-c7ff538b3dd9"), Code="UnsatisfactoryProgress", Description="Unsatisfactory Progress", Definition="Unsatisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefGoalStatusType Pick List
         /// </summary>
        public static List<RefGoalStatusType> RefGoalStatusTypePickList = new List<RefGoalStatusType>
        {
            new RefGoalStatusType { Id=Guid.Parse("08731976-d418-46e2-9e83-e2c8ecff95a8"), Code="Completed", Description="Completed", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("ce1584e1-0887-4f43-807e-f9f29cbbe08d"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("426c0246-95fa-44e2-8ba3-134723684743"), Code="SatisfactoryProgress", Description="Satisfactory Progress", SortOrder=Convert.ToDecimal("") },
            new RefGoalStatusType { Id=Guid.Parse("f755491b-c143-4a7b-8a4a-c7ff538b3dd9"), Code="UnsatisfactoryProgress", Description="Unsatisfactory Progress", SortOrder=Convert.ToDecimal("") },
       };
   }
}
