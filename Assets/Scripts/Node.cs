using UnityEngine;
public class Node
{
    public float x;
    public float y;
    public float z;

    public Node(float NodeX, float NodeY, float NodeZ)
    {
        x = NodeX;
        y = NodeY;
        z = NodeZ;
    }

    public void Set(float NodeX, float NodeY, float NodeZ)
    {
        x = NodeX;
        y = NodeY;
        z = NodeZ;
    }

    public Vector3 asVector(){
        return new Vector3(x,y,z);
    }

    public Vector2 asVector2(){
        return new Vector3(x,y);
    }

}
