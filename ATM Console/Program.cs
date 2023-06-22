using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console
{
    internal class Program
    {
        String cardNum;
        int pin;
        String firstName;
        String lastName;
        double balance;

        public Program(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName; 
            this.lastName = lastName;
            this.balance = balance;
        }
        public String getNum()
        {
            return cardNum;
        }
        public int getPin()
        {
            return pin;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public double getBalance()
        {
            return balance;
        }
        public void setNum(String newCardNum) 
        {
            cardNum = newCardNum;
        }
        public void setPin(String newPin)
        {
            cardNum = newPin;
        }
        public void setFirstname(String newFirstName)
        {
            cardNum = newFirstName;
        }
        public void setLastname(String newLastName)
        {
            cardNum = newLastName;
        }
        public void setBalance(String newBalance)
        {
            cardNum = newBalance;
        }
        public static void Main(String[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Kérem válassza ki az opciőkat: ");
                Console.WriteLine("1. Depozit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }

            void depozit(Program currentUser)
            {
                Console.WriteLine("Mennyi pénz akarsz ki venni?");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposit);
                Console.WriteLine("Kösöznöm hogy ennyi bánc felvett" + currentUser.getBalance());
            }
            void withdraw(Program currentUser)
            {
                Console.WriteLine("Mennyi pénz akarsz ki venni?");
                double withdrawal = Double.Parse(Console.ReadLine());
                // Ceck if the user has enough money
                if(currentUser.getBalance() > withdrawal)
                {
                    Console.WriteLine("Insufficient balance :(");
                } 
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawal);
                    Console.WriteLine("Your're good to go! Thank you :)");
                }
            }
            void balance(Program currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.getBalance());
            }
            List<Program> cardHolders = new List<Program>();
            cardHolders.Add(new Program("23415356264611", 1234, "John", "Griffith", 150.31));
            cardHolders.Add(new Program("65362735658581", 4321, "Ashley", "Jones", 321.13));
            cardHolders.Add(new Program("75472555464647", 9999, "Frida", "Dickerson", 105.59));
            cardHolders.Add(new Program("13214535235345", 1468, "Muneeb", "Harding", 851.84));
            cardHolders.Add(new Program("64364525363473", 4826, "Dawn", "Smith", 54.27));

            // Prompz user
            Console.WriteLine("Wlcome to simpleATM");
            Console.WriteLine("Please insert your debit card: ");
            String debitCardNum = "";
            Program currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    // Check again our db
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card not recognized. Please try again"); }
                }
                catch { Console.WriteLine("Card not recognized. Please try again"); }
            }
           
            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("Incorrect pin. Please try again"); }
                }
                catch { Console.WriteLine("Incorrect pin. Please try again"); }
            }
            Console.WriteLine("Welcome " + currentUser.getFirstName() + " :)");
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if(option == 1) { depozit(currentUser); }
                else if(option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
            while (option != 4);
            Console.WriteLine("Thank you! Have a nice day :)");
        }
    }
}
