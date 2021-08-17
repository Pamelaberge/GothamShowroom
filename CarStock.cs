using System;
namespace MandatoryAssignment2
{
    public class CarStock
    {
        
        public bool correctPassword = false;
        public bool correctUsername = false;
        public int carStock = 20;
        public int price = 70000;
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string TypeName { get; set; }
        
        
        public CarStock() 
        {
           this.Username = "Pamela Berge";
           this.Password = "Pamisthebest";
            
        }
        public string GetUsername(string usernameInput)
        {
            if (usernameInput.Equals(this.Username))
            {
                this.correctUsername = true;
                return "Username validated";
            }
            else
            {
                return "Username not recognized";
            }
        }
        public string GetPassword(string passwordInput) 
        {
            if (passwordInput.Equals(this.Password))
            {
                this.correctPassword = true;
                return "Password correct";
            }
            else
            {
                return "You are not authorized to access this service";
            }
        }
        public int TotalValue(int price)
        {
            int result = price;
            return result;
        }
        public int OneCarSold(int carStock) 
        {
            int resultA = carStock;
            return resultA;
        }
        public string StockStatus(int resultB)
        {
            if (resultB >= 100)
                return "Over";
            else if (resultB <= 99 && resultB > 25)
                return "Normal";
            else if (resultB <= 24 && resultB > 11)
                return "Low";
            else if (resultB < 10)
                return "Very Low";
            else
            {
                return "error";
            }
        }
    } 
}
