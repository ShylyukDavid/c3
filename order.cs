// File:    order.cs
// Author:  David
// Created: суббота, 17 ноября 2018 г. 23:08:27
// Purpose: Definition of Class order

using System;

public class order
{
   private string name_orderer { get; set; }
    private string kind_prod { get; set; }
    private int numb_prod { get; set; }
    private int dead_line { get; set; }
    private bool work_done { get; set; }

    public string Name_orderer
    {
        get { return name_orderer; }
        set { name_orderer = value; }
    }
    public int Dead_line
    {
        get { return dead_line; }
        set { dead_line = value; }
    }
    public string Kind_prod
    {
        get { return kind_prod; }
        set { kind_prod = value; }
    }
    public int Numb_prod
    {
        get { return numb_prod; }
        set { numb_prod = value; }
    }
    public int Time_spent_production
    {
        get { return dead_line; }
        set { dead_line = value; }
    }
    public bool Work_done
    {
        get { return work_done; }
        set { work_done = value; }
    }

    public order()      //конструктор за замовчуванням
    {
        name_orderer = "";
        kind_prod = "";
        numb_prod = 1;
        dead_line = 3;
        work_done = false;
        Console.WriteLine("The order was created by default");
    }
    public order(string n, string kind, int numb, int term, bool done)      //конструктор ініціалізації
    {
        name_orderer = n;
        kind_prod = kind;
        numb_prod = numb;
        dead_line = term;
        work_done = done;
        //store product = new store(st);

        Console.WriteLine("The order was created by initialisation");
    }
    public order(order arg)                //конструктор копіювання
    {
        name_orderer = arg.name_orderer;
        kind_prod = arg.kind_prod;
        numb_prod = arg.numb_prod;
        dead_line = arg.dead_line;
        work_done = arg.work_done;
        Console.WriteLine("The order was created by copy");
    }
    ~order()                //деструктор
    {
        Console.WriteLine("The order was destructed");
    }
    public void create_order()
   {
      throw new NotImplementedException();
   }
   
   public void del_order()
   {
      throw new NotImplementedException();
   }

}