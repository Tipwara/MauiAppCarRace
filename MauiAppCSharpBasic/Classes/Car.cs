using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCSharpBasic.Classes;

public class Car
{ //Properties
    public string Model;

    public string Color;

    public double Speed;

    public double RemainingFuel;

    public int TotalDistance;

    public double UseFuelRate;
    //Constructure
    public Car(string model, double speed, double remaining_fuel) 
    {
        this.Model = model;
        this.Speed = speed;
        this.RemainingFuel = remaining_fuel;
    }
    //Method
    public void CarCalculator(int Distance, int Fuel) 
    {
        this.TotalDistance += Distance;
        var used_fuel = Distance * this.UseFuelRate;
        this.RemainingFuel = RemainingFuel - used_fuel;
    }


    public uint TimeUseForRun(double mile) 
    {
        var timeuse = mile / Speed; //ผลลัพธ์จากการหาร mile/speed = double 
        //ต้องการ convert ให้ผลลัพธ์เป็น int
        return Convert.ToUInt16(timeuse);
    }

    public string ShowResult() 
    {
        var result = $"Model:{this.Model}\n Total distance:{TotalDistance}\n Remaining Fuel:{RemainingFuel}";
        return result;

    }
}

