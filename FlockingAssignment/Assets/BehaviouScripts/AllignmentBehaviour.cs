using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Flock/Behaviour/Allignment")]
public class AllignmentBehaviour : FlockBehaviour
{
    public override Vector2 MovementCalculator(FlockAgent agent, List<Transform> context, Flock flock)
    {
        if (context.Count == 0)
            return agent.transform.up;

        Vector2 allignmentMove = Vector2.zero;
        foreach (Transform item in context)
        {
           allignmentMove += (Vector2)item.transform.up;
        }
        allignmentMove /= context.Count;

       
        return allignmentMove;

    }
}
