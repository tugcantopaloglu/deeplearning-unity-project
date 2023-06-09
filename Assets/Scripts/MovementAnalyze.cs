using System;
using UnityEngine;

public class MovementAnalyzer
{

    public MovementAnalyzer(){}

    public int lineSelector(DanceFigure figure){
        if(figure.nodes[23].x < -2.5){
            return 0;
        }
        if(figure.nodes[23].x > 0.5){
            return 2;
        }
        return 1;
    }

    public bool isTwoFigureSimilar3(DanceFigure figure,DanceFigure figure2){

        //left hand
        //12-24 & 12-14
        //12-14 & 14-16
        
        if(!(isTwoAngleSimilar(12,24,12,14,figure,figure2) && isTwoAngleSimilar(12,14,14,16,figure,figure2))){
            //print("left hand");
            return false;    
        }
        
        //right hand
        //11-23 & 11-13
        //11-13 & 13-15

        if(!(isTwoAngleSimilar(11,23,11,13,figure,figure2) && isTwoAngleSimilar(11,13,13,15,figure,figure2))){
            //print("right hand");
            return false;    
        }
        
        //right leg
        //24-23 & 24-26
        //24-26 & 26-28
        if(!(isTwoAngleSimilar(24,23,24,26,figure,figure2) && isTwoAngleSimilar(24,26,26,28,figure,figure2))){
            //print("right leg");
            return false;   
        }

        //left leg
        //24-23 & 23-25
        //23-25 & 25-27
        if(!(isTwoAngleSimilar(24,23,23,25,figure,figure2) && isTwoAngleSimilar(23,25,25,27,figure,figure2))){
            //print("left leg");
            return false;   
        }
        return true;  
    }

    public bool isTwoFigureSimilar(DanceFigure figure,DanceFigure figure2){

        //left hand
        //12-24 & 12-14
        //12-14 & 14-16
        
        if(!(isTwoAngleSimilar(11,23,11,13,figure,figure2) && isTwoAngleSimilar(11,13,13,15,figure,figure2))){
            //print("left hand");
            return false;    
        }
        
        //right hand
        //11-23 & 11-13
        //11-13 & 13-15

        if(!(isTwoAngleSimilar(10,22,10,12,figure,figure2) && isTwoAngleSimilar(10,12,12,14,figure,figure2))){
            //print("right hand");
            return false;    
        }
        /*
        //right leg
        //24-23 & 24-26
        //24-26 & 26-28
        if(!(isTwoAngleSimilar(23,22,23,25,figure,figure2) && isTwoAngleSimilar(23,25,25,27,figure,figure2))){
            //print("right leg");
            return false;   
        }

        //left leg
        //24-23 & 23-25
        //23-25 & 25-27
        if(!(isTwoAngleSimilar(23,22,22,24,figure,figure2) && isTwoAngleSimilar(22,24,24,26,figure,figure2))){
            //print("left leg");
            return false;   
        }*/
        return true;  
    }

    bool isTwoAngleSimilar(int node1,int node2,int node3,int node4,DanceFigure figure,DanceFigure figure2){
 
        if(!isTwoXYAngleSimilar(node1,node2,node3,node4,figure,figure2)){
            return false;
        }
        return true;
    }

    bool isTwoXYAngleSimilar(int node1,int node2,int node3,int node4,DanceFigure figure,DanceFigure figure2){

        bool isSimilar = true;

        float angle1 = twoDAngleCalculator(node1,node2,node3,node4,figure);
        float angle2 = twoDAngleCalculator(node1,node2,node3,node4,figure2);

        if(!(angle1-25f < angle2 && angle2 < angle1+25f)){
            isSimilar = false;
        }
        
        return isSimilar;
    }

    float twoDAngleCalculator(int node1,int node2,int node3,int node4,DanceFigure figure){
        Vector2 line1 = figure.nodes[node1].asVector2() - figure.nodes[node2].asVector2();
        Vector2 line2 = figure.nodes[node3].asVector2() - figure.nodes[node4].asVector2();
        float angle = Vector2.Angle(Vector2.right,line2) - Vector2.Angle(Vector2.right,line1) ;
        return angle;
    }

     float twoDAngleCalculator2(int node1,int node2,int node3,int node4,DanceFigure figure){
        Vector2 line1 = figure.nodes[node1].asVector2() - figure.nodes[node2].asVector2();
        Vector2 line2 = figure.nodes[node3].asVector2() - figure.nodes[node4].asVector2();
        Vector2 line = line2 - line1;
        return Vector2.Angle(Vector2.right,line);
    }

}
