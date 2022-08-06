//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefGoalMeasurementTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefGoalMeasurementType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGoalMeasurementType"> List
         /// </summary>
        public static List<RefGoalMeasurementType> RefGoalMeasurementTypeList = new List<RefGoalMeasurementType>
        {
            new RefGoalMeasurementType { Id=Guid.Parse("22d8ac7d-3145-46a3-bec5-b727fc028696"), Code="Datacharts", Description="Data charts", Definition="Data charts are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("f2b562ca-148c-4b5a-912e-6f242a7ea1a9"), Code="Observationlog", Description="Observation log", Definition="Observation log is specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("b4395096-3491-4a65-9980-1af4d3c2d03d"), Code="Other", Description="Other", Definition="The type of evidence appropriate for assessing achievement of a goal or short-term objective is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("bac024b3-0c98-42a5-b1b5-02dcfc7b91d6"), Code="Tests", Description="Tests", Definition="Tests are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefGoalMeasurementType Pick List
         /// </summary>
        public static List<RefGoalMeasurementType> RefGoalMeasurementTypePickList = new List<RefGoalMeasurementType>
        {
            new RefGoalMeasurementType { Id=Guid.Parse("22d8ac7d-3145-46a3-bec5-b727fc028696"), Code="Datacharts", Description="Data charts", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("f2b562ca-148c-4b5a-912e-6f242a7ea1a9"), Code="Observationlog", Description="Observation log", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("b4395096-3491-4a65-9980-1af4d3c2d03d"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("bac024b3-0c98-42a5-b1b5-02dcfc7b91d6"), Code="Tests", Description="Tests", SortOrder=Convert.ToDecimal("") },
       };
   }
}
