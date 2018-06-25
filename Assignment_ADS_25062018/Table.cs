using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_ADS_25062018
{
    public class Table
    {
        public int TableID { get; set; }
        public int TableSize { get; set; }
        public bool Occupied { get; set; }

        public Dictionary<int,Table> Tables = new Dictionary<int,Table>();

        public void AddTable(int id, Table t)
        {
            Tables.Add(id,t);
        }

        public void ModifyTable(int id, Table tb)
        {
            Table tab = Tables.FirstOrDefault(t => t.Key == id).Value;
            tab = tb;
        }

        public void DeleteTable(int id)
        {
            Tables.Remove(id);
        }

        public void InitializeTables()
        {
            Table t1 = new Table
            {
                TableID = 1,
                TableSize = 2,
                Occupied = false
            };
            Table t2 = new Table
            {
                TableID = 2,
                TableSize = 2,
                Occupied = false
            };
            Table t3 = new Table
            {
                TableID = 3,
                TableSize = 2,
                Occupied = false
            };
            Table t4 = new Table
            {
                TableID = 4,
                TableSize = 2,
                Occupied = false
            };
            Table t5 = new Table
            {
                TableID = 5,
                TableSize = 4,
                Occupied = false
            };
            Table t6 = new Table
            {
                TableID = 6,
                TableSize = 4,
                Occupied = false
            };
            Table t7 = new Table
            {
                TableID = 8,
                TableSize = 4,
                Occupied = false
            };
            Table t8 = new Table
            {
                TableID = 8,
                TableSize = 4,
                Occupied = false
            };
            Table t9 = new Table
            {
                TableID = 9,
                TableSize = 6,
                Occupied = false
            };
            Table t10 = new Table
            {
                TableID = 10,
                TableSize = 6,
                Occupied = false
            };
            Table t11 = new Table
            {
                TableID = 11,
                TableSize = 8,
                Occupied = false
            };
            Table t12 = new Table
            {
                TableID = 12,
                TableSize = 8,
                Occupied = false
            };

            Tables.Add(1, t1);
            Tables.Add(2, t2);
            Tables.Add(3, t3);
            Tables.Add(4, t4);
            Tables.Add(5, t5);
            Tables.Add(6, t6);
            Tables.Add(7, t7);
            Tables.Add(8, t8);
            Tables.Add(9, t9);
            Tables.Add(10, t10);
            Tables.Add(11, t11);
            Tables.Add(12, t12);
        }
    }
}
