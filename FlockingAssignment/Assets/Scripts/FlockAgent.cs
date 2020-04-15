using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class FlockAgent : MonoBehaviour
{
   
    Collider2D agentscollider;
    public Collider2D AgentCollider { get { return agentscollider; } }
    // Start is called before the first frame update
    void Start()
    {
        agentscollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
     public void Move(Vector2 velocity)
     {
        transform.up = velocity;
        transform.position += (Vector3)velocity * Time.deltaTime;
     }
}
