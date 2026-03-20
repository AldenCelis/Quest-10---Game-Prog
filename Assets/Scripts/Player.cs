using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Player : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;


    private bool facingRight = false; 

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Update()
    {
        HandleInput();
        if (moveInput.x > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveInput.x < 0 && facingRight)
        {
            Flip();
        }
    }

    private void HandleInput()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        float x = 0;
        float y = 0;

        if (keyboard.wKey.isPressed) y = 1;
        if (keyboard.sKey.isPressed) y = -1;
        if (keyboard.aKey.isPressed) x = -1;
        if (keyboard.dKey.isPressed) x = 1;

     
        moveInput = new Vector2(x, y).normalized;
        
        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Attack();
        }
    }

    protected virtual void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        // Switch the boolean state
        facingRight = !facingRight;
    
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }

    public virtual void OnTriggerEnter2D(Collider2D other) { }

    public virtual void Attack() { }
}