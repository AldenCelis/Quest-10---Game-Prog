using UnityEngine;

public class FirePlayer : Player
{

    [SerializeField] private GameObject FireBullet;

    public override void Attack()
    {
        base.Attack(); 
    
        GameObject newBullet = Instantiate(FireBullet, transform.position, Quaternion.identity);
    
        FireBullet bulletScript = newBullet.GetComponent<FireBullet>();

        if (bulletScript != null)
        {
            float facingDirection = transform.localScale.x;
            bulletScript.SetDirection(facingDirection);
        }

        
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WaterEnemy"))
        {
            Debug.Log("Fire is put out by water!");
            
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Hit by something else, fire player is safe.");
        }
    }

}