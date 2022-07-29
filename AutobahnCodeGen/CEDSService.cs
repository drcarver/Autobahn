// *******************************************************************************************************
//   File:      CEDSService.cs
//   CreatedAt: 07/26/2022
// 
// 
//   Copyright ©2020 GoDungeon.com
// *******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace AutobahnCodeGen
{
    public class CEDSService
    {
        public List<CEDSElement> ReadCSVFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Context.RegisterClassMap<CEDSMap>();
                        var records = csv.GetRecords<CEDSElement>().ToList();
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}