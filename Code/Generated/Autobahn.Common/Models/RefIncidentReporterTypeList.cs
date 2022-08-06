//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentReporterTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentReporterType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentReporterType"> List
         /// </summary>
        public static List<RefIncidentReporterType> RefIncidentReporterTypeList = new List<RefIncidentReporterType>
        {
            new RefIncidentReporterType { Id=Guid.Parse("8b76619d-cfb5-4dcf-9591-ca6364dd7032"), Code="00126", Description="Student", Definition="Student reported the incident.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentReporterType { Id=Guid.Parse("2b0ebd70-20ff-4ec2-9f77-c69724fcb382"), Code="03032", Description="Student enrolled in the school where the incident occurred", Definition="Student enrolled in the school where the incident occurred reported the incident.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentReporterType { Id=Guid.Parse("ed3f160c-cb47-4339-a9ab-b72ff229f6fa"), Code="03033", Description="Student enrolled in another school", Definition="Student enrolled in another school reported the incident.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentReporterType { Id=Guid.Parse("bffd7989-dd20-45e1-9d48-188327dfaa48"), Code="03034", Description="Student expelled or involuntarily withdrawn", Definition="Student expelled or involuntarily withdrawn reported the incident.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentReporterType { Id=Guid.Parse("ed3f195d-2454-4215-b000-3e07b6c54bee"), Code="03422", Description="Staff member", Definition="Staff member reported the incident.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentReporterType { Id=Guid.Parse("25dc9e03-381e-4cc2-a894-e4167d3871f5"), Code="03035", Description="Professional educational staff", Definition="Professional educational staff reported the incident.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentReporterType { Id=Guid.Parse("5cce835c-311c-4d7c-ae72-079c2a67a4ea"), Code="04732", Description="Teacher", Definition="Teacher reported the incident.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentReporterType { Id=Guid.Parse("bfca3c2d-9138-4070-a07a-0a5158c94343"), Code="13782", Description="Substitute teacher", Definition="Substitute teacher reported the incident.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentReporterType { Id=Guid.Parse("cd6ac254-1c23-4e80-b3af-a39d64d60fb5"), Code="13335", Description="Librarians/Media Specialist", Definition="Librarians/Media Specialist reported the incident.", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d2015fab-ba6a-4e2d-b345-324649830c5b"), Code="04725", Description="Counselor", Definition="Counselor reported the incident.", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentReporterType { Id=Guid.Parse("efa0cb8b-58d5-498f-90f2-826550027cbf"), Code="13334", Description="School Counselor", Definition="School Counselor", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d386af8a-182a-4e07-bb1c-ff23041c9a19"), Code="04723", Description="Athletic coach", Definition="Athletic coach reported the incident.", SortOrder=Convert.ToDecimal("12.00") },
            new RefIncidentReporterType { Id=Guid.Parse("aa6a6c70-a537-453c-8db8-be15d3d60084"), Code="04730", Description="Student activity advisor/non athletic coach", Definition="Student activity advisor/non athletic coach reported the incident.", SortOrder=Convert.ToDecimal("13.00") },
            new RefIncidentReporterType { Id=Guid.Parse("b193a5e6-b9af-4fda-9e14-891a7150ada8"), Code="13403", Description="Other Professional Staff", Definition="Other Professional Staff reported the incident.", SortOrder=Convert.ToDecimal("14.00") },
            new RefIncidentReporterType { Id=Guid.Parse("670d7090-5718-4014-bcf5-0e3091ff5f56"), Code="04783", Description="Registered nurse", Definition="Registered nurse reported the incident.", SortOrder=Convert.ToDecimal("15.00") },
            new RefIncidentReporterType { Id=Guid.Parse("cde74ab0-287f-4cc4-8521-a57a2c19749a"), Code="04788", Description="Social worker", Definition="Social worker reported the incident.", SortOrder=Convert.ToDecimal("16.00") },
            new RefIncidentReporterType { Id=Guid.Parse("18893433-b14e-4b09-8562-33a85248907a"), Code="03041", Description="Administrator", Definition="Administrator reported the incident.", SortOrder=Convert.ToDecimal("17.00") },
            new RefIncidentReporterType { Id=Guid.Parse("8db20b60-1a6d-4521-8ac8-241167185a6f"), Code="04718", Description="Principal/headmaster/headmistress/head of school", Definition="Principal/headmaster/headmistress/head of school reported the incident.", SortOrder=Convert.ToDecimal("18.00") },
            new RefIncidentReporterType { Id=Guid.Parse("f5710060-cb18-4d11-a368-06f06b63cf67"), Code="04711", Description="Deputy/associate/vice /assistant principal", Definition="Deputy/associate/vice /assistant principal reported the incident.", SortOrder=Convert.ToDecimal("19.00") },
            new RefIncidentReporterType { Id=Guid.Parse("6ab9ad1b-d18d-4b14-b26d-239f1b59711e"), Code="04710", Description="Dean/dean of instructions/dean of students/dean of boys/dean of girls/dean of student activities", Definition="Dean/dean of instructions/dean of students/dean of boys/dean of girls/dean of student activities reported the incident.", SortOrder=Convert.ToDecimal("20.00") },
            new RefIncidentReporterType { Id=Guid.Parse("fc48201b-4e9a-463e-8002-eab3cedfdd90"), Code="04721", Description="Superintendent/commissioner", Definition="Superintendent/commissioner reported the incident.", SortOrder=Convert.ToDecimal("21.00") },
            new RefIncidentReporterType { Id=Guid.Parse("2057e7fd-3856-4f05-b093-8a5b78fb1d16"), Code="04712", Description="Deputy/associate/assistant superintendent/ commissioner", Definition="Deputy/associate/assistant superintendent/ commissioner reported the incident.", SortOrder=Convert.ToDecimal("22.00") },
            new RefIncidentReporterType { Id=Guid.Parse("0cd78aa2-edfa-46a4-b0c2-00ff325b4fe9"), Code="04708", Description="Board of education/school board/board of trustees member", Definition="Board of education/school board/board of trustees member reported the incident.", SortOrder=Convert.ToDecimal("23.00") },
            new RefIncidentReporterType { Id=Guid.Parse("aca2481f-be71-4ef6-bcdc-bee989e469b0"), Code="13342", Description="All Other Support Staff", Definition="All Other Support Staff reported the incident.", SortOrder=Convert.ToDecimal("24.00") },
            new RefIncidentReporterType { Id=Guid.Parse("4da11e8e-bc41-43ed-8091-6c14067885ba"), Code="04864", Description="Bus driver", Definition="Bus driver reported the incident.", SortOrder=Convert.ToDecimal("25.00") },
            new RefIncidentReporterType { Id=Guid.Parse("12e1cd12-cce0-4c71-8365-6f9bc80f85b3"), Code="13340", Description="School Administrative Support Staff", Definition="School Administrative Support Staff reported the incident.", SortOrder=Convert.ToDecimal("26.00") },
            new RefIncidentReporterType { Id=Guid.Parse("e635daf6-34dc-42db-a288-0aaa0098b090"), Code="04878", Description="Custodian", Definition="Custodian reported the incident.", SortOrder=Convert.ToDecimal("27.00") },
            new RefIncidentReporterType { Id=Guid.Parse("6f7fd132-fbc8-4a7a-9cfa-4dc1c41983ba"), Code="04877", Description="Cook/food preparer (food service staff)", Definition="Cook/food preparer (food service staff) reported the incident.", SortOrder=Convert.ToDecimal("28.00") },
            new RefIncidentReporterType { Id=Guid.Parse("7c6c92ae-1449-4020-94a3-edcc310d32e1"), Code="13333", Description="Paraprofessionals/Instructional Aide", Definition="Paraprofessionals/Instructional Aide reported the incident.", SortOrder=Convert.ToDecimal("29.00") },
            new RefIncidentReporterType { Id=Guid.Parse("68e24de3-b487-40c9-a9b8-5366ef7d0de9"), Code="04885", Description="Security guard", Definition="Security guard reported the incident.", SortOrder=Convert.ToDecimal("30.00") },
            new RefIncidentReporterType { Id=Guid.Parse("db27eccc-6235-4b38-8e8e-e28661f9b0b1"), Code="03054", Description="Law enforcement officer", Definition="Law enforcement officer reported the incident.", SortOrder=Convert.ToDecimal("31.00") },
            new RefIncidentReporterType { Id=Guid.Parse("51400231-96d0-43eb-a285-847efdac1e57"), Code="03055", Description="Municipal law enforcement officer assigned to the school", Definition="Municipal law enforcement officer assigned to the school reported the incident.", SortOrder=Convert.ToDecimal("32.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d379a4fb-6d62-4fab-b329-fb2d0e460231"), Code="03056", Description="Municipal law enforcement officer not assigned to the school", Definition="Municipal law enforcement officer not assigned to the school reported the incident.", SortOrder=Convert.ToDecimal("33.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d076d8d4-dc00-4b3b-b209-a4124435f102"), Code="03057", Description="School district police officer assigned to the school", Definition="School district police officer assigned to the school reported the incident.", SortOrder=Convert.ToDecimal("34.00") },
            new RefIncidentReporterType { Id=Guid.Parse("f863ef83-0364-43b5-814b-09ccac6167f3"), Code="03058", Description="School district police officer not assigned to the school", Definition="School district police officer not assigned to the school reported the incident.", SortOrder=Convert.ToDecimal("35.00") },
            new RefIncidentReporterType { Id=Guid.Parse("61c5daf3-899a-4148-bcf1-68ad064ca339"), Code="03059", Description="Nonschool personnel", Definition="Nonschool personnel reported the incident.", SortOrder=Convert.ToDecimal("36.00") },
            new RefIncidentReporterType { Id=Guid.Parse("7f0a8aba-0113-40ab-a390-80752d6772e5"), Code="00850", Description="Parent/guardian", Definition="Parent/guardian reported the incident.", SortOrder=Convert.ToDecimal("37.00") },
            new RefIncidentReporterType { Id=Guid.Parse("49e078a1-7b9e-4be8-8c3d-7f965dff51a3"), Code="03060", Description="Representative of visiting school", Definition="Representative of visiting school reported the incident.", SortOrder=Convert.ToDecimal("38.00") },
            new RefIncidentReporterType { Id=Guid.Parse("a725827f-e15f-4a68-a094-efa253a3faec"), Code="03061", Description="Other adult", Definition="Other adult reported the incident.", SortOrder=Convert.ToDecimal("39.00") },
            new RefIncidentReporterType { Id=Guid.Parse("1d42099b-448c-44ed-9c90-cd174be87944"), Code="03168", Description="Former student", Definition="Former student reported the incident.", SortOrder=Convert.ToDecimal("40.00") },
            new RefIncidentReporterType { Id=Guid.Parse("06a44898-01f1-428e-bf5f-7b3ebce6d106"), Code="03062", Description="Other nonstudent youth", Definition="Other nonstudent youth reported the incident.", SortOrder=Convert.ToDecimal("41.00") },
            new RefIncidentReporterType { Id=Guid.Parse("cc577a8a-d587-424e-b6ab-501e738246b8"), Code="09997", Description="Unknown", Definition="An unknown category of person reported the incident.", SortOrder=Convert.ToDecimal("42.00") },
        };

        /// <summary>
        /// The RefIncidentReporterType Pick List
         /// </summary>
        public static List<RefIncidentReporterType> RefIncidentReporterTypePickList = new List<RefIncidentReporterType>
        {
            new RefIncidentReporterType { Id=Guid.Parse("8b76619d-cfb5-4dcf-9591-ca6364dd7032"), Code="00126", Description="Student", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentReporterType { Id=Guid.Parse("2b0ebd70-20ff-4ec2-9f77-c69724fcb382"), Code="03032", Description="Student enrolled in the school where the incident occurred", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentReporterType { Id=Guid.Parse("ed3f160c-cb47-4339-a9ab-b72ff229f6fa"), Code="03033", Description="Student enrolled in another school", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentReporterType { Id=Guid.Parse("bffd7989-dd20-45e1-9d48-188327dfaa48"), Code="03034", Description="Student expelled or involuntarily withdrawn", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentReporterType { Id=Guid.Parse("ed3f195d-2454-4215-b000-3e07b6c54bee"), Code="03422", Description="Staff member", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentReporterType { Id=Guid.Parse("25dc9e03-381e-4cc2-a894-e4167d3871f5"), Code="03035", Description="Professional educational staff", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentReporterType { Id=Guid.Parse("5cce835c-311c-4d7c-ae72-079c2a67a4ea"), Code="04732", Description="Teacher", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentReporterType { Id=Guid.Parse("bfca3c2d-9138-4070-a07a-0a5158c94343"), Code="13782", Description="Substitute teacher", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentReporterType { Id=Guid.Parse("cd6ac254-1c23-4e80-b3af-a39d64d60fb5"), Code="13335", Description="Librarians/Media Specialist", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d2015fab-ba6a-4e2d-b345-324649830c5b"), Code="04725", Description="Counselor", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentReporterType { Id=Guid.Parse("efa0cb8b-58d5-498f-90f2-826550027cbf"), Code="13334", Description="School Counselor", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d386af8a-182a-4e07-bb1c-ff23041c9a19"), Code="04723", Description="Athletic coach", SortOrder=Convert.ToDecimal("12.00") },
            new RefIncidentReporterType { Id=Guid.Parse("aa6a6c70-a537-453c-8db8-be15d3d60084"), Code="04730", Description="Student activity advisor/non athletic coach", SortOrder=Convert.ToDecimal("13.00") },
            new RefIncidentReporterType { Id=Guid.Parse("b193a5e6-b9af-4fda-9e14-891a7150ada8"), Code="13403", Description="Other Professional Staff", SortOrder=Convert.ToDecimal("14.00") },
            new RefIncidentReporterType { Id=Guid.Parse("670d7090-5718-4014-bcf5-0e3091ff5f56"), Code="04783", Description="Registered nurse", SortOrder=Convert.ToDecimal("15.00") },
            new RefIncidentReporterType { Id=Guid.Parse("cde74ab0-287f-4cc4-8521-a57a2c19749a"), Code="04788", Description="Social worker", SortOrder=Convert.ToDecimal("16.00") },
            new RefIncidentReporterType { Id=Guid.Parse("18893433-b14e-4b09-8562-33a85248907a"), Code="03041", Description="Administrator", SortOrder=Convert.ToDecimal("17.00") },
            new RefIncidentReporterType { Id=Guid.Parse("8db20b60-1a6d-4521-8ac8-241167185a6f"), Code="04718", Description="Principal/headmaster/headmistress/head of school", SortOrder=Convert.ToDecimal("18.00") },
            new RefIncidentReporterType { Id=Guid.Parse("f5710060-cb18-4d11-a368-06f06b63cf67"), Code="04711", Description="Deputy/associate/vice /assistant principal", SortOrder=Convert.ToDecimal("19.00") },
            new RefIncidentReporterType { Id=Guid.Parse("6ab9ad1b-d18d-4b14-b26d-239f1b59711e"), Code="04710", Description="Dean/dean of instructions/dean of students/dean of boys/dean of girls/dean of student activities", SortOrder=Convert.ToDecimal("20.00") },
            new RefIncidentReporterType { Id=Guid.Parse("fc48201b-4e9a-463e-8002-eab3cedfdd90"), Code="04721", Description="Superintendent/commissioner", SortOrder=Convert.ToDecimal("21.00") },
            new RefIncidentReporterType { Id=Guid.Parse("2057e7fd-3856-4f05-b093-8a5b78fb1d16"), Code="04712", Description="Deputy/associate/assistant superintendent/ commissioner", SortOrder=Convert.ToDecimal("22.00") },
            new RefIncidentReporterType { Id=Guid.Parse("0cd78aa2-edfa-46a4-b0c2-00ff325b4fe9"), Code="04708", Description="Board of education/school board/board of trustees member", SortOrder=Convert.ToDecimal("23.00") },
            new RefIncidentReporterType { Id=Guid.Parse("aca2481f-be71-4ef6-bcdc-bee989e469b0"), Code="13342", Description="All Other Support Staff", SortOrder=Convert.ToDecimal("24.00") },
            new RefIncidentReporterType { Id=Guid.Parse("4da11e8e-bc41-43ed-8091-6c14067885ba"), Code="04864", Description="Bus driver", SortOrder=Convert.ToDecimal("25.00") },
            new RefIncidentReporterType { Id=Guid.Parse("12e1cd12-cce0-4c71-8365-6f9bc80f85b3"), Code="13340", Description="School Administrative Support Staff", SortOrder=Convert.ToDecimal("26.00") },
            new RefIncidentReporterType { Id=Guid.Parse("e635daf6-34dc-42db-a288-0aaa0098b090"), Code="04878", Description="Custodian", SortOrder=Convert.ToDecimal("27.00") },
            new RefIncidentReporterType { Id=Guid.Parse("6f7fd132-fbc8-4a7a-9cfa-4dc1c41983ba"), Code="04877", Description="Cook/food preparer (food service staff)", SortOrder=Convert.ToDecimal("28.00") },
            new RefIncidentReporterType { Id=Guid.Parse("7c6c92ae-1449-4020-94a3-edcc310d32e1"), Code="13333", Description="Paraprofessionals/Instructional Aide", SortOrder=Convert.ToDecimal("29.00") },
            new RefIncidentReporterType { Id=Guid.Parse("68e24de3-b487-40c9-a9b8-5366ef7d0de9"), Code="04885", Description="Security guard", SortOrder=Convert.ToDecimal("30.00") },
            new RefIncidentReporterType { Id=Guid.Parse("db27eccc-6235-4b38-8e8e-e28661f9b0b1"), Code="03054", Description="Law enforcement officer", SortOrder=Convert.ToDecimal("31.00") },
            new RefIncidentReporterType { Id=Guid.Parse("51400231-96d0-43eb-a285-847efdac1e57"), Code="03055", Description="Municipal law enforcement officer assigned to the school", SortOrder=Convert.ToDecimal("32.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d379a4fb-6d62-4fab-b329-fb2d0e460231"), Code="03056", Description="Municipal law enforcement officer not assigned to the school", SortOrder=Convert.ToDecimal("33.00") },
            new RefIncidentReporterType { Id=Guid.Parse("d076d8d4-dc00-4b3b-b209-a4124435f102"), Code="03057", Description="School district police officer assigned to the school", SortOrder=Convert.ToDecimal("34.00") },
            new RefIncidentReporterType { Id=Guid.Parse("f863ef83-0364-43b5-814b-09ccac6167f3"), Code="03058", Description="School district police officer not assigned to the school", SortOrder=Convert.ToDecimal("35.00") },
            new RefIncidentReporterType { Id=Guid.Parse("61c5daf3-899a-4148-bcf1-68ad064ca339"), Code="03059", Description="Nonschool personnel", SortOrder=Convert.ToDecimal("36.00") },
            new RefIncidentReporterType { Id=Guid.Parse("7f0a8aba-0113-40ab-a390-80752d6772e5"), Code="00850", Description="Parent/guardian", SortOrder=Convert.ToDecimal("37.00") },
            new RefIncidentReporterType { Id=Guid.Parse("49e078a1-7b9e-4be8-8c3d-7f965dff51a3"), Code="03060", Description="Representative of visiting school", SortOrder=Convert.ToDecimal("38.00") },
            new RefIncidentReporterType { Id=Guid.Parse("a725827f-e15f-4a68-a094-efa253a3faec"), Code="03061", Description="Other adult", SortOrder=Convert.ToDecimal("39.00") },
            new RefIncidentReporterType { Id=Guid.Parse("1d42099b-448c-44ed-9c90-cd174be87944"), Code="03168", Description="Former student", SortOrder=Convert.ToDecimal("40.00") },
            new RefIncidentReporterType { Id=Guid.Parse("06a44898-01f1-428e-bf5f-7b3ebce6d106"), Code="03062", Description="Other nonstudent youth", SortOrder=Convert.ToDecimal("41.00") },
            new RefIncidentReporterType { Id=Guid.Parse("cc577a8a-d587-424e-b6ab-501e738246b8"), Code="09997", Description="Unknown", SortOrder=Convert.ToDecimal("42.00") },
       };
   }
}
