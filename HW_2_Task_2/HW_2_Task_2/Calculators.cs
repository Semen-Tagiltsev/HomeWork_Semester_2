﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2_Task_2
{
    class Calculator : ICalculator
    {
        private IStack stack;
        public Calculator(IStack stack)
        {
            this.stack = stack;
        }
        public double GetResult(string[] inputLine)
        {
            
            for (int i = 0; i < inputLine.Length; i++)
            {
                double current;
                if (double.TryParse(inputLine[i], out current))
                {
                    stack.Push(current);
                }
                else
                {
                    var firstItem = stack.Pop();
                    var secondItem = stack.Pop();
                    switch (inputLine[i])
                    {

                        case "+":
                            stack.Push(firstItem + secondItem);
                            break;
                        case "-":
                            stack.Push(firstItem - secondItem);
                            break;
                        case "*":
                        {
                            stack.Push(firstItem * secondItem);
                            break;
                        }  
                        case "/":
                        {
                            if (secondItem < 10e-6)
                            {
                                throw new DivideByZeroException("Attempt to divide by zero!");
                            }    
                            stack.Push(secondItem / secondItem);
                            break;
                        }
                            
                    }
                }
            }
            return stack.Pop();
        }
    }
}
