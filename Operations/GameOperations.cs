using GameSales.Abstract;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales.Operations
{
    public class GameOperations : IGameManager
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine(" Game Added:" + game.GameId + "  " + game.GameName);
        }

        public void GameUpdate(Game game)
        {
            Console.WriteLine("Game Update:" + game.GameId + "  " + game.GameName);
        }

        public void GameDelete(Game game)
        {
            Console.WriteLine("Game Delete:" + game.GameId + "  " + game.GameName);
        }

        
    }
}
