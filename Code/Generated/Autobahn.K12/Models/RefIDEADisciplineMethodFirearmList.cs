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
        public static List<RefIDEADisciplineMethodFirearm> RefIDEADisciplineMethodFirearmList = new List<RefIDEADisciplineMethodFirearm> =
        {
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("dd35b95a-17cd-4719-855a-a0631ae9ebfc"), Code="Expulsion modified to less than one year with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", Description="EXPMOD", Definition="", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("d98c5368-afb0-475e-88c5-65beeabe0879"), Code="One year expulsion with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", Description="EXPNOTMOD", Definition="", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("392a155f-f1ed-41c2-bd2a-6aae3f3319d7"), Code="Other reasons such as death, withdrawal, or incarceration was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", Description="REMOVEOTHER", Definition="", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("b738e29d-c22f-4f7e-a5f5-3d5c4e3c0554"), Code="Another type of disciplinary action was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", Description="OTHERDISACTION", Definition="", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("8294d3ff-ed72-4f71-a968-5c7b5282c210"), Code="No disciplinary action taken was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", Description="NOACTION", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIDEADisciplineMethodFirearm Pick List
         /// </summary>
        public static List<RefIDEADisciplineMethodFirearm> RefIDEADisciplineMethodFirearmPickList = new List<RefIDEADisciplineMethodFirearm> =
        {
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("dd35b95a-17cd-4719-855a-a0631ae9ebfc"), Code="Expulsion modified to less than one year with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("d98c5368-afb0-475e-88c5-65beeabe0879"), Code="One year expulsion with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("392a155f-f1ed-41c2-bd2a-6aae3f3319d7"), Code="Other reasons such as death, withdrawal, or incarceration was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("b738e29d-c22f-4f7e-a5f5-3d5c4e3c0554"), Code="Another type of disciplinary action was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=0 },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("8294d3ff-ed72-4f71-a968-5c7b5282c210"), Code="No disciplinary action taken was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=0 },
       };
   }
}
