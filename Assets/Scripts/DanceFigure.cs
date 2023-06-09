using UnityEngine;

public class DanceFigure
{
    public Node[] nodes = new Node[33];


    public DanceFigure(Node[] danceFigureNodes){
        nodes = danceFigureNodes;
    }

    public string ToJson(){
        string json = "";
        for(int i = 0;i <nodes.Length ;i++){
            Node element = nodes[i];
            string data = $"{element.x},{element.y},{element.z},";
            json += data;
        }
        return json;
    }

    public static DanceFigure FromJson(string data){
        string[] nodeStrings = data.Substring(0,data.Length-1).Split(',');
        Node[] nodesArray = new Node[33];
        for (int i = 0; i < nodeStrings.Length; i +=3)
        {
            Node node = new Node(float.Parse(nodeStrings[i]),float.Parse(nodeStrings[i+1]),float.Parse(nodeStrings[i+2]));
            nodesArray[i/3] = node;
        }
        return new DanceFigure(nodesArray);
    }
}
