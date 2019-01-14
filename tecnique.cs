// File:    tecnique.cs
// Author:  David
// Created: вторник, 13 ноября 2018 г. 07:58:30
// Purpose: Definition of Class tecnique

using System;

public class tecnique
{
   private int worked_years { get; set; }

    public int Worked_years
    {
        get { return worked_years; }
        set { worked_years = value; }
    }
    public static bool operator <(tecnique obj1, tecnique obj2)
    {
        if (obj1.worked_years < obj2.worked_years)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator >(tecnique obj1, tecnique obj2)
    {
        if (obj1.worked_years > obj2.worked_years)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator ==(tecnique s1, tecnique s2)   //перевантаження оператора порівняння
    {
        if (s1.worked_years == s2.worked_years)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(tecnique s1, tecnique s2)   //перевантаження оператора порівняння (заперечення)
    {
        if (s1.worked_years == s2.worked_years)
        {
            return false;
        }
        return true;
    }
    public tecnique()      //конструктор за замовчуванням
    {
        worked_years = 0;
        Console.WriteLine("The tecnique was created by default");
    }
    public tecnique(int s)      //конструктор ініціалізації
    {

        worked_years = s;
        //tecnique tecnique = new tecnique(st);

        Console.WriteLine("The tecnique was created by initialisation");
    }
    public tecnique(tecnique arg)                //конструктор копіювання
    {
        worked_years = arg.worked_years;
        Console.WriteLine("The tecnique was created by copy");
    }
    ~tecnique()                //деструктор
    {
        Console.WriteLine("The tecnique was destructed");
    }


    public void fix_problem()
   {
      throw new NotImplementedException();
   }
   
   public void hold_sems()
   {
      throw new NotImplementedException();
   }
   
   public void repair_equip()
   {
      throw new NotImplementedException();
   }
   
   public void equip_lines_for_prototype()
   {
      throw new NotImplementedException();
   }
   
   public void check_equip()
   {
      throw new NotImplementedException();
   }

}