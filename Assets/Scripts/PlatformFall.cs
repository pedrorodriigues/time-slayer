using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour
{

    public float fallDelay = 1f; // tempo para começar a cair a plataforma


    private Rigidbody2D rb2d; // corpo rígido da plataforma

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>(); // pegar o corpo rígido da plataforma
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) // se colidir com um player (layer)
        {
            Invoke("Fall", fallDelay); // invoca a função Fall com o fallDelay
        }
    }

    void Fall()
    {
        rb2d.isKinematic = false; // se for falso o objeto é afetado por colisões e forças (gravidade)
    }



}