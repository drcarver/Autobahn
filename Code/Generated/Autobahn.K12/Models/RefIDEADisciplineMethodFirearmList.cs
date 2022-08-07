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
        /// The complete <see cref="RefIDEADisciplineMethodFirearmModel"> List
         /// </summary>
        public static List<RefIDEADisciplineMethodFirearmModel> RefIDEADisciplineMethodFirearmList = new List<RefIDEADisciplineMethodFirearmModel>
        {
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("2a9dcbdb-7c72-4e37-b0d0-5abe6caa5091"), Code="EXPMOD", Description="Expulsion modified to less than one year with educational services under IDEA", Definition="Expulsion modified to less than one year with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("c7029174-84e5-42c8-ac18-adc3279aad89"), Code="EXPNOTMOD", Description="One year expulsion with educational services under IDEA", Definition="One year expulsion with educational services under IDEA was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("8e0c7f7e-d104-4584-9ed6-4d9adf499397"), Code="REMOVEOTHER", Description="Other reasons such as death, withdrawal, or incarceration", Definition="Other reasons such as death, withdrawal, or incarceration was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("ac9a0c06-1dd4-4eea-99e9-1cc1c180a382"), Code="OTHERDISACTION", Description="Another type of disciplinary action", Definition="Another type of disciplinary action was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("333c50c0-70ff-4ac1-a9f2-28b346a510ef"), Code="NOACTION", Description="No disciplinary action taken", Definition="No disciplinary action taken was the methods used to discipline student(s) who are children with disabilities (IDEA) involved in firearms and other outcomes of firearms incidents.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefIDEADisciplineMethodFirearm Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIDEADisciplineMethodFirearmViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("2a9dcbdb-7c72-4e37-b0d0-5abe6caa5091"), Description="Expulsion modified to less than one year with educational services under IDEA", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("c7029174-84e5-42c8-ac18-adc3279aad89"), Description="One year expulsion with educational services under IDEA", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("8e0c7f7e-d104-4584-9ed6-4d9adf499397"), Description="Other reasons such as death, withdrawal, or incarceration", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("ac9a0c06-1dd4-4eea-99e9-1cc1c180a382"), Description="Another type of disciplinary action", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEADisciplineMethodFirearm { Id=Guid.Parse("333c50c0-70ff-4ac1-a9f2-28b346a510ef"), Description="No disciplinary action taken", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
