using System.Collections.Generic;
using System.Data.Entity;
using DAL;


namespace DAL
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<AXMbsDevEntities>
    {
        protected override void Seed(AXMbsDevEntities context)
        {
            GetWebUsers().ForEach(m => context.MBSWBWEBUSERCONTACT.Add(m));
            //GetCustomers().ForEach(c => context.Customers.Add(c));
            /*GetEmployees().ForEach(e => context.Employees.Add(e));
            GetItems().ForEach(i => context.Items.Add(i));
            GetItemCategories().ForEach(ic => context.ItemCategories.Add(ic));
            GetSalesHeader().ForEach(sh => context.SalesHeaders.Add(sh));
            GetSalesItems().ForEach(si => context.SalesItems.Add(si));
            GetWebUsers().ForEach(w => context.WebUserTables.Add(w));*/

        }
        /*private static List<Customer> GetCustomers()
        {
            var customers = new List<Customer> {
                new Customer
                {
                    CustomerId = 25,
                    FirstName = "Master",
                    LastName = "Yoda",
                    City = "Hoth",
                    State = "CO",
                    Zip = "80012",
                    Street = "1234 Wookie Way",
                    Address = "1234 Wookie Way, Hoth CO 80012",
                    Phone = "3031234567",
                    Email = "Masteryoda@jedi.com"
                },
                new Customer
                {
                    CustomerId = 26,
                    FirstName = "Master",
                    LastName = "ObiWan",
                    City = "Hoth",
                    State = "CO",
                    Zip = "80012",
                    Street = "1234 Wookie Way",
                    Address = "1234 Wookie Way, Hoth CO 80012",
                    Phone = "3031234567",
                    Email = "Masteryoda@jedi.com"
                }
                
            };

            return customers;
        }
        private static List<Employee> GetEmployees()
        {
            var employees = new List<Employee> {
                new Employee
                {
                    EmployeeId = 25,
                    EmployeeFirstName = "Bruce",
                    EmployeeLastName = "Olsen",
                    EmployeePhone = "3031234567",
                    Employeetype = "Worker"
                },
                new Employee
                {
                    EmployeeId = 26,
                    EmployeeFirstName = "Maurice",
                    EmployeeLastName = "Olsen",
                    EmployeePhone = "3031234567",
                    Employeetype = "Manager"
                }
                
            };

            return employees;
        }
        private static List<ItemCategory> GetItemCategories()
        {
            var itemCategoies = new List<ItemCategory> {
                new ItemCategory
                {
                ItemCategoryId = 21,
                Category = "Engine",
                Description = "Engine Performance Modification"
                },
                new ItemCategory
                {
                ItemCategoryId = 22,
                Category = "Exhaust",
                Description = "Exhaust Performance Modification"
                },
                new ItemCategory
                {
                ItemCategoryId = 23,
                Category = "Suspension",
                Description = "Suspension Performance Modification"
                }                
            };

            return itemCategoies;
        }
        private static List<Item> GetItems()
        {


            var items = new List<Item> {
                new Item
                {
                    ItemId = 21,
                    ItemName = "FP Green",
                    Price = 900,
                    QuantityAvailable = 10,
                    ItemCategoryId =  21
                },
                new Item
                {
                    ItemId = 22,
                    ItemName = "FP Red",
                    Price = 1200,
                    QuantityAvailable = 10,
                    ItemCategoryId =  21
                },
                new Item
                {
                    ItemId = 23,
                    ItemName = "Borla Catback Exhaust",
                    Price = 500,
                    QuantityAvailable = 10,
                    ItemCategoryId =  22
                },      
                new Item
                {
                    ItemId = 24,
                    ItemName = "Magnaflow Catback Exhaust",
                    Price = 600,
                    QuantityAvailable = 10,
                    ItemCategoryId =  22
                },       
                new Item
                {
                    ItemId = 25,
                    ItemName = "UR Front Sway Bar",
                    Price = 200,
                    QuantityAvailable = 10,
                    ItemCategoryId =  23
                },      
                new Item
                {
                    ItemId = 26,
                    ItemName = "UR Rear Sway Bar",
                    Price = 200,
                    QuantityAvailable = 10,
                    ItemCategoryId =  23
                },          
            };

            return items;
        }
        private static List<SalesHeader> GetSalesHeader()
        {
            var salesHeaders = new List<SalesHeader> {
                new SalesHeader
                {
                    SalesId = 21,
                    CustomerId = 25,
                    OrderSalesBalance = 1400,
                    OrderTaxAmount = 100,
                    OrderTotal = 1500
                },
                
            };

            return salesHeaders;
        }
        private static List<SalesItem> GetSalesItems()
        {
            var salesItems = new List<SalesItem> {
                new SalesItem
                {
                    SalesItemTransId = 21,
                    SalesId = 21,
                    ItemId = 22,
                    Qty = 1,
                    Price = 1200
                   
                },
                new SalesItem
                {
                    SalesItemTransId = 22,
                    SalesId = 21,
                    ItemId = 26,
                    Qty = 1,
                    Price = 200
                }
                
            };

            return salesItems;
        }*/
        private static List<MBSWBWEBUSERCONTACT> GetWebUsers()
        {
            var webUsers = new List<MBSWBWEBUSERCONTACT> {
                new MBSWBWEBUSERCONTACT
                {
                    ACCOUNTNUM = "100",
                    WEBLOGON = "username",
                    WEBPASSWORD = "Pass@word1",
                    DATAAREAID = "MBS"
                   
                },
                new MBSWBWEBUSERCONTACT
                {
                    ACCOUNTNUM = "100",
                    WEBLOGON = "username",
                    WEBPASSWORD = "Pass@word1",
                    DATAAREAID = "MBS"
                }
                
            };

            return webUsers;
        }
    }
}