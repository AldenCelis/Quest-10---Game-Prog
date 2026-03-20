using UnityEngine;

public class WaterEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("GrassBullet"))
        {
            Debug.Log("Water enemy is absorbed by grass!");
            
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Hit by something else, water enemy is safe.");
        }
    }
}