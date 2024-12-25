using UnityEngine;

public class InteractionWithItems : MonoBehaviour
{
    private Ray2D ray;

    void Start()
    {
        ray = new Ray2D(transform.parent.position, transform.forward);
    }

    void Update() {}
}