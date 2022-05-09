using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Brackets<T>
    {
        public bool MultiBracketValidation(string input)
        {
            Stack<char> openBrackets = new Stack<char>();
            if (input == "" || input == null)
            {
                return false;
            }

            foreach (char character in input)
            {
                if (character == '{' || character == '(' || character == '[')
                {
                    openBrackets.Push(character);
                }
                else if (character == '}')
                {
                    char temp = openBrackets.Peek();
                    if (temp == '{')
                    {
                        openBrackets.Pop();
                    }
                    else
                        return false;
                }
                else if (character == ')')
                {
                    char temp = openBrackets.Peek();
                    if (temp == '(')
                    {
                        openBrackets.Pop();
                    }
                    else
                        return false;
                }
                else if (character == ']')
                {
                    char temp = openBrackets.Peek();
                    if (temp == '[')
                    {
                        openBrackets.Pop();
                    }
                    else
                        return false;
                }
            }
            if (openBrackets.IsEmpty() == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
