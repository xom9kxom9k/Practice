﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeOne.Second;

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }

    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}
