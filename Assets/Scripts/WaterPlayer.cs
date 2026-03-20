using UnityEngine;

public class WaterPlayer : Player
{

    [SerializeField] private GameObject WaterBullet;

    public override void Attack()
    {
        base.Attack(); 
    
        GameObject newBullet = Instantiate(WaterBullet, transform.position, Quaternion.identity);
    
        WaterBullet bulletScript = newBullet.GetComponent<WaterBullet>();

        if (bulletScript != null)
        {
            float facingDirection = transform.localScale.x;
            bulletScript.SetDirection(facingDirection);
        }

        
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("GrassEnemy"))
        {
            Debug.Log("Water is absorbed by grass!");
            
            // Destroy the enemy
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Hit by something else, water player is safe.");
        }
    }

}