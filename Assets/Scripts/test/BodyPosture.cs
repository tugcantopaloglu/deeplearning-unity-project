using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPosture : MonoBehaviour
{
    public DanceStore store;
    DanceFigure danceFigure;
    public int figureIndex;
    public GameObject[] nodes = new GameObject[33];
    void Start()
    {
    }

    void Update(){
        danceFigure = DanceFigure.FromJson(store.dance[figureIndex]);

        for(int i = 0;i<33;i++){
            nodes[i].transform.localPosition = danceFigure.nodes[i].asVector();
        }
    }
}
