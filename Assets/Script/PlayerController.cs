using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed;

    private  Rigidbody2D rigidbody2D;

    private Animator palyerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        palyerAnimator = GetComponent<Animator>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
            Run();
            Flip();
    }

    void Flip()
    {
        bool playerHasXAxisSpeed = Mathf.Abs(rigidbody2D.velocity.x) > Mathf.Epsilon;
        if (playerHasXAxisSpeed)
        {
            if (rigidbody2D.velocity.x > 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            if (rigidbody2D.velocity.x < 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
    void Run()
    {
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * runSpeed, rigidbody2D.velocity.y);
        rigidbody2D.velocity = playerVel;
        bool playerHasXAxisSpeed = Mathf.Abs(rigidbody2D.velocity.x) > Mathf.Epsilon;
        palyerAnimator.SetBool("Walk",playerHasXAxisSpeed);
    }


    public void TiShi()
    {
        palyerAnimator.SetBool("T",true);
        Invoke("False",0.5f);
    }

    void False()
    {
        palyerAnimator.SetBool("T",false);
    }
}
