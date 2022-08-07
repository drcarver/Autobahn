//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefAcademicHonorTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefAcademicHonorType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicHonorTypeModel"> List
         /// </summary>
        public static List<RefAcademicHonorTypeModel> RefAcademicHonorTypeList = new List<RefAcademicHonorTypeModel>
        {
            new RefAcademicHonorType { Id=Guid.Parse("498a9d35-d9ce-46eb-9797-ab614153d072"), Code="01985", Description="Honor roll", Definition="Honor roll is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9a01273e-84ef-40f1-b764-89273a0fca65"), Code="01986", Description="Honor society", Definition="Honor society is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicHonorType { Id=Guid.Parse("8efea276-b5c7-44e6-8cc0-54509ca380fc"), Code="01987", Description="Honorable mention", Definition="Honorable mention is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9557c6fb-45ab-45d3-a38f-df7cbdfa5b98"), Code="01988", Description="Honors program", Definition="Honors program is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("6ed2709f-487a-40a9-844c-a1fb9f62600f"), Code="73064", Description="National Technical Education Honor Society", Definition="National Technical Education Honor Society is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("599f3586-517e-4acc-8ea0-7ed43bce9322"), Code="01989", Description="Prize awards", Definition="Prize awards is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicHonorType { Id=Guid.Parse("b88539d2-f59e-4522-968e-a035dbd85404"), Code="01991", Description="Scholarships", Definition="Scholarships is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicHonorType { Id=Guid.Parse("730c31d2-b8a2-4e02-9151-cf63fc862382"), Code="00738", Description="Awarding of units of value", Definition="Awarding of units of value is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicHonorType { Id=Guid.Parse("cb01968c-3a02-4ac3-a70f-8b6ce7a4d057"), Code="00740", Description="Citizenship award/recognition", Definition="Citizenship award/recognition is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicHonorType { Id=Guid.Parse("8e797994-f055-4407-a0ce-410c1c646090"), Code="00741", Description="Completion of requirement, but no units of value awarded", Definition="Completion of requirement, but no units of value awarded is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicHonorType { Id=Guid.Parse("d786f04e-bb00-487a-a5a7-45d151b69b1c"), Code="08692", Description="Attendance award", Definition="Attendance award is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicHonorType { Id=Guid.Parse("fda540d2-4d69-44f3-a956-0b25ab7f0c00"), Code="00742", Description="Certificate", Definition="Certificate is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAcademicHonorType { Id=Guid.Parse("10158790-5f2a-4585-b320-2fd4d250ded0"), Code="02047", Description="Honor award", Definition="Honor award is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9f6f51df-e911-4d05-87b6-af5ac7ef1c78"), Code="00744", Description="Letter of student commendation", Definition="Letter of student commendation is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAcademicHonorType { Id=Guid.Parse("30810b2f-33f7-43df-b81d-1df1775a9c62"), Code="00745", Description="Medals", Definition="Medals is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9c8c0c83-7c75-4844-bf55-5186fd52f62c"), Code="08693", Description="National Merit scholar", Definition="National Merit scholar is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAcademicHonorType { Id=Guid.Parse("aa413d8b-86a7-4ad5-ad7b-139536cca9ad"), Code="00747", Description="Points", Definition="Points is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicHonorType { Id=Guid.Parse("8f6099e1-f97c-4172-9d42-24c50665a926"), Code="00748", Description="Promotion or advancement", Definition="Promotion or advancement is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("17.00") },
            new RefAcademicHonorType { Id=Guid.Parse("cb21352e-fde7-4d09-b101-a7fd70584158"), Code="09999", Description="Other", Definition="Other is specified as the type of academic distinctions earned by or awarded to the student.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The Reference RefAcademicHonorType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAcademicHonorTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAcademicHonorType { Id=Guid.Parse("498a9d35-d9ce-46eb-9797-ab614153d072"), Description="Honor roll", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9a01273e-84ef-40f1-b764-89273a0fca65"), Description="Honor society", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicHonorType { Id=Guid.Parse("8efea276-b5c7-44e6-8cc0-54509ca380fc"), Description="Honorable mention", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9557c6fb-45ab-45d3-a38f-df7cbdfa5b98"), Description="Honors program", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("6ed2709f-487a-40a9-844c-a1fb9f62600f"), Description="National Technical Education Honor Society", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicHonorType { Id=Guid.Parse("599f3586-517e-4acc-8ea0-7ed43bce9322"), Description="Prize awards", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicHonorType { Id=Guid.Parse("b88539d2-f59e-4522-968e-a035dbd85404"), Description="Scholarships", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicHonorType { Id=Guid.Parse("730c31d2-b8a2-4e02-9151-cf63fc862382"), Description="Awarding of units of value", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicHonorType { Id=Guid.Parse("cb01968c-3a02-4ac3-a70f-8b6ce7a4d057"), Description="Citizenship award/recognition", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicHonorType { Id=Guid.Parse("8e797994-f055-4407-a0ce-410c1c646090"), Description="Completion of requirement, but no units of value awarded", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicHonorType { Id=Guid.Parse("d786f04e-bb00-487a-a5a7-45d151b69b1c"), Description="Attendance award", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicHonorType { Id=Guid.Parse("fda540d2-4d69-44f3-a956-0b25ab7f0c00"), Description="Certificate", SortOrder=Convert.ToDecimal("11.00") },
            new RefAcademicHonorType { Id=Guid.Parse("10158790-5f2a-4585-b320-2fd4d250ded0"), Description="Honor award", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9f6f51df-e911-4d05-87b6-af5ac7ef1c78"), Description="Letter of student commendation", SortOrder=Convert.ToDecimal("13.00") },
            new RefAcademicHonorType { Id=Guid.Parse("30810b2f-33f7-43df-b81d-1df1775a9c62"), Description="Medals", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicHonorType { Id=Guid.Parse("9c8c0c83-7c75-4844-bf55-5186fd52f62c"), Description="National Merit scholar", SortOrder=Convert.ToDecimal("15.00") },
            new RefAcademicHonorType { Id=Guid.Parse("aa413d8b-86a7-4ad5-ad7b-139536cca9ad"), Description="Points", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicHonorType { Id=Guid.Parse("8f6099e1-f97c-4172-9d42-24c50665a926"), Description="Promotion or advancement", SortOrder=Convert.ToDecimal("17.00") },
            new RefAcademicHonorType { Id=Guid.Parse("cb21352e-fde7-4d09-b101-a7fd70584158"), Description="Other", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
