using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFigure : MonoBehaviour
{
    public GameObject[] figures;
    public GameObject manager;
    public char figure ='0';

    // Update is called once per frame
    void Update()
    {
        figure = manager.GetComponent<Game>().nextFigure;
        if(figure == '0'){
            figures[0].SetActive(true);
            figures[1].SetActive(false);
            figures[2].SetActive(false);
            figures[3].SetActive(false);
            figures[4].SetActive(false);
        }else if(figure == '1'){
            figures[0].SetActive(false);
            figures[1].SetActive(true);
            figures[2].SetActive(false);
            figures[3].SetActive(false);
            figures[4].SetActive(false);
        }else if(figure == '2'){
            figures[0].SetActive(false);
            figures[1].SetActive(false);
            figures[2].SetActive(true);
            figures[3].SetActive(false);
            figures[4].SetActive(false);
        }
        else if(figure == '3'){
            figures[0].SetActive(false);
            figures[1].SetActive(false);
            figures[2].SetActive(false);
            figures[3].SetActive(true);
            figures[4].SetActive(false);
        }
        else if(figure == '4'){
            figures[0].SetActive(false);
            figures[1].SetActive(false);
            figures[2].SetActive(false);
            figures[3].SetActive(false);
            figures[4].SetActive(true);
        }
    }
}
