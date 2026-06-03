Console.Write("Where will you be driving? ");
string location = Console.ReadLine();  // Location

Console.Write("What is the name of the driver? ");
string driver = Console.ReadLine();  // Driver Name

Console.Write($"How many miles away is {location} (in miles)? ");
string textdistance = Console.ReadLine();  // Distance
int distance = Convert.ToInt32(textdistance);

Console.Write($"In miles per hour how what is the average speed {driver} will be driving? ");
string textavgSpeed = Console.ReadLine();  // Speed
int avgSpeed = Convert.ToInt32(textavgSpeed);

Console.Write("How many MPG does the car get? ");
string textmpg = Console.ReadLine();  // Miles per gallon
int mpg = Convert.ToInt32(textmpg);

Console.Write("How many gallons of gas can the car hold? ");
string textgasTank = Console.ReadLine();  // Gas Tank Capacity
int gasTank = Convert.ToInt32(textgasTank);

Console.Write($"How many people will be in the car excluding {driver}? ");
string textpassengers = Console.ReadLine();  // Number of Passengers
int passengers = Convert.ToInt32(textpassengers);

Console.Write("What unit of currency ($, £, ¥, €) will you be using?" );
string currency = Console.ReadLine();  // Currency

Console.Write("What is the price of gas per gallon? ");
string textgasPrice = Console.ReadLine();  // Gas Price
double gasPrice = Convert.ToDouble(textgasPrice);

Console.WriteLine();  // Blank line for spacing


Console.WriteLine($"Driver:                  {driver, -10}"); // Display driver name
Console.WriteLine($"Currency:                {currency, -10}"); // Display currency, formatted with left alignment and a width of 10 characters

Console.WriteLine();  // Blank line for spacing

Console.WriteLine($"Distance (miles):        {distance, -10}"); // Distance to the destination in miles
Console.WriteLine($"Avg Speed (mph):         {avgSpeed, -10}"); // Average speed in miles per hour

double hours = (double)distance / avgSpeed;

int driveHours = (int)hours;
int driveMinutes = (int)((hours - driveHours) * 60);

Console.WriteLine($"Time Driving:            {driveHours}H {driveMinutes}M"); // Time spent driving, formatted as hours and minutes

Console.WriteLine();  // Blank line for spacing

Console.WriteLine($"MPG:                     {mpg, -10}"); // Miles per gallon

double gallonsUsed = (double)distance / mpg;
Console.WriteLine($"Gallons Used:            {gallonsUsed, -10:N2}"); // Gallons of gas used, formatted to 2 decimal places

Console.WriteLine($"Gas Tank (gals):         {gasTank, -10}"); // Gas tank capacity

double stops = gallonsUsed / gasTank;
int gasStops = (int)Math.Ceiling(stops);
Console.WriteLine($"Gas Stops:               {gasStops, -10:D}"); // Number of gas stops, rounded up

Console.WriteLine();  // Blank line for spacing

double totalGasCost = gallonsUsed * gasPrice;
Console.WriteLine($"Total Gas Cost:          {currency}{totalGasCost, -10:N2}"); // Total gas cost

double costPerPerson = totalGasCost / (passengers + 1);
Console.WriteLine($"Cost Per Person:         {currency}{costPerPerson,-10:N2}"); // Cost per person, formatted to 2 decimal places

double costPerMile = totalGasCost / distance;
Console.WriteLine($"Cost Per Mile:           {currency}{costPerMile, -10:N2}"); // Cost per mile

double costPerHour = totalGasCost / hours;
Console.WriteLine($"Cost Per Hour:           {currency}{costPerHour, -10:N2}"); // Cost per hour

Console.WriteLine();  // Blank line for spacing

double avgSongLength = 3.5; // Average song length in minutes
double totalDriveMinutes = hours * 60;
double songsPlayed = totalDriveMinutes / avgSongLength;
Console.WriteLine($"Avg Song Length (mins):  {avgSongLength, -10:N1}"); // Display the average song length, formatted to 1 decimal place

Console.WriteLine($"Songs Played:            {songsPlayed, -10:N0}"); // Display the number of songs played, formatted as a whole number