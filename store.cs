// File:    store.cs
// Author:  David
// Created: суббота, 17 ноября 2018 г. 23:16:11
// Purpose: Definition of Class store

using System;

public class store
{
   private bool materials_available { get; set; }

    public bool Materials_available
    {
        get { return materials_available; }
        set { materials_available = value; }
    }

    public store()      //конструктор за замовчуванням
    {
        materials_available = false;
        Console.WriteLine("The store was created by default");
    }
    public store(bool s)      //конструктор ініціалізації
    {

        materials_available = s;
        //store store = new store(st);

        Console.WriteLine("The store was created by initialisation");
    }
    public store(store arg)                //конструктор копіювання
    {
        materials_available = arg.materials_available;
        Console.WriteLine("The store was created by copy");
    }
    ~store()                //деструктор
    {
        Console.WriteLine("The store was destructed");
    }
    public void prov_mater()
   {
      throw new NotImplementedException();
   }
   
   public void analyze_order()
   {
      throw new NotImplementedException();
   }

}