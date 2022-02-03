using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed;
    public float jumpForce;
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
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0f,Input.GetAxisRaw("Vertical")); 
        moveDirection = moveDirection * moveSpeed;
        
        if(Input.GetButtonDown("Jump")){
            moveDirection.y = jumpForce;
        }

        //transform.position += moveDirection * moveSpeed * Time.deltaTime ; 
        charController.Move( moveDirection * Time.deltaTime );

       

            
    }

    
}
