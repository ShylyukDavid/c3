// File:    kanban.cs
// Author:  David
// Created: суббота, 17 ноября 2018 г. 23:08:27
// Purpose: Definition of Class kanban

using System;
using System.Collections;
using System.Collections.Generic;
public class kanban
{
    private System.Collections.ArrayList number_prod { get; set; }
    private System.Collections.ArrayList kind_prod { get; set; }
    private int send_depart { get; set; }
    private int adress_depart { get; set; }
    private int time_spent_production { get; set; }


    public ArrayList Number_prod
    {
        get { return number_prod; }
        set { number_prod = value; }
    }

    public ArrayList Kind_prod
    {
        get { return kind_prod; }
        set { kind_prod = value; }
    }

    public int Send_depart
    {
        get { return send_depart; }
        set { send_depart = value; }
    }
    public int Adress_depart
    {
        get { return adress_depart; }
        set { adress_depart = value; }
    }
    public int Time_spent_production
    {
        get { return time_spent_production; }
        set { time_spent_production = value; }
    }


    public kanban()      //конструктор за замовчуванням
    {
        number_prod = new System.Collections.ArrayList();
        kind_prod = new System.Collections.ArrayList();
        send_depart = 0;
        adress_depart = 1;
        time_spent_production = 0;
        Console.WriteLine("The kanban was created by default");
    }
    public kanban(System.Collections.ArrayList num_prod, System.Collections.ArrayList kind,int send,int adress,int time)      //конструктор ініціалізації
    {
        number_prod = new System.Collections.ArrayList();
        kind_prod = new System.Collections.ArrayList();
        // number_prod.AddRange(num_prod);
        // kind_prod.AddRange(kind);
        number_prod = num_prod;
        kind_prod = kind;
         send_depart = send;
        adress_depart = adress;
        time_spent_production = time;

        //store product = new store(st);


 
        Console.WriteLine("The kanban was created by initialisation");
    }
    public kanban(kanban arg)                //конструктор копіювання
    {
        number_prod = new System.Collections.ArrayList();
        kind_prod = new System.Collections.ArrayList();
        // number_prod.AddRange(num_prod);
        // kind_prod.AddRange(kind);
        number_prod = arg.number_prod;
        kind_prod = arg.kind_prod;
        send_depart = arg.send_depart;
        adress_depart = arg.adress_depart;
        time_spent_production = arg.time_spent_production;
        Console.WriteLine("The kanban was created by copy");
    }
    ~kanban()                //деструктор
    {
        Console.WriteLine("The kanban was destructed");
    }

    public void create_kanban()
   {
      throw new NotImplementedException();
   }

}