using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyLibrary1
{
    public  class LibraryReading
    {
        private static object reader;
        private static object cultureInfo;
        private static object csv;

        public static object Invariantculture { get; private set; }

        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\test\Desktop\Reviews\ThirdPartyLibrary1\ThirdPartyLibrary1\Address.csv";
            using (var reader = new StreamReader(importFilePath)) ;
            using (var csv = new csvReader(reader, cultureInfo invariantculture)) ;
            { 
                var records = csv.GetRecords<AddressData>()ToList();
                
                Console.WriteLine("Read data successfully from Address.csv");

                foreach (AddressData addressData in records) ;

                
                Console.WriteLine(addressData.FirstName);
               
                Console.WriteLine(addressData.LastName);
               
                Console.WriteLine(addressData.Address);
               
                Console.WriteLine(addressData.city);
              
                Console.WriteLine(addressData.state);
               
                Console.WriteLine(addressData.code);


       
            
            
            }



        }

        
    }
    
}
