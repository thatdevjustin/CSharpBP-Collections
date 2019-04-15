﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }
        /// <summary>
        /// A method that retrieves a list of vendors
        /// </summary>
        /// <returns>List of Vendors</returns>
        public IEnumerable<Vendor> Retrieve()
        {
            if(vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }
            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }
            foreach(var vendor in vendors)
            {
                //Console.WriteLine(vendor);
            }
            return vendors;
        }
        public IEnumerable<Vendor> RetrieveAll()
        {
            var vendors = new List<Vendor>()
            {
                {new Vendor()
                    {VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com"}},
                {new Vendor()
                    {VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com"}},
                {new Vendor()
                    {VendorId = 12, CompanyName = "EFG Ltd", Email = "EFG@EFG.com"}},
                {new Vendor()
                    {VendorId = 17, CompanyName = "HIJ AG", Email = "HIJ@HIJ.com"}},
                {new Vendor()
                    {VendorId = 22, CompanyName = "Amalgamated Toys", Email = "a@abc.com"}},
                {new Vendor()
                    {VendorId = 28, CompanyName = "Toy Blocks Inc", Email = "blocks@abc.com"}},
                {new Vendor()
                    {VendorId = 31, CompanyName = "Home Products Inc", Email = "home@abc.com"}},
                {new Vendor()
                    {VendorId = 35, CompanyName = "Car Toys", Email = "car@abc.com"}},
                {new Vendor()
                    {VendorId = 42, CompanyName = "Toys for Fun", Email = "fun@abc.com"}}
            };

            return vendors;
        }
        /// <summary>
        /// Retrieve Generic Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;

            return defaultValue;
        }


        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
        
        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            this.Retrieve();

            foreach(var vendor in vendors)
            {
                Console.WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }
    }
}
