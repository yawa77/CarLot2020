using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot2020
{
    class Vehicle
    {
        static int vehCount;
        string make;
        string model;
        int purchasePrice;
        int askingPrice;


        public Vehicle(string vehMake, string vehModel, int purchasePrice, int askingPrice)
        {
            vehMake = make;
            vehModel = model;
            this.purchasePrice = purchasePrice;
            this.askingPrice = askingPrice;
        }


    }
}
