﻿namespace SoftUniRestaurant.Models.Tables
{
    using System;

    public class InsideTable : Table
    {
        private const decimal InitialPricePerPerson = 2.50M;

        public InsideTable(int tableNumber, int capacity) 
            : base(tableNumber, capacity, InitialPricePerPerson)
        {
        }
    }
}
