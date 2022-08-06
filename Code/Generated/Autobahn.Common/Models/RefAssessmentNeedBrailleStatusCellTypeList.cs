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
        public static List<RefAssessmentNeedBrailleStatusCellType> RefAssessmentNeedBrailleStatusCellTypeList = new List<RefAssessmentNeedBrailleStatusCellType> =
        {
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("db38814f-5b22-4991-935a-0ad71e9b6d4c"), Code="Defines as part of an Assessment Personal Needs Profile the preferred presence of a Braille display status cell set to Off.", Description="Off", Definition="", SortOrder=0 },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("87a2c04f-5af7-4f53-944d-f7499ae64b96"), Code="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell set to Left.", Description="Left", Definition="", SortOrder=0 },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("6bbef1b1-5b12-4a0e-b0e6-6b14187b8d3d"), Code="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell Right.", Description="Right", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedBrailleStatusCellType Pick List
         /// </summary>
        public static List<RefAssessmentNeedBrailleStatusCellType> RefAssessmentNeedBrailleStatusCellTypePickList = new List<RefAssessmentNeedBrailleStatusCellType> =
        {
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("db38814f-5b22-4991-935a-0ad71e9b6d4c"), Code="Defines as part of an Assessment Personal Needs Profile the preferred presence of a Braille display status cell set to Off.", SortOrder=0 },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("87a2c04f-5af7-4f53-944d-f7499ae64b96"), Code="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell set to Left.", SortOrder=0 },
            new RefAssessmentNeedBrailleStatusCellType { Id=Guid.Parse("6bbef1b1-5b12-4a0e-b0e6-6b14187b8d3d"), Code="Defines as part of an Assessment Personal Needs Profile the preferred location of a Braille display status cell Right.", SortOrder=0 },
       };
   }
}
