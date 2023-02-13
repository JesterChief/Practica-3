using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum EnemyState
{
    Wander,
    Follow,
    Die,
};

public class EnemyPlatform : MonoBehaviour
{
    GameObject PlatformPlayer;
    public EnemyState currState = EnemyState.Wander;
    public Transform target;
    Rigidbody2D myRigidbody;
    public float range = 2f;
    public float moveSpeed = 2f;
    private Animator animator;
    public string boolwalk = "walking";
    public string boolruning = "runing";
   



    // Start is called before the first frame update
    void Start()
    {
        PlatformPlayer = FindObjectOfType<PlatformPlayer>().gameObject;
        myRigidbody = GetComponent<Rigidbody2D>();
        target = PlatformPlayer.GetComponent<Transform>();
        animator = GetComponent<Animator>();
      }

    // Update is called once per frame
    void Update()
    {
        


        switch (currState)
        {
            case (EnemyState.Wander):
                Wander();
                break;
            case (EnemyState.Follow):
                Follow();
                break;
            case (EnemyState.Die):
                // Die();
                break;
        }

        if (IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Follow;
        }
        else if (!IsPlayerInRange(range) && currState != EnemyState.Die)
        {
            currState = EnemyState.Wander;
       }
    }
 

    public bool IsPlayerInRange(float range)
    {
         return Vector3.Distance(transform.position, PlatformPlayer.transform.position) <= range; //Devuelve el resultado de si la posicion de range es verdfadera o falso.
        
    }
    void Wander()
    {
        myRigidbody.velocity = new Vector3(moveSpeed, 0f);
        animator.SetBool(boolwalk, true);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        moveSpeed *= -1;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {


        if (other.collider.GetComponent<PlatformPlayer>())
            {



            Destroy(other.gameObject);
            GameManager.instance.ChangeScene("GameOver");
        }
        

    }

   


    void Follow()
    {


        myRigidbody.velocity = new Vector3(moveSpeed * 2, 0f);
            animator.SetBool(boolruning, true);
    }
}



