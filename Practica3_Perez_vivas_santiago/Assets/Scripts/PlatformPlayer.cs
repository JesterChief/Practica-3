using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformPlayer : MonoBehaviour
{
    public LayerMask mascaraSuelo;
    public float rayDistance = 1.5f;
    private Rigidbody2D rb;
    public float jump;
    public float speed = 1.0f;
    private Animator animator;
    public string Boolwalk = "walking";
    public string Boolruning = "runing";
    public string Booljump = "jump";
    public string Boolbrake = "brake";

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        float auxiliarspeed = speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            auxiliarspeed *= 2;
            animator.SetBool(Boolruning, true);
            animator.SetBool(Boolbrake, false);
        }
        else
        {
            animator.SetBool(Boolruning, false);
            animator.SetBool(Boolbrake, true);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-auxiliarspeed, rb.velocity.y, 0);
            animator.SetBool(Boolwalk, true);
            transform.localScale = new Vector3(-3f, 2.3f, -1f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(auxiliarspeed, rb.velocity.y, 0);
            animator.SetBool(Boolwalk, true);
            transform.localScale = new Vector3(3f, 2.3f, 1f);

        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            animator.SetBool(Boolwalk, false);
            
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            animator.Play("Dash");
            //animator.SetBool(Bolljump, true);
        }
        else {

            //animator.SetBool(Bolljump, false);
        }
    }
        

        bool IsGrounded()
        {
            RaycastHit2D resultado = Physics2D.Raycast(transform.position,
                Vector2.down, rayDistance, mascaraSuelo.value);

            if (resultado)
            {
                Debug.Log(resultado.collider.gameObject.name);
                if (resultado.collider.gameObject.CompareTag("Ground"))
                {
                    return true;
                }
            }

            return false;
        }

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
        }
    }

    
