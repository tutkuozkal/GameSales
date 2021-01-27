using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales.Abstract
{
    interface IGameManager
    {
        public void GameAdd(Game game);
        public void GameDelete(Game game);
        public void GameUpdate(Game game);



    }
}