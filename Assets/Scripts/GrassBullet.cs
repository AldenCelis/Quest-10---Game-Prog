using UnityEngine;

public class GrassBullet : Bullet
{
    public float Bulletspeed = 5.0f; 

    private void Update()
    {
        transform.position += transform.right * Bulletspeed * Time.deltaTime; 
    }
}