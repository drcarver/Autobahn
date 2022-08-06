//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefIDEADisciplineMethodFirearmList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefIDEADisciplineMethodFirearm Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEADisciplineMethodFirearm"> List
         /// </summary>
        public static List<RefIDEADisciplineMethodFirearm> RefIDEADisciplineMethodFirearmList = new List<RefIDEADisciplineMethodFirearm>
        {
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("9a3155fd-e109-457c-9497-55ddb78d3e34"), Code="EXPMOD", Description="Expulsion modified to less than one year with educational services under IDEA", Definition="Expulsion modified to less than one year with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("1bd414c3-2faf-4d13-885a-2c9f31e10e07"), Code="EXPNOTMOD", Description="One year expulsion with educational services under IDEA", Definition="One year expulsion with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("9e493227-62c1-403d-bc98-4e041e53c928"), Code="REMOVEOTHER", Description="Other reasons such as death, withdrawal, or incarceration", Definition="Other reasons such as death, withdrawal, or incarceration was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("a5a62bab-4e6c-4bab-9352-27e477a83eb3"), Code="OTHERDISACTION", Description="Another type of disciplinary action", Definition="Another type of disciplinary action was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("c7c569d2-3c6d-4d29-a491-aac079aba64b"), Code="NOACTION", Description="No disciplinary action taken", Definition="No disciplinary action taken was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefIDEADisciplineMethodFirearm Pick List
         /// </summary>
        public static List<RefIDEADisciplineMethodFirearm> RefIDEADisciplineMethodFirearmPickList = new List<RefIDEADisciplineMethodFirearm>
        {
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("9a3155fd-e109-457c-9497-55ddb78d3e34"), Code="EXPMOD", Description="Expulsion modified to less than one year with educational services under IDEA", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("1bd414c3-2faf-4d13-885a-2c9f31e10e07"), Code="EXPNOTMOD", Description="One year expulsion with educational services under IDEA", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("9e493227-62c1-403d-bc98-4e041e53c928"), Code="REMOVEOTHER", Description="Other reasons such as death, withdrawal, or incarceration", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("a5a62bab-4e6c-4bab-9352-27e477a83eb3"), Code="OTHERDISACTION", Description="Another type of disciplinary action", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("c7c569d2-3c6d-4d29-a491-aac079aba64b"), Code="NOACTION", Description="No disciplinary action taken", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
