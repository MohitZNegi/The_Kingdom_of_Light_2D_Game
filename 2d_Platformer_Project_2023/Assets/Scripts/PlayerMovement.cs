using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    private Rigidbody2D player;
    private Animator anim;
    private BoxCollider2D boxCollider;

     [SerializeField] private LayerMask landLayer;

      [Header("Sounds")]
    [SerializeField] private AudioClip jumpSound;
 
 
    // Start is called before the first frame update
    void Start()
    {
        //Grab references for rigidbody and animator from object
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        
	
    }

    // Update is called once per frame
    void Update()
    {
         float horizontalInput = Input.GetAxis("Horizontal");

        player.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, player.velocity.y);
          //Flip player when moving left-right
        if (horizontalInput > 0.01f)
        {
           transform.localScale = new Vector3(1.2f,1.2f,1); 
           
    

              
        }
           
            
        else if (horizontalInput < -0.01f){
           transform.localScale = new Vector3(-1.2f, 1.2f, 1);
             

        }

      
              
           
            
            if(Input.GetKeyUp(KeyCode.DownArrow)){
              anim.SetBool("Run", false);
              
            }
          //Set animator parameters
        anim.SetBool("Run", horizontalInput != 0);
        anim.SetBool("Landed", isLanded());
        if(Input.GetKey(KeyCode.Space) && isLanded())
        {
          
          Jump();
              if (Input.GetKeyDown(KeyCode.Space))
              {
               SoundEff_Manager.instance.PlaySound(jumpSound);
              
              }
        if (!isLanded()){
          Jump();
        }

        
        }
     

        if(Input.GetKeyDown(KeyCode.DownArrow)){
        
          anim.SetBool("Sit", true);
           anim.SetBool("Sneak", false);
            anim.SetBool("Run", false);
           
         
        }
        
      
        
        if(Input.GetKeyDown(KeyCode.DownArrow) && (horizontalInput > 0.01f || horizontalInput < -0.01f) ){
       
          anim.SetBool("Sneak", true);
          anim.SetBool("Sit", true);
            anim.SetBool("Run", false);
        
            speed=speed-3;

          
        }
        
        if(Input.GetKeyUp(KeyCode.DownArrow)){
         
           anim.SetBool("Sit", false);
           anim.SetBool("Sneak", false);
     
            speed=5;
        }

     
    }

    private void OnTriggerEnter2D(Collider2D other) {

      if(other.gameObject.CompareTag("Gem"))
      {
        Destroy(other.gameObject);
      }
      
    }

    private void Jump()
    {
      player.velocity= new Vector2(player.velocity.x, speed);
      
      anim.SetTrigger("Jump");

    }

   private bool isLanded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, landLayer);
        return raycastHit.collider != null;
    }

      public bool canAttack()
    {
        return isLanded();
    }
   

   
}
