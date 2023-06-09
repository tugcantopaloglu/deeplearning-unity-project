using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    public UDPReceive uDPReceive;
    public GameObject[] nodes;
    public Body body;
    
    void Update()
    {
        body = new Body(uDPReceive.data);
        for(int i = 0;i<nodes.Length;i++){
            nodes[i].transform.localPosition = body.nodes[i].asVector();
        }
    }
}
