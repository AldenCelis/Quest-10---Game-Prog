using UnityEngine;

public class WaterBullet : Bullet
{
    public float Bulletspeed = 5.0f; 
    private Vector3 moveDirection;

    
    public void SetDirection(float direction)
    {
       
        moveDirection = new Vector3(direction, 0, 0);
    }

    private void Update()
    {
        
        transform.position += -moveDirection * Bulletspeed * Time.deltaTime; 
    }
}