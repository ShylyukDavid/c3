// File:    product.cs
// Author:  David
// Created: суббота, 17 ноября 2018 г. 22:02:43
// Purpose: Definition of Class product

using System;
using System.Collections;
public class product
{
   private string name_product { get; set; }
    private System.Collections.ArrayList list_details = new System.Collections.ArrayList();
    private System.Collections.ArrayList number_details = new System.Collections.ArrayList();
    private System.Collections.ArrayList list_departments = new System.Collections.ArrayList();
    private int quality { get; set; }


    public string Name_product
    {
        get { return name_product; }
        set { name_product = value; }
    }

    public ArrayList List_details
    {
        get { return list_details; }
        set { list_details = value; }
    }
    public ArrayList Number_details
    {
        get { return number_details; }
        set { number_details = value; }
    }
    public ArrayList List_departments
    {
        get { return list_departments; }
        set { list_departments = value; }
    }
    public int Quality
    {
        get { return quality; }
        set { quality = value; }
    }
    public static product operator ++(product obj)
    {
        return new product { quality = obj.quality + 1 };
    }
    public product()      //конструктор за замовчуванням
    {
        name_product = "car";
        list_details.Add("");
        number_details.Add(0);
        list_departments.Add(1);
        quality = 5;
        Console.WriteLine("The product was created by default");
    }
    public product(string name_product,ArrayList list_details, ArrayList number_details,ArrayList list_departments,int quality)      //конструктор ініціалізації
    {
        this.name_product = name_product;
        this.list_details = list_details;
        this.number_details = number_details;
        this.list_departments = list_departments;
        this.quality = quality;

        //store product = new store(st);

        Console.WriteLine("The product was created by initialisation");
    }
    public product(product arg)                //конструктор копіювання
    {
        name_product = arg.name_product;
        list_details = arg.list_details;
        number_details = arg.number_details;
        list_departments = arg.list_departments;
        quality = arg.quality;
        Console.WriteLine("The product was created by copy");
    }
    ~product()                //деструктор
    {
        Console.WriteLine("The product was destructed");
    }
    public void show_detail_list()
   {
      throw new NotImplementedException();
   }

}