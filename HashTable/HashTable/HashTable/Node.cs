﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node() { }
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}