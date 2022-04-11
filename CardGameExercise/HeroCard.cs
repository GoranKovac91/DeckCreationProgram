﻿using System;

namespace CardGameExcercise
{
    public class HeroCard : CardMain
    {
        private int _armor;
        public HeroCard(int manaCost, string name, Rarity rarity, int armor) : base(manaCost, name, rarity)
        {
            this._armor = armor;
        }
    }
}
