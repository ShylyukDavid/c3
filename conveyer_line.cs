// File:    conveyer_line.cs
// Author:  David
// Created: вторник, 13 ноября 2018 г. 07:23:33
// Purpose: Definition of Class conveyer_line

using System;
using System.Collections.Generic;
public class conveyer_line
{
   private int pos_in_production { get; set; }
   private int workers { get; set; }
   private string color_danger { get; set; }
    private int eqiupment_stat { get; set; }
   // private bool current_work_performed { get; set; }
    private bool work_taken { get; set; }
    private int time_per_item { get; set; }
    public List<hand_worker> hand_workers = new List<hand_worker>();


    public int Pos
    {
        get { return pos_in_production; }
        set { pos_in_production = value; }
    }

    public int Workers
    {
        get { return workers; }
        set { workers = value; }
    }

    public string Color_danger
    {
        get { return color_danger; }
        set { color_danger = value; }
    }

    public int Eqiupment_stat
    {
        get { return eqiupment_stat; }
        set { eqiupment_stat = value; }
    }


    public bool Work_taken
    {
        get { return work_taken; }
        set { work_taken = value; }
    }

    public int Time_per_item
    {
        get { return time_per_item; }
        set { time_per_item = value; }
    }


    public conveyer_line()      //конструктор за замовчуванням
    {
        pos_in_production = 1;
        workers = 0;
        color_danger = "green";
        eqiupment_stat = 5;
        //current_work_performed
        work_taken = false;
        time_per_item = 20;
       
        for (int i = 0; i < workers; i++)
        {
            hand_worker work = new hand_worker();
            hand_workers.Add(work);
        }
        Console.WriteLine("The conveyer_line was created by default\n");
    }
    public conveyer_line(int work, int pos, int eqiupment_status, int time, bool work_tak,string color_dang)      //конструктор ініціалізації
    {
        workers = 0;

        pos_in_production = pos;
        eqiupment_stat = eqiupment_status;

        time_per_item = time;

        work_taken = work_tak;

        color_danger = color_dang;
        //current_work_performed(current_work_performed),
        
        for (int i = 0; i < workers; i++)
        {
            hand_worker works = new hand_worker();
            hand_workers.Add(works);
        }
        Console.WriteLine("The conveyer_line was created by initialisation\n");
    }
    public conveyer_line(conveyer_line arg)                //конструктор копіювання
    {
        workers = arg.workers;
        pos_in_production = arg.pos_in_production;
        eqiupment_stat = arg.eqiupment_stat;
        time_per_item = arg.time_per_item;
        work_taken = arg.work_taken;
        color_danger = arg.color_danger;
        hand_workers = arg.hand_workers;
        Console.WriteLine("The conveyer_line was created by copy\n");
    }
    ~conveyer_line()                //деструктор
    {
        Console.WriteLine("The conveyer_line was destructed");
    }

    public static conveyer_line operator --(conveyer_line c1)
    {
        return new conveyer_line { eqiupment_stat =0 };
    }
    public void make_item_product()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.ArrayList hand_worker;
   
   /// <summary>
   /// Property for collection of hand_worker
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Hand_worker
   {
      get
      {
         if (hand_worker == null)
            hand_worker = new System.Collections.ArrayList();
         return hand_worker;
      }
      set
      {
         RemoveAllHand_worker();
         if (value != null)
         {
            foreach (hand_worker ohand_worker in value)
               AddHand_worker(ohand_worker);
         }
      }
   }
   
   /// <summary>
   /// Add a new hand_worker in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddHand_worker(hand_worker newHand_worker)
   {
      if (newHand_worker == null)
         return;
      if (this.hand_worker == null)
         this.hand_worker = new System.Collections.ArrayList();
      if (!this.hand_worker.Contains(newHand_worker))
         this.hand_worker.Add(newHand_worker);
   }
   
   /// <summary>
   /// Remove an existing hand_worker from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveHand_worker(hand_worker oldHand_worker)
   {
      if (oldHand_worker == null)
         return;
      if (this.hand_worker != null)
         if (this.hand_worker.Contains(oldHand_worker))
            this.hand_worker.Remove(oldHand_worker);
   }
   
   /// <summary>
   /// Remove all instances of hand_worker from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllHand_worker()
   {
      if (hand_worker != null)
         hand_worker.Clear();
   }

}