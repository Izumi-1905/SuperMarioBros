using UnityEngine;

public class CambioAnimacion : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private Animator animator;

    private SpriteRenderer sr;

    private EstadoPersonaje estado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("velocidad", Mathf.Abs(rb.linearVelocityX));
        sr.flipX = rb.linearVelocityX < 0;
        //Cambia la animación de salto
        animator.SetBool("enPiso", estado.estaEnPiso);
    }
}
