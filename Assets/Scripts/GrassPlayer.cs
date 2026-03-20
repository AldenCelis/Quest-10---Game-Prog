using UnityEngine;

public class GrassPlayer : Player
{

    [SerializeField] private GameObject GrassBullet;

    public override void Attack()
    {
        base.Attack(); 
    
        GameObject newBullet = Instantiate(GrassBullet, transform.position, Quaternion.identity);
    
        GrassBullet bulletScript = newBullet.GetComponent<GrassBullet>();

    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FireEnemy"))
        {
            Debug.Log("Grass is burned by fire!");
            
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Hit by something else, grass player is safe.");
        }
    }

}