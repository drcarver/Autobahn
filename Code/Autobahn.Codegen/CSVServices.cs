// *******************************************************************************************************
//   File:      CSVServices.cs
//   CreatedAt: 07/26/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using System.Collections.Generic;
using System.Globalization;
using Autobahn.Codegen.Maps;
using Autobahn.Codegen.Models;
using CsvHelper;
using CsvHelper.Configuration;

namespace Autobahn.Codegen;

internal class CSVServices
{
    internal List<AutobahnDomain> ReadDomainsFile(string location)
    {
        try
        {
            using (var reader = new StreamReader(location))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap<AutobahnDomainMap>();
                    var records = csv.GetRecords<AutobahnDomain>().ToList();
                    return records;
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    internal List<AutobahnElement> ReadAutobahnElementFile(string location, string delimiter = "|")
    {
        try
        {
            using (var reader = new StreamReader(location))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true, Delimiter = delimiter, BadDataFound = null, MissingFieldFound = null };
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap<AutobahnElementMap>();
                    var records = csv.GetRecords<AutobahnElement>().ToList();
                    return records;
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public List<AutobahnTable> ReadTablesFile(string location, bool hasHeaderRecord, string delimiter = "|")
    {
        List<AutobahnTable> records = new();
        try
        {
            using (var reader = new StreamReader(location))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = hasHeaderRecord, Delimiter = delimiter, BadDataFound = null, MissingFieldFound = null };
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap<AutobahnTableMap>();
                    csv.GetRecords<AutobahnTableMap>().ToArray();
                    //records = csv.GetRecords<AutobahnTable>().ToList();
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        return records;
    }

}

//    public List<EntityReferenceBase> ReadReferenceFile(string location)
//    {
//        try
//        {
//            using (var reader = new StreamReader(location))
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
//                using (var csv = new CsvReader(reader, config))
//                {
//                    csv.Context.RegisterClassMap<ReferenceModelMap>();
//                    var records = csv.GetRecords<EntityReferenceBase>().ToList();
//                    return records;
//                }
//            }
//        }
//        catch (Exception e)
//        {
//            throw new Exception(e.Message);
//        }
//    }

//    public List<MarcModel> ReadMarcReferenceFile(string location)
//    {
//        try
//        {
//            using (var reader = new StreamReader(location))
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|", BadDataFound = null, MissingFieldFound = null };
//                using (var csv = new CsvReader(reader, config))
//                {
//                    csv.Context.RegisterClassMap<MarcModelMap>();
//                    var records = csv.GetRecords<MarcModel>().ToList();
//                    return records;
//                }
//            }
//        }
//        catch (Exception e)
//        {
//            throw new Exception(e.Message);
//        }
//    }

//    public void WriteAutobahnDomainsFile(string location, List<AutobahnDomain> domains)
//    {
//        using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
//        {
//            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false, Delimiter = "|" };
//            using (var csv = new CsvWriter(writer, config))
//            {
//                csv.WriteRecords(domains);
//            }
//        }
//    }

//    public void WriteTablesFile(string location, List<AutobahnTable> tables, bool hasHeaderRecord, string delimeter = "|")
//    {
//        using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
//        {
//            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = hasHeaderRecord, Delimiter = delimeter };
//            using (var csv = new CsvWriter(writer, config))
//            {
//                csv.WriteRecords(tables);
//            }
//        }
//    }

//    public void WriteReferenceFile(string location, List<ReferenceModel> tables, bool hasHeaderRecord, string delimeter = "|")
//    {
//        using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
//        {
//            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = hasHeaderRecord, Delimiter = delimeter };
//            using (var csv = new CsvWriter(writer, config))
//            {
//                csv.WriteRecords(tables);
//            }
//        }
//    }

//    public void WriteCEDSlementFile(string location, List<_CEDSElement> elements, string delimeter = "|")
//    {
//        using (TextWriter writer = new StreamWriter(location, false, System.Text.Encoding.UTF8))
//        {
//            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true, Delimiter = delimeter };
//            using (var csv = new CsvWriter(writer, config))
//            {
//                csv.WriteRecords(elements);
//            }
//        }
//    }
//}
