// File:    hand_worker.cs
// Author:  David
// Created: вторник, 13 ноября 2018 г. 07:23:33
// Purpose: Definition of Class hand_worker

using System;

public class hand_worker
{
    private int num_pos { get; set; }
    private int qualification { get; set; }


    public int Num_pos
    {
        get { return num_pos; }
        set { num_pos = value; }
    }
    public int Qualification
    {
        get { return qualification; }
        set { qualification = value; }
    }
    public hand_worker()      //конструктор за замовчуванням
    {
        num_pos = 1;
        qualification = 5;
       // Console.WriteLine("The hand_worker was created by default");
    }
    public hand_worker(int num, int qual)      //конструктор ініціалізації
    {
        num_pos = num;
        qualification = qual;

        Console.WriteLine("The hand_worker was created by initialisation");
    }
    public hand_worker(hand_worker arg)                //конструктор копіювання
    {
        num_pos = arg.num_pos;
        qualification = arg.qualification;
        Console.WriteLine("The hand_worker was created by copy");
    }
    ~hand_worker()                //деструктор
    {
        Console.WriteLine("The hand_worker was destructed");
    }
    public static hand_worker operator ++(hand_worker c1)
    {
        return new hand_worker { Qualification = c1.Qualification + 1 };
    }
    public static bool operator ==(hand_worker s1, hand_worker s2)   //перевантаження оператора порівняння
    {
        if (s1.Qualification == s2.Qualification)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(hand_worker s1, hand_worker s2)   //перевантаження оператора порівняння (заперечення)
    {
        if (s1.Qualification == s2.Qualification)
        {
            return false;
        }
        return true;
    }

    public void signal_stop()
   {
      throw new NotImplementedException();
   }
   
   public void visit_sems()
   {
      throw new NotImplementedException();
   }

}