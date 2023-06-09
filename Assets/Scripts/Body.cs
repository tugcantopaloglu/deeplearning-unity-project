using System;
using System.Collections.Generic;
using UnityEngine;


public class Body
{
    public Node[] nodes = new Node[33];

    public Body(string data)
    {
        string[] nodeStrings = data.Substring(1, data.Length-2).Split(',');
  
        for (int i = 0; i < nodeStrings.Length; i +=3)
        {
            Node node = new Node(5-float.Parse(nodeStrings[i])/100,float.Parse(nodeStrings[i+1])/100,float.Parse(nodeStrings[i+2])/200);
            nodes[i/3] = node;
        }
    }
}
