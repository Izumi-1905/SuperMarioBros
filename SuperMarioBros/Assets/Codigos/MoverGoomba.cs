using UnityEngine;

public class MoverGoomba : MonoBehaviour
{
    public float velocidad = 2f;
    private int direction = 1;

    public float izqlimit = -7f; 
    public float derlimit = 7f;
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * direction * velocidad * Time.deltaTime);
        if (transform.position.x >= derlimit)
        {
           direction = -1; 
           sr.flipX = true;
            
        }

        else if (transform.position.x <= izqlimit)
        {
            direction = 1;
            sr.flipX = false;

        }
    }
}
