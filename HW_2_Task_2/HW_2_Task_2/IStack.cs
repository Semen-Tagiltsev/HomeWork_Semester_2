﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2_Task_2
{
    interface IStack
    {
        bool IsEmpty();

        double Pop();

        void Push(double element);
    }
}
