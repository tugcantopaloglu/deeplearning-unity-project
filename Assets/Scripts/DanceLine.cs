using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceLine : MonoBehaviour
{
    public GameObject[] lines;
    public GameObject manager;
    int selectedLine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectedLine = manager.GetComponent<Game>().currentLine;
        if(selectedLine == 0){
            lines[0].SetActive(true);
            lines[1].SetActive(false);
            lines[2].SetActive(false);
        }else if(selectedLine == 1){
            lines[0].SetActive(false);
            lines[1].SetActive(true);
            lines[2].SetActive(false);
        }else if(selectedLine == 2){
            lines[0].SetActive(false);
            lines[1].SetActive(false);
            lines[2].SetActive(true);
        }
    }
}
