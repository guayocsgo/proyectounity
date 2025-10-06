using UnityEngine;

public class PlayerTranslate : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed = 5f;        
    public float turnSpeed = 720f;  

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");   

        Vector3 dir = new Vector3(h, 0f, v);
        if (dir.sqrMagnitude > 0.001f)
        {
            
            Vector3 move = dir.normalized * speed * Time.deltaTime;
            transform.Translate(move, Space.World);
        }
    }
}
