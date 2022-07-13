/*Title: Online Shopping Portal
 * Author: Muthukumar V
 * Created at: 28/12/2021
 * Updated at: 17/01/2022
 * Reviewed by: Akshaya
 */

using System;
using System.Text.RegularExpressions;

namespace OnlineShopping
{
    public class CreateAccount
    {
        protected string validName="";
        protected string validEmail="";
        protected string validPassword="";
        public CreateAccount()
        {
            Console.WriteLine("Create Your Account!!!");
        }
        public void getUserName()
        {

        UserName:
            int count = 0;
            Console.Write("Enter your Name:");
            string Name = Console.ReadLine();
            int length = Name.Length;
            for (int initial = 0; initial < length; initial++)
            {
                if (!(Name[initial] >= 'A' && Name[initial] <= 'Z') && !(Name[initial] >= 'a' && Name[initial] <= 'z'))
                {
                    Console.WriteLine("Enter the valid Username(It should contain only alphabets):");
                    goto UserName;
                }
                else
                {
                    count++;
                }
            }
            if (count == length)
            {
                validName = Name;
                Console.WriteLine("Valid Name");
            }
        }
        public void getAge() //Get User Age
        {
            string validAge;
            Console.Write("Enter Your Age:");
        initialPoint:

            string age = Console.ReadLine();
            int agecount = 0;
            for(int start=0;start<age.Length;start++)
            {
                if(age[start]>='0' && age[start]<='9')
                {
                    agecount++;
                }
            }
            if (agecount==age.Length)
            {
                validAge = age;
            }
            else
            {
                Console.Write("Enter the valid age :");
                goto initialPoint;
            }
        }
        public void getCity() // get User city
        {
            string validCity;
        City:
            int count = 0;
            Console.Write("Enter your City:");
            string city = Console.ReadLine();
            int citylength = city.Length;
            for (int initial = 0; initial < citylength; initial++)
            {
                if (!(city[initial] >= 'A' && city[initial] <= 'Z') && !(city[initial] >= 'a' && city[initial] <= 'z'))
                {
                    Console.WriteLine("Enter the valid City(It should contain only alphabets):");
                    goto City;
                }
                else
                {
                    count++;
                }
            }
            if (count == citylength)
            {
                validCity = city;
                Console.WriteLine("Valid City");
            }
        }
        public void getEmail() // Get User Gmail ID
        {

        Email:
            Console.Write("Enter Email Id:");

            string UserEmail = Console.ReadLine();

            //bool IsValidEmail = false;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w]+)((\.([com]){2,3})+)$");

            if (regex.IsMatch(UserEmail))
            {
                //IsValidEmail = true;
                validEmail = UserEmail;
            }
            else
            {
                Console.Write("Email is not valid:");
                goto Email;
            }
        }
        public void getPassword()       //Password check
        {
            //string validPassword;
            Console.Write("Password:");
        Password:
            string password = Console.ReadLine();
            string ErrorMessage = " ";
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                Console.WriteLine("Password should contain at least one lower case letter.");
                goto Password;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                Console.WriteLine("Password should contain at least one upper case letter.");
                goto Password;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                Console.WriteLine("Password should not be lesser than 8 or greater than 15 characters.");
                goto Password;
            }
            else if (!hasNumber.IsMatch(input))
            {
                Console.WriteLine("Password should contain at least one numeric value.");
                goto Password;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                Console.WriteLine("Password should contain at least one special case character.");
                goto Password;
            }
            else
            {
                validPassword = password;
                Console.WriteLine("Your Account has been Successfully Created!!!!!!!!!");
            }
        }
        protected string username()
        {
            return validName;
        }
        protected string email()
        {
            return validEmail;
        }
        protected string password()
        {
            return validPassword;
        }
    }
    public class Login : CreateAccount
    {
        public Login() : base()
        {
            //base();
            base.getUserName();
            base.getAge();
            base.getCity();
            base.getEmail();
            base.getPassword();
            Console.WriteLine("Login Your Account!!!");
        }
        public void userMail()
        {
        Log:
            Console.WriteLine("Enter the mail id:");
            string usermail = Console.ReadLine();
            Console.WriteLine("Enter the Password:");
            string password = Console.ReadLine();
            if (base.email() == usermail && base.password() == password)
            {
                Console.WriteLine("Logged in Successfully!!!");
                Console.WriteLine("Hi!! " + base.username()+" Welcome to Online Shopping Portal!!!");
            }
            else
            {
                Console.WriteLine("Enter the Valid Mailid and Password");
                goto Log;
            }
        }
    }
    class Products
    {
        public Products()
        {
            Console.WriteLine("\n\nAvailable Products:" +
                    "\n1.Vivo Y33 Cost:18,500" +
                    "\n2.Vivo Y21 Cost:20,500" +
                    "\n3.Vivo V21 Cost:30,000" +
                    "\n4.Vivo X70 Cost:50,000" +
                    "\n5.Vivo V20 Pro Cost:31,000\n\n");
        }
        public void getChoice()
        {
            Console.Write("Choose your Choice:");
        ChooseChoice:
            int Choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the quantity of the Product:");
        initialPoint:
            int Quantity = Convert.ToInt32(Console.ReadLine());
            if (Quantity < 1 || Quantity >= 100)
            {
                Console.WriteLine("Enter the Valid Quantity:");
                goto initialPoint;
            }
            int Total;
            string ProductName;
            int ProductPrice;
            switch (Choice)
            {
                case 1:
                    ProductName = "Vivo Y33";
                    ProductPrice = 18500;
                    Console.WriteLine("\nProduct Name: " + ProductName);
                    Console.WriteLine("Product Price: " + ProductPrice);
                    Total = ProductPrice * Quantity;
                    Console.WriteLine("Quantity of Product: " + Quantity);
                    Console.WriteLine("Product Total Price: " + Total);
                    break;
                case 2:
                    ProductName = "Vivo Y21";
                    ProductPrice = 20500;
                    Console.WriteLine("\nProduct Name: " + ProductName);
                    Console.WriteLine("Product Price: " + ProductPrice);
                    Total = ProductPrice * Quantity;
                    Console.WriteLine("Quantity of Product: " + Quantity);
                    Console.WriteLine("Product Total Price: " + Total);
                    break;
                case 3:
                    ProductName = "Vivo V21";
                    ProductPrice = 30000;
                    Console.WriteLine("\nProduct Name: " + ProductName);
                    Console.WriteLine("Product Price: " + ProductPrice);
                    Total = ProductPrice * Quantity;
                    Console.WriteLine("Quantity of Product: " + Quantity);
                    Console.WriteLine("Product Total Price: " + Total);
                    break;
                case 4:
                    ProductName = "Vivo X70";
                    ProductPrice = 50000;
                    Console.WriteLine("\nProduct Name: " + ProductName);
                    Console.WriteLine("Product Price: " + ProductPrice);
                    Total = ProductPrice * Quantity;
                    Console.WriteLine("Quantity of Product: " + Quantity);
                    Console.WriteLine("Product Total Price: " + Total);
                    break;
                case 5:
                    ProductName = "Vivo V20";
                    ProductPrice = 31000;
                    Console.WriteLine("\nProduct Name: " + ProductName);
                    Console.WriteLine("Product Price: " + ProductPrice);
                    Total = ProductPrice * Quantity;
                    Console.WriteLine("Quantity of Product: " + Quantity);
                    Console.WriteLine("Product Total Price: " + Total);
                    break;
                default:
                    Console.WriteLine("Please Choose Correct Choice:");
                    goto ChooseChoice;
            }
        }
    }
    class Address : Products
    {
        public Address() : base()
        {
            base.getChoice();
            Console.WriteLine("\nEnter the Address:");
        }
        public void getAddress() //Shipping Details from User
        {
        UserAddress:
            var userAddress = Console.ReadLine();
            Console.WriteLine("Check the Address: ");
            Console.WriteLine(userAddress);
            Console.WriteLine("To Confirm enter 1 or To Re enter the address enter 0");
            int confirm = Convert.ToInt32(Console.ReadLine());
            if (confirm == 1)
            {
                Console.WriteLine("Address Verified!!!");
            }
            else
            {
                Console.WriteLine("Re Enter the Address:");
                goto UserAddress;
            }
        }
        public void getMobile()
        {
        MobileNumber:
            Console.Write("\nEnter your Mobile Number:");
            string Number = Console.ReadLine();
            int length = Number.Length;
            if (length == 10)
            {
                if ((Number[0] == '6') || (Number[0] == '7') || (Number[0] == '8') || (Number[0] == '9'))
                {
                    int countnum = 0;
                    for (int start = 0; start < length; start++)
                    {
                        if (Number[start] >= '0' && Number[start] <= '9')
                        {
                            countnum++;
                        }
                    }
                    if (countnum == length)
                    {
                        Console.WriteLine("Phone Number Verified!!!");
                    }
                    else
                    {
                        Console.WriteLine("\nPhone numbers contains 10 digits:");
                        goto MobileNumber;
                    }
                }
                else
                {
                    Console.WriteLine("\nPhone numbers should start in 6,7,8 or 9:");
                    goto MobileNumber;
                }
            }
            else
            {
                Console.WriteLine("\nEnter a valid Phone Number");
                goto MobileNumber;
            }
        }
    }
    class Payment
    {
        public void getPaymentType() //Payment
        {
            string BankName;
            string CardNumber;
            int ExpiryMonth;
            int ExpiryYear;
            int Pin;
            Console.WriteLine("\n1.Debit Card:" +
                "\n2.Credit Card:" +
                "\n3.Cash On Delivery:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Bank Name: ");
                    BankName = Console.ReadLine();
                    Console.WriteLine("Account Number: ");
                    CardNumber = Console.ReadLine();
                    Console.WriteLine("Expiry Month: ");
                    ExpiryMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Expiry Year: ");
                    ExpiryYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Pin: ");
                    Pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Thanks For Purchasing");
                    break;
                case 2:
                    Console.WriteLine("Bank Name: ");
                    BankName = Console.ReadLine();
                    Console.WriteLine("Account Number: ");
                    CardNumber = Console.ReadLine();
                    Console.WriteLine("Expiry Month: ");
                    ExpiryMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Expiry Year: ");
                    ExpiryYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Pin: ");
                    Pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Thanks For Purchasing");
                    break;
                case 3:
                    Console.WriteLine("Thanks For Purchasing");
                    break;
            }
            Console.WriteLine("Your Order Confirmed!!!");
            Console.WriteLine("Please Visit Again......");
        }
    }
    class OnlineShoppingApplication
    {
        static void Main(string[] args) //Main Function
        {
            Login login = new Login();
            login.userMail();
            Address address = new Address();
            address.getAddress();
            address.getMobile();
            Payment payment = new Payment();
            payment.getPaymentType();
        }
    }
}