using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class NestedBrackets
    {
        public int solution(string S)
        {
            var stack = new Stack();
            for (var i = 0; i < S.Length; i++)
            {
                if (stack.Count == 0)
                    stack.Push(S[i]);
                else
                {
                    if (IsPair((char)stack.Peek(), S[i]))
                        stack.Pop();
                    else
                        stack.Push(S[i]);
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }
        bool IsPair(char c1, char c2)
        {

            return c1 == '{' ?
                c2 == '}' : c1 == '(' ?
                c2 == ')' : c1 == '[' ?
                c2 == ']' : false;

        }
    }
}
