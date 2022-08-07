//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefActivityRecognitionTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefActivityRecognitionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefActivityRecognitionTypeModel"> List
         /// </summary>
        public static List<RefActivityRecognitionTypeModel> RefActivityRecognitionTypeList = new List<RefActivityRecognitionTypeModel>
        {
            new RefActivityRecognitionType { Id=Guid.Parse("2cd8c504-a3ef-4080-bb15-224c8692dd90"), Code="00737", Description="Athletic awards", Definition="Athletic award was given to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("1.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("8444b101-12c7-4cd1-9b96-da3556c82f18"), Code="00738", Description="Awarding of units of value", Definition="Awarding of units of value was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("2.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("f0f5acff-27b0-44b7-90dd-440d7950d073"), Code="00740", Description="Citizenship award/recognition", Definition="Citizenship award/recognition was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("3.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("a6fa7147-2a1b-40af-b54b-ee3585c24f24"), Code="00741", Description="Completion of requirement, but no units of value awarded", Definition="Completion of requirement, but no units of value awarded  to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("4.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("20f23590-8bd9-4469-91d3-c26de8876ef4"), Code="00742", Description="Certificate", Definition="Certificate was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("5.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("b6e41aab-415c-4d98-a3e3-fc0d4854be6b"), Code="00743", Description="Honor award", Definition="Honor award was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("6.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("005eb5e5-a5c8-44fb-8696-d023e69d39fe"), Code="02048", Description="Letter of commendation", Definition="Letter of commendation was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("7.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("0e0e4afd-c855-4291-afb6-1182d671d0b6"), Code="00745", Description="Medals", Definition="A medal was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("8.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("9852cd85-e43f-4217-a206-73683c5dbfbb"), Code="00746", Description="Monogram/letter", Definition="A monogram/letter was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("9.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("8c735c01-fe01-4ead-bf69-7c96275ce084"), Code="00747", Description="Points", Definition="Points were awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("10.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("dcbfb51f-4319-412f-b8e3-35db0199cc0b"), Code="00748", Description="Promotion or advancement", Definition="Promotion or advancement was awarded to the student for accomplishments in a co-curricular, or extra-curricular activity.", SortOrder=Convert.ToDecimal("11.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("92ff4bbd-9ec2-4aba-8f80-3e0b7046b158"), Code="09999", Description="Other", Definition="The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefActivityRecognitionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefActivityRecognitionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefActivityRecognitionType { Id=Guid.Parse("2cd8c504-a3ef-4080-bb15-224c8692dd90"), Description="Athletic awards", SortOrder=Convert.ToDecimal("1.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("8444b101-12c7-4cd1-9b96-da3556c82f18"), Description="Awarding of units of value", SortOrder=Convert.ToDecimal("2.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("f0f5acff-27b0-44b7-90dd-440d7950d073"), Description="Citizenship award/recognition", SortOrder=Convert.ToDecimal("3.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("a6fa7147-2a1b-40af-b54b-ee3585c24f24"), Description="Completion of requirement, but no units of value awarded", SortOrder=Convert.ToDecimal("4.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("20f23590-8bd9-4469-91d3-c26de8876ef4"), Description="Certificate", SortOrder=Convert.ToDecimal("5.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("b6e41aab-415c-4d98-a3e3-fc0d4854be6b"), Description="Honor award", SortOrder=Convert.ToDecimal("6.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("005eb5e5-a5c8-44fb-8696-d023e69d39fe"), Description="Letter of commendation", SortOrder=Convert.ToDecimal("7.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("0e0e4afd-c855-4291-afb6-1182d671d0b6"), Description="Medals", SortOrder=Convert.ToDecimal("8.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("9852cd85-e43f-4217-a206-73683c5dbfbb"), Description="Monogram/letter", SortOrder=Convert.ToDecimal("9.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("8c735c01-fe01-4ead-bf69-7c96275ce084"), Description="Points", SortOrder=Convert.ToDecimal("10.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("dcbfb51f-4319-412f-b8e3-35db0199cc0b"), Description="Promotion or advancement", SortOrder=Convert.ToDecimal("11.00") },
            new RefActivityRecognitionType { Id=Guid.Parse("92ff4bbd-9ec2-4aba-8f80-3e0b7046b158"), Description="Other", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
