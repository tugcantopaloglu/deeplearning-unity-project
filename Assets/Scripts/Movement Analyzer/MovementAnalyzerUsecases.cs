using System.Collections.Generic;
using System;


//ana movement analyzer yap
public class MovementAnalyzerUsecases
{
    public bool IsTwoMovemenetSimilar(List<double> pose1,List<double> pose2,double tolerancePercentage){
        return GetSimilarityPercentageMovement(pose1,pose2) > 100-tolerancePercentage;
    }
    public double GetSimilarityPercentageMovement(List<double> pose1,List<double> pose2)
    {
        if(pose1.Count != pose2.Count){
            throw new Exception("They aren't same pose type");
        }

        double similarity = 0;
        for(int i = 0;i<pose1.Count;i++){
            similarity += GetSimilarityPercentageOfTwoNode(pose1[i],pose2[i]);
        }
        return similarity/100;
    }
    public double GetSimilarityPercentageOfTwoNode(double node1,double node2)
    {
        return Math.Abs(node1-node1)/Math.Max(node1,node2);
    }
}
