using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFigure : MonoBehaviour
{
    public GameObject manager;
    public float second;
    void Start()
    {
        manager = GameObject.Find("GameManager");
        Destroy(gameObject,second);
    }

    public void DestroyObject(){
        manager.GetComponent<Game>().IncreasePoint();
        Destroy(gameObject,0);
    }

    void OnDestroy()
    {
        manager.GetComponent<Game>().IncreaseDestroyedObject();
    }
}
