// File:    enterprise.cs
// Author:  David
// Created: вторник, 13 ноября 2018 г. 07:23:32
// Purpose: Definition of Class enterprise

using System;
using System.Collections;
using System.Collections.Generic;
public class enterprise
{
   private string name { get; set; }
    private float productivity_pow { get; set; }
    private int num_depart { get; set; }
    private int number_product { get; set; }
    public List<department> departs = new List<department>();
    public List<product> products = new List<product>();
    public order ord = new order();
    public store st { get; set; }
    public enterprise()      //конструктор за замовчуванням
    {
        name = "devich";
        productivity_pow = 300;
        num_depart = 1;
        number_product = 1;
        department depart = new department();
 
        departs.Add(depart);
        product prod = new product();
        products.Add(prod);
       Console.WriteLine("The enterprise was created by default");
    }
    public enterprise(float pow, int num_dep,int number_prod,bool s)      //конструктор ініціалізації
    {
        name = "devich";
        productivity_pow = pow;
        num_depart = num_dep;
        number_product = number_prod;
        for(int i =0;i< num_dep;i++)
        {
            departs.Add(new department());
        }
       // Console.Write(departs.Count);
        //store product = new store(st);
        for (int i = 0; i < number_prod; i++)
        {
            products.Add(new product());
        }
        st = new store(s);

        Console.WriteLine("The enterprise was created by initialisation");
    }
    public enterprise(enterprise arg)                //конструктор копіювання
    {
        name = arg.name;
        productivity_pow = arg.productivity_pow;
        num_depart = arg.num_depart;
        number_product = arg.number_product;
        departs = (arg.departs);
        products = (arg.products);
        Console.WriteLine("The enterprise was created by copy");
    }
    ~enterprise()                //деструктор
    {
        Console.WriteLine("The enterprise was destructed");
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public float Productivity_pow
    {
        get { return productivity_pow; }
        set { productivity_pow = value; }
    }
    public int Num_depart
    {
        get { return num_depart; }
        set { num_depart = value; }
    }
    public int Number_product
    {
        get { return number_product; }
        set { number_product = value; }
    }
    public void take_order()
   {
      throw new NotImplementedException();
   }
   
   public void perform_order()
   {
      throw new NotImplementedException();
   }
   
   public void show_production()
   {
      throw new NotImplementedException();
   }
   
   public void buy_materials()
   {
      throw new NotImplementedException();
   }
   
   public void add_product_from_prototype()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.ArrayList department;
   
   /// <summary>
   /// Property for collection of department
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Department
   {
      get
      {
         if (department == null)
            department = new System.Collections.ArrayList();
         return department;
      }
      set
      {
         RemoveAllDepartment();
         if (value != null)
         {
            foreach (department odepartment in value)
               AddDepartment(odepartment);
         }
      }
   }
   
   /// <summary>
   /// Add a new department in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddDepartment(department newDepartment)
   {
      if (newDepartment == null)
         return;
      if (this.department == null)
         this.department = new System.Collections.ArrayList();
      if (!this.department.Contains(newDepartment))
         this.department.Add(newDepartment);
   }
   
   /// <summary>
   /// Remove an existing department from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveDepartment(department oldDepartment)
   {
      if (oldDepartment == null)
         return;
      if (this.department != null)
         if (this.department.Contains(oldDepartment))
            this.department.Remove(oldDepartment);
   }
   
   /// <summary>
   /// Remove all instances of department from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllDepartment()
   {
      if (department != null)
         department.Clear();
   }
   public store store;
   public System.Collections.ArrayList order;
   
   /// <summary>
   /// Property for collection of order
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Order
   {
      get
      {
         if (order == null)
            order = new System.Collections.ArrayList();
         return order;
      }
      set
      {
         RemoveAllOrder();
         if (value != null)
         {
            foreach (order oorder in value)
               AddOrder(oorder);
         }
      }
   }
   
   /// <summary>
   /// Add a new order in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddOrder(order newOrder)
   {
      if (newOrder == null)
         return;
      if (this.order == null)
         this.order = new System.Collections.ArrayList();
      if (!this.order.Contains(newOrder))
         this.order.Add(newOrder);
   }
   
   /// <summary>
   /// Remove an existing order from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveOrder(order oldOrder)
   {
      if (oldOrder == null)
         return;
      if (this.order != null)
         if (this.order.Contains(oldOrder))
            this.order.Remove(oldOrder);
   }
   
   /// <summary>
   /// Remove all instances of order from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllOrder()
   {
      if (order != null)
         order.Clear();
   }
   public System.Collections.ArrayList product;
   
   /// <summary>
   /// Property for collection of product
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Product
   {
      get
      {
         if (product == null)
            product = new System.Collections.ArrayList();
         return product;
      }
      set
      {
         RemoveAllProduct();
         if (value != null)
         {
            foreach (product oproduct in value)
               AddProduct(oproduct);
         }
      }
   }
   
   /// <summary>
   /// Add a new product in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddProduct(product newProduct)
   {
      if (newProduct == null)
         return;
      if (this.product == null)
         this.product = new System.Collections.ArrayList();
      if (!this.product.Contains(newProduct))
         this.product.Add(newProduct);
   }
   
   /// <summary>
   /// Remove an existing product from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveProduct(product oldProduct)
   {
      if (oldProduct == null)
         return;
      if (this.product != null)
         if (this.product.Contains(oldProduct))
            this.product.Remove(oldProduct);
   }
   
   /// <summary>
   /// Remove all instances of product from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllProduct()
   {
      if (product != null)
         product.Clear();
   }

}