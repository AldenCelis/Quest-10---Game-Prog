using UnityEngine;

public class GrassEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FireBullet"))
        {
            Debug.Log("Grass enemy burned by fire!");
            
            // Destroy the enemy
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Hit by something else, grass enemy is safe.");
        }
    }
}