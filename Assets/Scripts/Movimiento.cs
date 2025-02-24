using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] public Vector3 pointA;
    [SerializeField] public Vector3 pointB;
    [SerializeField] public float speed = 2.0f;

    private Vector3 target;

    void Start()
    {
        target = pointB;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = target == pointA ? pointB : pointA;
        }
    }
}
