using UnityEngine;

public class FireEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WaterBullet"))
        {
            Debug.Log("Fire enemy put out by water!");
            
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Hit by something else, fire enemy is safe.");
        }
    }
}