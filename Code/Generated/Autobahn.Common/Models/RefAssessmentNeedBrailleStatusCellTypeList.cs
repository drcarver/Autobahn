//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAssessmentNeedBrailleStatusCellTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedBrailleStatusCellType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedBrailleStatusCellType"> List
         /// </summary>
        public static List<RefAssessmentNeedBrailleStatusCellType> RefAssessmentNeedBrailleStatusCellTypeList = new List<RefAssessmentNeedBrailleStatusCellType>
        {
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("23d722ff-e4b7-4034-906a-d640e4f1015e"), Code="Off", Description="Off", Definition="Defines as part of an Assessment Personal Needs Profile the preferred presence of a Braille display status cell set to Off.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("f33572ca-59fa-4d17-8b7c-307847140919"), Code="Left", Description="Left", Definition="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell set to Left.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("5220f50c-5b55-483f-890b-96ce0d001068"), Code="Right", Description="Right", Definition="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell Right.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedBrailleStatusCellType Pick List
         /// </summary>
        public static List<RefAssessmentNeedBrailleStatusCellType> RefAssessmentNeedBrailleStatusCellTypePickList = new List<RefAssessmentNeedBrailleStatusCellType>
        {
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("23d722ff-e4b7-4034-906a-d640e4f1015e"), Code="Off", Description="Off", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("f33572ca-59fa-4d17-8b7c-307847140919"), Code="Left", Description="Left", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("5220f50c-5b55-483f-890b-96ce0d001068"), Code="Right", Description="Right", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
