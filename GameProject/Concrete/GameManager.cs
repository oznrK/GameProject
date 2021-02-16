﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " oyunu eklendi " + " oyun fiyatı: " + game.Price);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Oyunu silindi ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " oyunu güncellendi. ");
        }
    }
}
