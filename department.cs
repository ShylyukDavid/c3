// File:    department.cs
// Author:  David
// Created: вторник, 13 ноября 2018 г. 07:58:30
// Purpose: Definition of Class department

using System;
using System.Collections.Generic;
public class department
{

    public int Number_workers
    {
        get { return number_workers; }
        set { number_workers = value; }
    }


    public int Number_tecnic
    {
        get { return number_tecnic; }
        set { number_tecnic = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Pos_in_prod
    {
        get { return pos_in_prod; }
        set { pos_in_prod = value; }
    }
    public int Number_lines
    {
        get { return number_lines; }
        set { number_lines = value; }
    }

    public int number_workers { get; set; }
    private int number_tecnic { get; set; }
    private string name { get; set; }
    private int pos_in_prod { get; set; }
    private int number_lines { get; set; }
    public List<conveyer_line> conveyer_lines = new List<conveyer_line>();
    public kanban kan { get; set; }
    public System.Collections.ArrayList tecniques { get; set; }

   

    public department()      //конструктор за замовчуванням
    {

        number_workers = 10;
        number_tecnic = 0;
        name = "";
        pos_in_prod = 1;
        number_lines = 0;
        for (int i=0;i < number_lines;i++)
        {
            conveyer_line line = new conveyer_line();
            conveyer_lines.Add(line);
        }
        tecniques = new System.Collections.ArrayList();
        for (int i = 0; i < number_lines; i++)
        {
           tecnique tec = new tecnique();
            tecniques.Add(tec);
        }
        kan = new kanban();

        Console.WriteLine("The department was created by default\n");
    }
    public department(int number,int num_tec, string nam,int pos,int num_lines)      //конструктор ініціалізації
    {

        number_workers = number;
        number_tecnic = num_tec;
        name = nam;
        pos_in_prod = pos;
        number_lines = num_lines;

        for (int i = 0; i < number_lines; i++)
        {
            conveyer_line line = new conveyer_line();
            conveyer_lines.Add(line);
        }
        tecniques = new System.Collections.ArrayList();
        for (int i = 0; i < number_lines; i++)
        {
            tecnique tec = new tecnique();
            tecniques.Add(tec);
        }
        kan = new kanban();

        //store product = new store(st);



        Console.WriteLine("The department was created by initialisation\n");
    }
    public department(department arg)                //конструктор копіювання
    {
        name = arg.name;
        number_workers = arg.number_workers;
        number_tecnic = arg.number_tecnic;
        pos_in_prod = arg.pos_in_prod;
        conveyer_lines = arg.conveyer_lines;
        tecniques = arg.tecniques;
        Console.WriteLine("The department was created by copy\n");
    }
    ~department()                //деструктор
    {
        Console.WriteLine("The department was destructed");
    }

    public void check_equipment()
    {
        for (int j =0;j<conveyer_lines.Count;j++)
        {
            if(conveyer_lines[j].Eqiupment_stat<=4)
            {
                Console.WriteLine("Department#{0} line#{1} - {2}", Pos_in_prod, j, conveyer_lines[j].Eqiupment_stat);
            }
        }


    }
    public void estimate_quality_prototype()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.ArrayList conveyer_line;
   
   /// <summary>
   /// Property for collection of conveyer_line
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Conveyer_line
   {
      get
      {
         if (conveyer_line == null)
            conveyer_line = new System.Collections.ArrayList();
         return conveyer_line;
      }
      set
      {
         RemoveAllConveyer_line();
         if (value != null)
         {
            foreach (conveyer_line oconveyer_line in value)
               AddConveyer_line(oconveyer_line);
         }
      }
   }
   
   /// <summary>
   /// Add a new conveyer_line in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddConveyer_line(conveyer_line newConveyer_line)
   {
      if (newConveyer_line == null)
         return;
      if (this.conveyer_line == null)
         this.conveyer_line = new System.Collections.ArrayList();
      if (!this.conveyer_line.Contains(newConveyer_line))
         this.conveyer_line.Add(newConveyer_line);
   }
   
   /// <summary>
   /// Remove an existing conveyer_line from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveConveyer_line(conveyer_line oldConveyer_line)
   {
      if (oldConveyer_line == null)
         return;
      if (this.conveyer_line != null)
         if (this.conveyer_line.Contains(oldConveyer_line))
            this.conveyer_line.Remove(oldConveyer_line);
   }
   
   /// <summary>
   /// Remove all instances of conveyer_line from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllConveyer_line()
   {
      if (conveyer_line != null)
         conveyer_line.Clear();
   }
   public System.Collections.ArrayList tecnique;
   
   /// <summary>
   /// Property for collection of tecnique
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Tecnique
   {
      get
      {
         if (tecnique == null)
            tecnique = new System.Collections.ArrayList();
         return tecnique;
      }
      set
      {
         RemoveAllTecnique();
         if (value != null)
         {
            foreach (tecnique otecnique in value)
               AddTecnique(otecnique);
         }
      }
   }
   
   /// <summary>
   /// Add a new tecnique in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddTecnique(tecnique newTecnique)
   {
      if (newTecnique == null)
         return;
      if (this.tecnique == null)
         this.tecnique = new System.Collections.ArrayList();
      if (!this.tecnique.Contains(newTecnique))
         this.tecnique.Add(newTecnique);
   }
   
   /// <summary>
   /// Remove an existing tecnique from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveTecnique(tecnique oldTecnique)
   {
      if (oldTecnique == null)
         return;
      if (this.tecnique != null)
         if (this.tecnique.Contains(oldTecnique))
            this.tecnique.Remove(oldTecnique);
   }
   
   /// <summary>
   /// Remove all instances of tecnique from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllTecnique()
   {
      if (tecnique != null)
         tecnique.Clear();
   }
   public System.Collections.ArrayList prototype;
   
   /// <summary>
   /// Property for collection of prototype
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Prototype
   {
      get
      {
         if (prototype == null)
            prototype = new System.Collections.ArrayList();
         return prototype;
      }
      set
      {
         RemoveAllPrototype();
         if (value != null)
         {
            foreach (prototype oprototype in value)
               AddPrototype(oprototype);
         }
      }
   }
   
   /// <summary>
   /// Add a new prototype in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddPrototype(prototype newPrototype)
   {
      if (newPrototype == null)
         return;
      if (this.prototype == null)
         this.prototype = new System.Collections.ArrayList();
      if (!this.prototype.Contains(newPrototype))
         this.prototype.Add(newPrototype);
   }
   
   /// <summary>
   /// Remove an existing prototype from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemovePrototype(prototype oldPrototype)
   {
      if (oldPrototype == null)
         return;
      if (this.prototype != null)
         if (this.prototype.Contains(oldPrototype))
            this.prototype.Remove(oldPrototype);
   }
   
   /// <summary>
   /// Remove all instances of prototype from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllPrototype()
   {
      if (prototype != null)
         prototype.Clear();
   }
   public kanban kanban;

}