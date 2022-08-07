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
        /// The complete <see cref="RefGoalMeasurementTypeModel"> List
         /// </summary>
        public static List<RefGoalMeasurementTypeModel> RefGoalMeasurementTypeList = new List<RefGoalMeasurementTypeModel>
        {
            new RefGoalMeasurementType { Id=Guid.Parse("c7c70df0-9dba-4f93-b406-a4278e1cdd7a"), Code="Datacharts", Description="Data charts", Definition="Data charts are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("6062cc2b-21af-4e25-9ef2-68e0ea144408"), Code="Observationlog", Description="Observation log", Definition="Observation log is specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("4f864141-5583-42a5-8e5a-d18424ed4164"), Code="Other", Description="Other", Definition="The type of evidence appropriate for assessing achievement of a goal or short-term objective is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("1a558ce9-2319-4ccc-8ebc-136302872f0a"), Code="Tests", Description="Tests", Definition="Tests are specified as the type of evidence appropriate for assessing achievement of a goal or short-term objective.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefGoalMeasurementType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefGoalMeasurementTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefGoalMeasurementType { Id=Guid.Parse("c7c70df0-9dba-4f93-b406-a4278e1cdd7a"), Description="Data charts", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("6062cc2b-21af-4e25-9ef2-68e0ea144408"), Description="Observation log", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("4f864141-5583-42a5-8e5a-d18424ed4164"), Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefGoalMeasurementType { Id=Guid.Parse("1a558ce9-2319-4ccc-8ebc-136302872f0a"), Description="Tests", SortOrder=Convert.ToDecimal("") },
       };
   }
}
