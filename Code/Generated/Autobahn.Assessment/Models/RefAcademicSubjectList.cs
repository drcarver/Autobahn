//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAcademicSubjectList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAcademicSubject Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicSubject"> List
         /// </summary>
        public static List<RefAcademicSubject> RefAcademicSubjectList = new List<RefAcademicSubject>
        {
            new RefAcademicSubject { Id=Guid.Parse("ebc4ac25-fdce-4399-8e17-d88d7cd44413"), Code="13371", Description="Arts", Definition="Arts is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicSubject { Id=Guid.Parse("396de7d7-15fa-44ea-8c76-01d51d64f5ac"), Code="73065", Description="Career and Technical Education", Definition="Career and Technical Education is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicSubject { Id=Guid.Parse("7067a095-4d34-4d0b-a1d3-6882fc9427db"), Code="13372", Description="English", Definition="English is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicSubject { Id=Guid.Parse("18e29273-b9b4-4b0f-a1ea-e89b193006af"), Code="00256", Description="English as a second language (ESL)", Definition="English as a second language (ESL) is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicSubject { Id=Guid.Parse("1b2a84e6-434e-4f5c-9320-4869a539df77"), Code="00546", Description="Foreign Languages", Definition="Foreign Languages is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicSubject { Id=Guid.Parse("45e54b79-f084-4310-b334-fa18d8423653"), Code="73088", Description="History Government - US", Definition="History Government - US is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicSubject { Id=Guid.Parse("6ad3b9d4-ef93-44e3-a917-53cfb283cfca"), Code="73089", Description="History Government - World", Definition="History Government - World is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicSubject { Id=Guid.Parse("1360e988-544b-4226-a259-a3aac6b9b95f"), Code="00554", Description="Language arts", Definition="Language arts is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicSubject { Id=Guid.Parse("b58487fe-6dce-4c37-9c69-14e54273232e"), Code="01166", Description="Mathematics", Definition="Mathematics is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicSubject { Id=Guid.Parse("10aaae53-6ca5-4508-8e67-c319d797e299"), Code="00560", Description="Reading", Definition="Reading is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicSubject { Id=Guid.Parse("7c66feac-a8ed-468d-90e3-89140d0f7ea6"), Code="13373", Description="Reading/Language Arts", Definition="Reading/Language Arts is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicSubject { Id=Guid.Parse("d78dbcaf-55fe-49ef-8e11-02858a8e75a9"), Code="00562", Description="Science", Definition="Science is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("18.00") },
            new RefAcademicSubject { Id=Guid.Parse("9979fdef-2971-4658-a70b-e9f90e0578cb"), Code="73086", Description="Science - Life", Definition="Science - Life is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("20.00") },
            new RefAcademicSubject { Id=Guid.Parse("25cf9b29-23d2-4cfb-85b5-a4293ae150dd"), Code="73087", Description="Science - Physical", Definition="Science - Physical is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("22.00") },
            new RefAcademicSubject { Id=Guid.Parse("30e22971-47b9-4cf0-854c-3f2d0a1669f9"), Code="13374", Description="Social Sciences (History, Geography, Economics, Civics and Government)", Definition="Social Sciences (History, Geography, Economics, Civics and Government) is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("24.00") },
            new RefAcademicSubject { Id=Guid.Parse("a04eca5d-95c1-495d-b228-a635bb113a28"), Code="02043", Description="Special education", Definition="Special education is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("26.00") },
            new RefAcademicSubject { Id=Guid.Parse("2b80a6d6-c64e-4f0a-9aa6-3b84d9e8d5c5"), Code="01287", Description="Writing", Definition="Writing is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("28.00") },
            new RefAcademicSubject { Id=Guid.Parse("1eec2a10-5e0f-42bf-b5d3-0b01115b10de"), Code="09999", Description="Other", Definition="Other is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("30.00") },
        };

        /// <summary>
        /// The RefAcademicSubject Pick List
         /// </summary>
        public static List<RefAcademicSubject> RefAcademicSubjectPickList = new List<RefAcademicSubject>
        {
            new RefAcademicSubject { Id=Guid.Parse("ebc4ac25-fdce-4399-8e17-d88d7cd44413"), Code="13371", Description="Arts", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicSubject { Id=Guid.Parse("396de7d7-15fa-44ea-8c76-01d51d64f5ac"), Code="73065", Description="Career and Technical Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicSubject { Id=Guid.Parse("7067a095-4d34-4d0b-a1d3-6882fc9427db"), Code="13372", Description="English", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicSubject { Id=Guid.Parse("18e29273-b9b4-4b0f-a1ea-e89b193006af"), Code="00256", Description="English as a second language (ESL)", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicSubject { Id=Guid.Parse("1b2a84e6-434e-4f5c-9320-4869a539df77"), Code="00546", Description="Foreign Languages", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicSubject { Id=Guid.Parse("45e54b79-f084-4310-b334-fa18d8423653"), Code="73088", Description="History Government - US", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicSubject { Id=Guid.Parse("6ad3b9d4-ef93-44e3-a917-53cfb283cfca"), Code="73089", Description="History Government - World", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicSubject { Id=Guid.Parse("1360e988-544b-4226-a259-a3aac6b9b95f"), Code="00554", Description="Language arts", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicSubject { Id=Guid.Parse("b58487fe-6dce-4c37-9c69-14e54273232e"), Code="01166", Description="Mathematics", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicSubject { Id=Guid.Parse("10aaae53-6ca5-4508-8e67-c319d797e299"), Code="00560", Description="Reading", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicSubject { Id=Guid.Parse("7c66feac-a8ed-468d-90e3-89140d0f7ea6"), Code="13373", Description="Reading/Language Arts", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicSubject { Id=Guid.Parse("d78dbcaf-55fe-49ef-8e11-02858a8e75a9"), Code="00562", Description="Science", SortOrder=Convert.ToDecimal("18.00") },
            new RefAcademicSubject { Id=Guid.Parse("9979fdef-2971-4658-a70b-e9f90e0578cb"), Code="73086", Description="Science - Life", SortOrder=Convert.ToDecimal("20.00") },
            new RefAcademicSubject { Id=Guid.Parse("25cf9b29-23d2-4cfb-85b5-a4293ae150dd"), Code="73087", Description="Science - Physical", SortOrder=Convert.ToDecimal("22.00") },
            new RefAcademicSubject { Id=Guid.Parse("30e22971-47b9-4cf0-854c-3f2d0a1669f9"), Code="13374", Description="Social Sciences (History, Geography, Economics, Civics and Government)", SortOrder=Convert.ToDecimal("24.00") },
            new RefAcademicSubject { Id=Guid.Parse("a04eca5d-95c1-495d-b228-a635bb113a28"), Code="02043", Description="Special education", SortOrder=Convert.ToDecimal("26.00") },
            new RefAcademicSubject { Id=Guid.Parse("2b80a6d6-c64e-4f0a-9aa6-3b84d9e8d5c5"), Code="01287", Description="Writing", SortOrder=Convert.ToDecimal("28.00") },
            new RefAcademicSubject { Id=Guid.Parse("1eec2a10-5e0f-42bf-b5d3-0b01115b10de"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("30.00") },
       };
   }
}
