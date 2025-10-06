using UnityEngine;

public class ObstacleBounce : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;
    private Vector3 direccion;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
        direccion = Vector3.left; 
        rb.linearVelocity = direccion * velocidad;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            
            direccion = -direccion;
            rb.linearVelocity = direccion * velocidad;
        }
    }
}
