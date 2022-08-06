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
        public static List<RefGoalMeasurementType> RefGoalMeasurementTypeList = new List<RefGoalMeasurementType> =
        {
            new RefGoalMeasurementType { Id=Guid.Parse("946f7bce-b6d6-4ec1-9f03-22006e608529"), Code="Data charts are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", Description="Datacharts", Definition="", SortOrder=0 },
            new RefGoalMeasurementType { Id=Guid.Parse("2946d1fd-7750-43da-9b9a-b3210abc8396"), Code="Observation log is specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", Description="Observationlog", Definition="", SortOrder=0 },
            new RefGoalMeasurementType { Id=Guid.Parse("a66d5773-a650-4c45-8c2c-f97e0ee1155f"), Code="The type of evidence appropriate for assessing achievement of a goal or short-term objective is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
            new RefGoalMeasurementType { Id=Guid.Parse("8d45c970-8182-48e3-a348-860a30a2d995"), Code="Tests are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", Description="Tests", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefGoalMeasurementType Pick List
         /// </summary>
        public static List<RefGoalMeasurementType> RefGoalMeasurementTypePickList = new List<RefGoalMeasurementType> =
        {
            new RefGoalMeasurementType { Id=Guid.Parse("946f7bce-b6d6-4ec1-9f03-22006e608529"), Code="Data charts are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=0 },
            new RefGoalMeasurementType { Id=Guid.Parse("2946d1fd-7750-43da-9b9a-b3210abc8396"), Code="Observation log is specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=0 },
            new RefGoalMeasurementType { Id=Guid.Parse("a66d5773-a650-4c45-8c2c-f97e0ee1155f"), Code="The type of evidence appropriate for assessing achievement of a goal or short-term objective is in a category not yet defined in CEDS.", SortOrder=0 },
            new RefGoalMeasurementType { Id=Guid.Parse("8d45c970-8182-48e3-a348-860a30a2d995"), Code="Tests are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=0 },
       };
   }
}
