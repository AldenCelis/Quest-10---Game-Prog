using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    public float speed = 10f;
    
    protected Rigidbody2D rb; 

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed;
    }
}