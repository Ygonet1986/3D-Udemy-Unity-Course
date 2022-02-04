using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed;
    public float jumpForce;
    public float gravityScale = 5f;
    private Vector3 moveDirection;
    public CharacterController charController;


    private void Awake() {

        charController = GetComponent<CharacterController>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
       

            
    }

    void movement(){

        float yStore = moveDirection.y;
        
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0f,Input.GetAxisRaw("Vertical")); 
        //moveDirection = moveDirection * moveSpeed;
        moveDirection.y = yStore;
        
        if(Input.GetButtonDown("Jump")){
           
           moveDirection.y = jumpForce;
        }

        moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale ;



        //transform.position += moveDirection * moveSpeed * Time.deltaTime ; 
        charController.Move( moveDirection * Time.deltaTime * moveSpeed );


    }

    
}
