﻿namespace FoodShortage
{
    using System;

    public interface IBuyer
    {
        string Name { get; }

        int Food { get; }

        void BuyFood();
    }
}
