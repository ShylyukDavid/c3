// File:    prototype.cs
// Author:  David
// Created: воскресенье, 18 ноября 2018 г. 19:19:45
// Purpose: Definition of Class prototype

using System;
using System.Collections;
public class prototype
{
   private string name_prod { get; set; }
    private ArrayList needed_detail = new ArrayList();
    private ArrayList kind_detail = new ArrayList();
    private bool approved { get; set; }

    public string Name_prod
    {
        get { return name_prod; }
        set { name_prod = value; }
    }
    public ArrayList Needed_detail
    {
        get { return needed_detail; }
        set { needed_detail = value; }
    }
    public ArrayList Kind_detail
    {
        get { return kind_detail; }
        set { kind_detail = value; }
    }
    public bool Approved
    {
        get { return approved; }
        set { approved = value; }
    }

    public prototype()      //конструктор за замовчуванням
    {
        name_prod = "";
        approved = false;
        Console.WriteLine("The prototype was created by default");
    }
    public prototype(string name, ArrayList list, ArrayList num,bool s)      //конструктор ініціалізації
    {
        name_prod = name;
        needed_detail = list;
        kind_detail = num;
        approved = s;

        //store prototype = new store(st);

        Console.WriteLine("The prototype was created by initialisation");
    }
    public prototype(prototype arg)                //конструктор копіювання
    {
        name_prod = arg.name_prod;
        needed_detail = arg.needed_detail;
        kind_detail = arg.kind_detail;
        approved = arg.approved;
        Console.WriteLine("The prototype was created by copy");
    }
    ~prototype()                //деструктор
    {
        Console.WriteLine("The prototype was destructed");
    }

    public void create_prototype()
   {
      throw new NotImplementedException();
   }
   
   public void approve_prototype()
   {
      throw new NotImplementedException();
   }

}