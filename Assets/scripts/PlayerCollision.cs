using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("El jugador choc� con un obst�culo");

            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
