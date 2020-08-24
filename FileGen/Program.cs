using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileGen
{
    class class1
    {
      
            static void Main(string[] args)
            {
            Random gen = new Random();
            String RandomDay()
            {
                DateTime start = new DateTime(2019, 7, 7);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(gen.Next(range)).ToString("MM/dd/yyyy");
            }

            int rowCount = 10;
            List<string> Account_number = new List<string> { "Account number" };
            List<string> National_drug_code = new List<string> { "(NDC)" };
            List<string> packageSize = new List<string> { "Package size" };
            List<string> Item_description = new List<string> {"TOBRAMYC+DEXAM OS FAL 5ML @","PRAMIPEX TAB 1MG GLEN 90@",
                "CLONAZEP TAB 1MG UD UDL 10X10","PACLITAX INJ 6MG/ML FRE 6.7ML",
                "TENIVAC TET DIP TOX PFS 10","SYR HEP LK 5ML PF 100UN CS480","FAMOTID VL 10MG/ML 2ML WEST25@",
                "HEALON SYR 10MG/ML 0.55ML","HYDROCORT OINT 2.5% FOUG 1OZ@","DOXEPIN CAP 25MG UD UDL 100@",
                "MIDAZ 1MG/ML 2ML PF 25 HW NOV+","VELCADE VIAL 3.5MG D/SHIP 10ML","MAGNES SUL 40MG/ML 100MLPFIZ24",
                "POT CHL INJ 10MEQ 100ML HW 24","SENNA-T S+DOC 8.6/50 UD SKY1C@"};
            List<string> Purchase_order_number = new List<string> { "Purchase order number" };
            List<string> Net_Quantity = new List<string> { "Net quantity" };
            List<string> Invoice_extended_price = new List<string> { "Invoice extended price" };
            List<string> Invoice_Credit_date = new List<string> { "Invoice/Credit date" };
            List<string> Item_number = new List<string> { "Item number" };
            List<string> Account_Facility_name = new List<string> { "Account name/Facility name" };
            List<string> Manufacturer_Supplier_item_number = new List<string> { "Manufacturer/Supplier item number" };
            List<string> Generic_description = new List<string> { "TOBRAMYCIN/DEXAMETHASONE", "PRAMIPEXOLE DI-HCL", "CLONAZEPAM" };
            List<string> Manufacturer_Supplier_name = new List<string> { "Manufacturer/Supplier name" };
            List<string> Original_invoice_number = new List<string> { "Original invoice number" };
            List<string> Ordered_quantity = new List<string> { "Ordered quantity" };
            List<string> Returned_Credited_quantity = new List<string> { "Returned/Credited quantity" };
            List<string> Invoiced_unit_of_measure = new List<string> { "IOM" };
            List<string> Contract_price = new List<string> { "CPri" };
            List<string> Invoiced_price = new List<string> { "IP" };
            List<string> Contract_description = new List<string> { "CDesc" };
            List<string> Contract_indicator = new List<string> { "CInd" };
            List<string> Drop_ship_indicator = new List<string> { "DSI" };
            List<string> Generic_sequence_number = new List<string> { "GSN" };
            List<string> Facility_ID = new List<string> { "Facility ID" };
            List<string> Transaction_type = new List<string> { "Transaction" };
            List<string> Dosage_form = new List<string> { "D_form" };
            List<string> Dosage_strength = new List<string> { "D_strength" };
            List<string> Order_date = new List<string> { "Order date" };
            List<string> Account_Type = new List<string> { "gpo", "340b", "gpo" };
            List<string> UserDefined_1 = new List<string> { "User-defined field 1" };
            List<string> UserDefined_2 = new List<string> { "User-defined field 2" };
            List<string> UserDefined_3 = new List<string> { "User-defined field 3" };
            List<string> UserDefined_4 = new List<string> { "User-defined field 4" };
            List<string> UserDefined_5 = new List<string> { "User-defined field 5" };
            List<string> UserDefined_6 = new List<string> { "User-defined field 6" };
            List<string> UserDefined_7 = new List<string> { "User-defined field 7" };
            List<string> UserDefined_8 = new List<string> { "User-defined field 8" };
            List<string> UserDefined_9 = new List<string> { "User-defined field 9" };
            List<string> UserDefined_10 = new List<string> { "User-defined field 10" };


            var random = new Random();
            using (System.IO.StreamWriter outputFile =
             new System.IO.StreamWriter("C:\\Users\\Serdar Yildiz\\Documents\\Craneware\\Pharmacy\\Parser\\TestFiles\\new2.csv"))
            {
                outputFile.WriteLine("Account number,National drug code (NDC)," +
                    "Package size,Item description,Purchase order number," +
                    "Net quantity,Invoice extended price,Invoice/Credit date,Item number," +
                    "Account name/Facility name,Manufacturer/Supplier item number," +
                    "Generic description,Manufacturer/Supplier name," +
                    "Original invoice number,Ordered quantity,Returned/Credited quantity," +
                    "Invoiced unit of measure,Contract price,Invoiced price,Contract description," +
                    "Contract indicator,Drop ship indicator,Generic sequence number,Facility ID," +
                    "Transaction type,Dosage form,Dosage strength,Order date, Account Type," +
                    "User-defined field 1,User-defined field 2,User-defined field 3," +
                    "User-defined field 4,User-defined field 5,User-defined field 6," +
                    "User-defined field 7,User-defined field 8,User-defined field 9,User-defined field 10");
                for (int i = 0; i < rowCount; i++)
                {
                    outputFile.WriteLine(Account_number[0] + random.Next(10) + ","
                        + "00" + random.Next(100, 999) + "-" + random.Next(100, 999) + "-" + random.Next(10, 99) + ","
                        + random.Next(1000) + ","
                        + Item_description[random.Next(Item_description.Count)] + ","
                        + Purchase_order_number[0] + random.Next(1000) + ","
                        + random.Next(1000) + ","
                        + random.Next(1000) + Math.Round(random.NextDouble(), 2) + ","
                        + RandomDay() + ","
                        + Item_number[0] + random.Next(1000) + ","
                        + Account_Facility_name[0] + random.Next(1000) + ","
                        + Manufacturer_Supplier_item_number[0] + random.Next(1000) + ","
                        + Generic_description[random.Next(Generic_description.Count)] + ","
                        + Manufacturer_Supplier_name[0] + random.Next(1000) + ","
                        + Original_invoice_number[0] + random.Next(1000) + ","
                        + random.Next(1000) + ","
                        + random.Next(1000) + ","
                        + Invoiced_unit_of_measure[0] + random.Next(1000) + ","
                        + random.Next(1000) + Math.Round(random.NextDouble(), 2) + ","
                        + random.Next(1000) + Math.Round(random.NextDouble(), 2) + ","
                        + Contract_description[0] + random.Next(1000) + ","
                        + Contract_indicator[0] + random.Next(1000) + ","
                        + Drop_ship_indicator[0] + random.Next(1000) + ","
                        + Generic_sequence_number[0] + random.Next(1000) + ","
                        + Facility_ID[0] + random.Next(1000) + ","
                        + Transaction_type[0] + random.Next(1000) + ","
                        + Dosage_form[0] + random.Next(1000) + ","
                        + Dosage_strength[0] + random.Next(1000) + ","
                        + RandomDay() + ","
                        + Account_Type[random.Next(0, 3)] + ","
                        + UserDefined_1[0] + random.Next(1000) + ","
                        + UserDefined_2[0] + random.Next(1000) + ","
                        + UserDefined_3[0] + random.Next(1000) + ","
                        + UserDefined_4[0] + random.Next(1000) + ","
                        + UserDefined_5[0] + random.Next(1000) + ","
                        + UserDefined_6[0] + random.Next(1000) + ","
                        + UserDefined_7[0] + random.Next(1000) + ","
                        + UserDefined_8[0] + random.Next(1000) + ","
                        + UserDefined_9[0] + random.Next(1000) + ","
                        + UserDefined_10[0] + random.Next(1000)
                        );
                }
            }

        }
    }
 }

