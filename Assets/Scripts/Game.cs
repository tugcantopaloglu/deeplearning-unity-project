using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{    
    //init
    public DanceStore store;
    public DanceFigure[] danceFigures = new DanceFigure[5];
    public GameObject bodyObject;
    PlayerBody playerBody;
    MovementAnalyzer movementAnalyzer = new MovementAnalyzer();

    //figure
    public int currentFigure = 0;
    public int currentLine = 0;
    public char nextFigure;
    DanceFigure danceFigure;

    //figures colone
    int point = 0;
    int destroyedObject = 0;
    public GameObject[] figureObjects;
    public Transform[] lines;
    int cloneCounter = 0;
    public GameObject[] clones = new GameObject[10000];
    public string[] clonesInfo = new string[10000];


    void Start()
    {
        playerBody = bodyObject.GetComponent<PlayerBody>();
        for(int i = 0; i< store.dance.Length;i++){
            danceFigures[i] = DanceFigure.FromJson(store.dance[i]);
        }
        InvokeRepeating("createNewFigureObject", 0f, 3f);
    }

    void Update(){
        
        danceFigure = new DanceFigure(playerBody.body.nodes);
        
        
        setCurrentFigure();
        setCurrentLine();
        makeMove();
        nextFigure = clonesInfo[destroyedObject][0];
        

        /*
        if(Input.GetMouseButtonDown(1)){
           store.dance[5] = danceFigure.ToJson();
           print("saved :D");
        }*/ 
    }

    public void IncreasePoint(){
        point += 1;
    }

    public void IncreaseDestroyedObject(){
        destroyedObject += 1;
    }

    void makeMove(){
        //print($"{clonesInfo[destroyedObject]} == {currentFigure}{currentLine}");
        if(clonesInfo[destroyedObject] == $"{currentFigure}{currentLine}"){
            print("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            clones[destroyedObject].gameObject.GetComponent<DestroyFigure>().DestroyObject();
        }
    }
    
    void createNewFigureObject(){
        int figure = Random.Range(0, 5);
        int transform = Random.Range(0,3);
        clonesInfo[cloneCounter] = $"{figure}{transform}";
        clones[cloneCounter] = Instantiate(figureObjects[figure], lines[transform].position, lines[transform].rotation);
        cloneCounter +=1;
    }
    
    void setCurrentLine(){
        currentLine = movementAnalyzer.lineSelector(danceFigure);
    }

    void setCurrentFigure(){
        if(movementAnalyzer.isTwoFigureSimilar(danceFigures[0],danceFigure)){
            //print("0");
            currentFigure = 0;
        }
        if(movementAnalyzer.isTwoFigureSimilar(danceFigures[1],danceFigure)){
            //print("1");
            currentFigure = 1;
        }
        if(movementAnalyzer.isTwoFigureSimilar(danceFigures[2],danceFigure)){
            //print("2");
            currentFigure = 2;
        }
        if(movementAnalyzer.isTwoFigureSimilar(danceFigures[3],danceFigure)){
            //print("3");
            currentFigure = 3;
        }
        if(movementAnalyzer.isTwoFigureSimilar(danceFigures[4],danceFigure)){
            //print("4");
            currentFigure = 4;
        }
    }
}
