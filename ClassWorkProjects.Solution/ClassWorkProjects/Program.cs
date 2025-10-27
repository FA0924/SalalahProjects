


//------------------------------------------------------------- Salalah Delivery Express -------------------------------------------------------------



using ClassWorkProjects.Models.Salalah_Delivery_Express;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Salalah Delivery Express ===");
            Console.WriteLine("Delivery Management System - Salalah Industrial Area\n");

            // Create customers
            Customer customer1 = new Customer(1, "Ahmed Al-Balushi", "99887766", "Al-Dahariz, Salalah");
            Customer customer2 = new Customer(2, "Fatima Al-Rashdi", "98765432", "Al-Hafa, Salalah");
            Customer customer3 = new Customer(3, "Mohammed Al-Mashani", "97654321", "Salalah Industrial Area");
            Customer customer4 = new Customer(4, "Sara Al-Kathiri", "96543210", "Al-Husn, Salalah");

            // Create drivers
            Driver driver1 = new Driver(101, "Salem Al-Amri", "91234567");
            Driver driver2 = new Driver(102, "Khalid Al-Busaidi", "92345678");
            Driver driver3 = new Driver(103, "Ali Al-Harthy", "93456789");

            // Store all drivers and customers for reference
            List<Driver> allDrivers = new List<Driver> { driver1, driver2, driver3 };
            List<Customer> allCustomers = new List<Customer> { customer1, customer2, customer3, customer4 };

            // Display registered drivers
            Console.WriteLine("*** Registered Drivers ***\n");
            foreach (Driver driver in allDrivers)
            {
                driver.DisplayDriverrInfo();
                Console.WriteLine();
            }

            // Display registered customers
            Console.WriteLine("\n*** Registered Customers ***\n");
            foreach (Customer customer in allCustomers)
            {
                customer.DisplayCustomerInfo();
                Console.WriteLine();
            }

            // Create delivery requests
            Console.WriteLine("\n=== Creating Delivery Requests ===\n");

            DeliveryRequest delivery1 = new DeliveryRequest(1001, customer1, driver1);
            Console.WriteLine($"✓ delivery #{delivery1.deliveryid} created for {customer1.CustomerName}");

            DeliveryRequest delivery2 = new DeliveryRequest(1002, customer2, driver1);
            Console.WriteLine($"✓ delivery #{delivery2.deliveryid} created for {customer2.CustomerName}");

            DeliveryRequest delivery3 = new DeliveryRequest(1003, customer3, driver2);
            Console.WriteLine($"✓ delivery #{delivery3.deliveryid} created for {customer3.CustomerName}");

            DeliveryRequest delivery4 = new DeliveryRequest(1004, customer4, driver2);
            Console.WriteLine($"✓ delivery #{delivery4.deliveryid} created for {customer4.CustomerName}");

            DeliveryRequest delivery5 = new DeliveryRequest(1005, customer1, driver3);
            Console.WriteLine($"✓ delivery #{delivery5.deliveryid} created for {customer1.CustomerName}");

            // Store all deliveries
            List<DeliveryRequest> allDeliveries = new List<DeliveryRequest>
            {
                delivery1, delivery2, delivery3, delivery4, delivery5
            };

            // Display all delivery information
            Console.WriteLine("\n\n*** All Delivery Requests ***\n");
            foreach (DeliveryRequest delivery in allDeliveries)
            {
                delivery.DisplayDeliveryInfo();
            }

            // Update delivery statuses
            Console.WriteLine("\n=== Updating Delivery Statuses ===\n");
            delivery1.UpdateStatus("On the Way");
            delivery2.UpdateStatus("Delivered");
            delivery3.UpdateStatus("On the Way");
            delivery4.UpdateStatus("Pending");
            delivery5.UpdateStatus("On the Way");

            // Try an invalid status
            Console.WriteLine();
            delivery1.UpdateStatus("Cancelled"); // Should show error message

            // Display updated deliveries
            Console.WriteLine("\n\n*** Updated Delivery Information ***\n");
            delivery1.DisplayDeliveryInfo();
            delivery2.DisplayDeliveryInfo();
            delivery3.DisplayDeliveryInfo();

            // Show deliveries by driver (demonstrating multiple deliveries per driver)
            Console.WriteLine("\n=== Deliveries by Driver ===\n");

            foreach (Driver driver in allDrivers)
            {
                var driverDeliveries = allDeliveries.Where(d => d.driver.id == driver.id).ToList();

                Console.WriteLine($"*** Driver: {driver.DriverrName} ***");
                Console.WriteLine($"total deliveries: {driverDeliveries.Count}");

                if (driverDeliveries.Count > 0)
                {
                    foreach (DeliveryRequest delivery in driverDeliveries)
                    {
                        Console.WriteLine($"  - delivery #{delivery.deliveryid}: {delivery.customer.CustomerName} [{delivery.status}]");
                    }
                }
                Console.WriteLine();
            }

            // Show delivery status summary
            Console.WriteLine("\n=== Delivery Status Summary ===\n");

            int pendingCount = allDeliveries.Count(d => d.status == "Pending");
            int onTheWayCount = allDeliveries.Count(d => d.status == "On the Way");
            int deliveredCount = allDeliveries.Count(d => d.status == "Delivered");

            Console.WriteLine($"pending: {pendingCount}");
            Console.WriteLine($"on the way: {onTheWayCount}");
            Console.WriteLine($"delivered: {deliveredCount}");
            Console.WriteLine($"total deliveries: {allDeliveries.Count}");

            // Show pending deliveries
            Console.WriteLine("\n*** Pending Deliveries ***\n");
            var pendingDeliveries = allDeliveries.Where(d => d.status == "Pending").ToList();

            if (pendingDeliveries.Count == 0)
            {
                Console.WriteLine("no pending deliveries.\n");
            }
            else
            {
                foreach (DeliveryRequest delivery in pendingDeliveries)
                {
                    Console.WriteLine($"delivery #{delivery.deliveryid}");
                    Console.WriteLine($"  customer: {delivery.customer.CustomerName}");
                    Console.WriteLine($"  address: {delivery.customer.Address}");
                    Console.WriteLine($"  driver: {delivery.driver.DriverrName}");
                    Console.WriteLine();
                }
            }

            // Show completed deliveries
            Console.WriteLine("*** Completed Deliveries ***\n");
            var completedDeliveries = allDeliveries.Where(d => d.status == "Delivered").ToList();

            if (completedDeliveries.Count == 0)
            {
                Console.WriteLine("no completed deliveries.\n");
            }
            else
            {
                foreach (DeliveryRequest delivery in completedDeliveries)
                {
                    Console.WriteLine($"delivery #{delivery.deliveryid}");
                    Console.WriteLine($"  customer: {delivery.customer.CustomerName}");
                    Console.WriteLine($"  driver: {delivery.driver.DriverrName}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}






















// ------------------------------------------------------------- Salalah Book Cafe -------------------------------------------------------------


/*
using ClassWorkProjects.Models.Salalah_Book_Café;
using ClassWorkProjects.Models.Salalah_Delivery_Express;
using System;
using System.Collections.Generic;

namespace ClassWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Salalah Book Café Management System ===\n");

            // Create menu items
            MenuItem coffee = new MenuItem(1, "Arabic Coffee", 1.50m);
            MenuItem tea = new MenuItem(2, "Karak Tea", 1.00m);
            MenuItem latte = new MenuItem(3, "Latte", 2.50m);
            MenuItem juice = new MenuItem(4, "Fresh Orange Juice", 2.00m);
            MenuItem cake = new MenuItem(5, "Chocolate Cake", 3.00m);

            // Create books
            Book book1 = new Book(101, "The Arabian Nights", "Anonymous");
            Book book2 = new Book(102, "Desert Wisdom", "Ahmed Al-Rashid");
            Book book3 = new Book(103, "Omani Tales", "Salma Al-Harthy");
            Book book4 = new Book(104, "Frankincense Road", "Khalid Al-Amri");
            Book book5 = new Book(105, "Salalah Stories", "Fatima Al-Mashani");

            // Create customers
            CafeCustomer customer1 = new CafeCustomer(1, "Sara Al-Balushi", "99123456");
            CafeCustomer customer2 = new CafeCustomer(2, "Ali Al-Kathiri", "98765432");
            CafeCustomer customer3 = new CafeCustomer(3, "Maryam Al-Rashdi", "97654321");

            // Display menu
            Console.WriteLine("*** Café Menu ***\n");
            coffee.DisplayMenuItem();
            tea.DisplayMenuItem();
            latte.DisplayMenuItem();
            juice.DisplayMenuItem();
            cake.DisplayMenuItem();

            // Display available books
            Console.WriteLine("\n*** Available Books ***\n");
            book1.DisplayBookInfo();
            book2.DisplayBookInfo();
            book3.DisplayBookInfo();
            book4.DisplayBookInfo();
            book5.DisplayBookInfo();

            Console.WriteLine("\n\n=== Customer Activities ===\n");

            // Customer 1: Sara orders and borrows books
            Console.WriteLine("--- Sara's Visit ---");
            customer1.OrderItem(coffee);
            customer1.OrderItem(cake);
            customer1.BorrowBook(book1);
            customer1.BorrowBook(book2);
            customer1.BorrowBook(book3); // Should fail - max 2 books

            // Customer 2: Ali orders and borrows
            Console.WriteLine("\n--- Ali's Visit ---");
            customer2.OrderItem(tea);
            customer2.OrderItem(tea); // Orders 2 teas
            customer2.BorrowBook(book3);
            customer2.BorrowBook(book1); // Should fail - already borrowed

            // Customer 3: Maryam orders
            Console.WriteLine("\n--- Maryam's Visit ---");
            customer3.OrderItem(latte);
            customer3.OrderItem(juice);
            customer3.BorrowBook(book4);

            // Display all customer information
            Console.WriteLine("\n\n*** Customer Information ***\n");
            customer1.DisplayCustomerInfo();
            customer2.DisplayCustomerInfo();
            customer3.DisplayCustomerInfo();

            // Display current book status
            Console.WriteLine("*** Current Book Status ***\n");
            book1.DisplayBookInfo();
            book2.DisplayBookInfo();
            book3.DisplayBookInfo();
            book4.DisplayBookInfo();
            book5.DisplayBookInfo();

            // Sara returns books
            Console.WriteLine("\n--- Sara Returns Books ---");
            customer1.ReturnBook(book1);
            customer1.ReturnBook(book2);

            // Ali tries to borrow now that book1 is available
            Console.WriteLine("\n--- Ali Borrows Again ---");
            customer2.BorrowBook(book1); // Should work now

            // Final book status
            Console.WriteLine("\n*** Final Book Status ***\n");
            book1.DisplayBookInfo();
            book2.DisplayBookInfo();
            book3.DisplayBookInfo();
            book4.DisplayBookInfo();
            book5.DisplayBookInfo();

            // Final customer summaries
            Console.WriteLine("\n*** Final Customer Summaries ***\n");
            customer1.DisplayCustomerInfo();
            customer2.DisplayCustomerInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}




*/



















// ------------------------------------------------------------- Dhofar Car Rental -------------------------------------------------------------

/*
 
using ClassWorkProjects.Models.Dhofar_Car_Rental;
using ClassWorkProjects.Models.Salalah_Delivery_Express;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Dhofar Car Rental Management System ===\n");

            // Create cars
            Car car1 = new Car(1, "Camry", "Toyota", 25.00m);
            Car car2 = new Car(2, "Patrol", "Nissan", 40.00m);
            Car car3 = new Car(3, "Accord", "Honda", 28.00m);
            Car car4 = new Car(4, "Land Cruiser", "Toyota", 50.00m);
            Car car5 = new Car(5, "Altima", "Nissan", 22.00m);

            List<Car> allCars = new List<Car> { car1, car2, car3, car4, car5 };

            // Create customers
            CarRentalCustomer customer1 = new CarRentalCustomer(101, "Ahmed Al-Balushi", "99887766", "DH123456");
            CarRentalCustomer customer2 = new CarRentalCustomer(102, "Fatima Al-Kathiri", "98765432", "DH234567");
            CarRentalCustomer customer3 = new CarRentalCustomer(103, "Salem Al-Rashdi", "97654321", "DH345678");
            CarRentalCustomer customer4 = new CarRentalCustomer(104, "Maryam Al-Amri", "96543210", "DH456789");

            // Display available cars
            Console.WriteLine("*** Available Cars for Rent ***\n");
            foreach (Car car in allCars)
            {
                car.DisplayCarInfo();
            }

            // Display customer information
            Console.WriteLine("\n*** Registered Customers ***\n");
            customer1.DisplayCustomerInfo();
            Console.WriteLine();
            customer2.DisplayCustomerInfo();
            Console.WriteLine();

            // Create rental records
            Console.WriteLine("\n=== Creating Rental Transactions ===\n");

            RentalRecord rental1 = new RentalRecord(1001, customer1, car1, 5);
            Console.WriteLine($"✓ rental created: {customer1.CRname} rented {car1.brand} {car1.model} for {rental1.durationdays} days");

            RentalRecord rental2 = new RentalRecord(1002, customer2, car2, 3);
            Console.WriteLine($"✓ rental created: {customer2.CRname} rented {car2.brand} {car2.model} for {rental2.durationdays} days");

            RentalRecord rental3 = new RentalRecord(1003, customer3, car4, 7);
            Console.WriteLine($"✓ rental created: {customer3.CRname} rented {car4.brand} {car4.model} for {rental3.durationdays} days");

            RentalRecord rental4 = new RentalRecord(1004, customer4, car5, 2);
            Console.WriteLine($"✓ rental created: {customer4.CRname} rented {car5.brand} {car5.model} for {rental4.durationdays} days");

            List<RentalRecord> allRentals = new List<RentalRecord> { rental1, rental2, rental3, rental4 };

            // Display all rental information
            Console.WriteLine("\n\n*** Active Rental Records ***\n");
            rental1.DisplayRentalInfo();
            rental2.DisplayRentalInfo();
            rental3.DisplayRentalInfo();
            rental4.DisplayRentalInfo();

            // Check available cars
            Console.WriteLine("*** Currently Available Cars ***\n");
            List<Car> availableCars = allCars.Where(c => c.isavailable).ToList();

            if (availableCars.Count == 0)
            {
                Console.WriteLine("no cars available at the moment.\n");
            }
            else
            {
                foreach (Car car in availableCars)
                {
                    car.DisplayCarInfo();
                }
            }

            // Complete some rentals
            Console.WriteLine("\n=== Completing Rentals ===\n");
            rental1.CompleteRental();
            rental3.CompleteRental();

            // Check available cars again
            Console.WriteLine("\n*** Currently Available Cars ***\n");
            availableCars = allCars.Where(c => c.isavailable).ToList();

            foreach (Car car in availableCars)
            {
                car.DisplayCarInfo();
            }

            // Calculate revenue
            Console.WriteLine("\n=== Revenue Report ===\n");

            decimal totalRevenue = 0;
            decimal activeRevenue = 0;
            decimal completedRevenue = 0;

            foreach (RentalRecord rental in allRentals)
            {
                totalRevenue += rental.totalcost;

                if (rental.isactive)
                {
                    activeRevenue += rental.totalcost;
                }
                else
                {
                    completedRevenue += rental.totalcost;
                }
            }

            Console.WriteLine($"total revenue (all rentals): {totalRevenue:C} OMR");
            Console.WriteLine($"active rentals revenue: {activeRevenue:C} OMR");
            Console.WriteLine($"completed rentals revenue: {completedRevenue:C} OMR");
            Console.WriteLine($"total number of rentals: {allRentals.Count}");
            Console.WriteLine($"active rentals: {allRentals.Count(r => r.isactive)}");
            Console.WriteLine($"completed rentals: {allRentals.Count(r => !r.isactive)}");

            // Display detailed breakdown
            Console.WriteLine("\n*** Detailed Revenue Breakdown ***\n");
            foreach (RentalRecord rental in allRentals)
            {
                string status = rental.isactive ? "[ACTIVE]" : "[COMPLETED]";
                Console.WriteLine($"rental #{rental.rentalid} {status}: {rental.customer.CRname} - {rental.car.brand} {rental.car.model} = {rental.totalcost:C} OMR");
            }

            // Final car status
            Console.WriteLine("\n\n*** Final Car Fleet Status ***\n");
            foreach (Car car in allCars)
            {
                car.DisplayCarInfo();
            }

            // Customer rental history
            Console.WriteLine("\n*** Customer: Ahmed Al-Balushi ***\n");
            customer1.DisplayCustomerInfo();
            Console.WriteLine("\nrental history:");
            var customer1Rentals = allRentals.Where(r => r.customer.CRid == customer1.CRid).ToList();
            foreach (RentalRecord rental in customer1Rentals)
            {
                Console.WriteLine($"  - rental #{rental.rentalid}: {rental.car.brand} {rental.car.model} ({rental.durationdays} days) - {rental.totalcost:C} OMR [{(rental.isactive ? "ACTIVE" : "COMPLETED")}]");
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

*/




















// ------------------------------------------------------------- Salalah Sports Leage -------------------------------------------------------------
/* 
using ClassWorkProjects.Models.Salalah_Sports_League;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Salalah Sports League ===");
            Console.WriteLine("Annual Football League organized by Salalah Municipality\n");

            // Create coaches
            Coach coach1 = new Coach(1, "Ahmed Al-Balushi", 45);
            Coach coach2 = new Coach(2, "Khalid Al-Rashdi", 38);
            Coach coach3 = new Coach(3, "Salem Al-Kathiri", 42);

            // Create teams
            Team team1 = new Team(1, "Salalah Academy FC", coach1);
            Team team2 = new Team(2, "Dhofar Youth United", coach2);
            Team team3 = new Team(3, "Mirbat Sports Club", coach3);

            List<Team> league = new List<Team> { team1, team2, team3 };

            // Add players to teams
            Console.WriteLine("=== Building Team Rosters ===\n");

            team1.AddPlayer(new Player(10, "Ali Al-Hinai", 22, "Forward"));
            team1.AddPlayer(new Player(7, "Yousuf Al-Maskari", 24, "Midfielder"));
            team1.AddPlayer(new Player(5, "Hassan Al-Busaidi", 26, "Defender"));
            team1.AddPlayer(new Player(1, "Salim Al-Wahaibi", 28, "Goalkeeper"));

            Console.WriteLine();
            team2.AddPlayer(new Player(9, "Omar Al-Shanfari", 21, "Forward"));
            team2.AddPlayer(new Player(8, "Badr Al-Rashdi", 23, "Midfielder"));
            team2.AddPlayer(new Player(4, "Nasser Al-Amri", 25, "Defender"));
            team2.AddPlayer(new Player(1, "Khalid Al-Harthy", 27, "Goalkeeper"));

            Console.WriteLine();
            team3.AddPlayer(new Player(11, "Mohammed Al-Buraiki", 20, "Forward"));
            team3.AddPlayer(new Player(6, "Salem Al-Ghafri", 22, "Midfielder"));
            team3.AddPlayer(new Player(3, "Fatima Al-Rawahi", 24, "Defender"));
            team3.AddPlayer(new Player(1, "Aisha Al-Kathiri", 26, "Goalkeeper"));

            // Display teams
            Console.WriteLine("\n=== League Teams ===\n");
            team1.DisplayTeamInfo();
            team2.DisplayTeamInfo();
            team3.DisplayTeamInfo();

            // Play matches and record results
            Console.WriteLine("\n=== Match Results ===\n");

            Match match1 = new Match(1, team1, team2, 3, 1);
            match1.DisplayMatchInfo();

            Match match2 = new Match(2, team2, team3, 2, 2);
            match2.DisplayMatchInfo();

            Match match3 = new Match(3, team1, team3, 1, 0);
            match3.DisplayMatchInfo();

            // Display league standings
            Console.WriteLine("\n=== League Standings ===\n");
            Console.WriteLine("Team                      | Record          | Points");
            Console.WriteLine("--------------------------------------------------");

            var standings = league.OrderByDescending(t => t.points)
                                  .ThenByDescending(t => t.wins)
                                  .ToList();

            foreach (Team team in standings)
            {
                team.DisplayStandings();
            }

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

*/


