﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class myQueue<T> : GenericList<T>
    {
        public myQueue() : base() { }

        public override T Pop()
        {
            T toR = values[values.Length - 1];
            T[] temp = new T[values.Length - 1];
            for(int i = 0; i < values.Length - 1; i++)
            {
                temp[i] = values[i];
            }
            values = temp;
            return toR;
        }

        public override string View()
        {
            return "Queue: " + base.View();
        }

        public virtual bool IsEmpty()
        {
            return values.Length == 0;
        }
    }
}
