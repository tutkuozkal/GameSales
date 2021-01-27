using System;
using GameSales.Entities;
using GameSales.Operations;

namespace GameSales
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.CustomerFırstName = "ALI";
            customer.CustomerLastName = "VELI";
            customer.CustomerNıckName = "ALI-1";
            customer.CustomerCıty = "ARTVIN";
            customer.CustomerAge = 20;
            Customer customer1 = new Customer();
            customer1.CustomerId = 2;
            customer1.CustomerFırstName = "AHMET";
            customer1.CustomerLastName = "MEHMET";
            customer1.CustomerNıckName = "AHMET-1";
            customer1.CustomerCıty = "KARS";
            customer1.CustomerAge = 38;

            Customer customer2 = new Customer();
            customer.CustomerId = 3;
            customer.CustomerFırstName = "HASAN";
            customer.CustomerLastName = "HUSEYIN";
            customer.CustomerNıckName = "HASAN-1";
            customer.CustomerCıty = "ANTALYA";
            customer.CustomerAge = 16;

            Game game = new Game();
            game.GameId = 111;
            game.GameName = "GAME-1";
            game.GamePrice = 0;

            Game game1 = new Game();
            game1.GameId = 222;
            game1.GameName = "GAME-2";
            game1.GamePrice = 1;

            Game game2 = new Game();
            game2.GameId = 333;
            game2.GameName = "GAME-3";
            game2.GamePrice = 2;

            CustomerOperations customerOperations = new CustomerOperations();
            customerOperations.CustomerAdd(customer);
            customerOperations.CustomerDelete(customer1);
            customerOperations.CustomerUpdate(customer2);

            GameOperations gameOperatıons = new GameOperations();
            gameOperatıons.GameAdd(game);
            gameOperatıons.GameDelete(game1);
            gameOperatıons.GameUpdate(game2);


        }
    }
}
