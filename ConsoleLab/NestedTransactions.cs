using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class NestedTransactions
    {
        public Stack transactions = new Stack();
        public Stack stack = new Stack();
        public void Push(int val)
        {
            if (transactions.Count == 0)
            {
                stack.Push(val);
            }
            else
            {
                dynamic trans = transactions.Peek();
                trans.Push(val);
            }
        }
        public void Pop()
        {
            if (transactions.Count == 0)
            {
                stack.Pop();
            }
            else
            {
                transactions.Pop();
            }
        }
        public int Top()
        {
            if (transactions.Count == 0)
            {
                return (int)stack.Peek();
            }
            else
            {
                if (stack.Count == 0)
                {
                    return 0;
                }
                else
                {
                    dynamic trans = transactions.Peek();
                    if (trans.Count != 0)
                    {
                        return trans.Peek();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public void Begin()
        {
            transactions.Push(new Stack());
        }

        public bool Rollback()
        {
            if (transactions.Count == 0)
            {
                return false;
            }
            else
            {
                transactions.Pop();
                return true;
            }
        }

        public bool Commit()
        {
            if (transactions.Count == 0)
            {
                return false;
            }
            else
            {
                Stack temp = new Stack();
                foreach (Stack item in transactions)
                {
                    if (item.Count != 0)
                    {
                        for (int i = item.Count; i > 0; i--)
                        {
                            temp.Push(item.Pop());
                        }
                    }
                }
                for (int i = temp.Count; i > 0; i--)
                {
                    stack.Push(temp.Pop());
                }
                transactions.Clear();
                return true;
            }
        }
    }
}
/* ## For main # 
Solution sol = new Solution();
sol.Push(1);
Console.WriteLine($"Top is {sol.Top()}");
sol.Push(2);
Console.WriteLine($"Top is {sol.Top()}");
sol.Begin();
sol.Push(3);
sol.Push(4);
sol.Begin();
sol.Push(5);
Console.WriteLine($"Top is {sol.Top()}");
sol.Rollback();
Console.WriteLine($"Top is {sol.Top()}");
sol.Commit();
sol.Push(6);
Console.WriteLine($"Top is {sol.Top()}");
sol.Begin();
sol.Push(7);
sol.Push(8);
sol.Begin();
sol.Push(9);
sol.Push(10);
sol.Commit();
Console.WriteLine($"Top is {sol.Top()}");
sol.Commit();
*/
