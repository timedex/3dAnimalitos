using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimal : MonoBehaviour
{
    public float movementSpeed = 3;
    public float jumpForce = 300;
    public float timeBeforeNextJump = 1.2f;
    public float powerUpTime = 5;
    private float canJump = 0;

    Animator anim;
    Rigidbody rb;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ControllPlayer();
    }

    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(movement),0.15f);
            anim.SetInteger("Walk", 1);
        }
        else
        {
            anim.SetInteger("Walk", 0);
        }
        transform.Translate(movement*movementSpeed*Time.deltaTime,Space.World);
        if (Input.GetButtonDown("Jump") && Time.time>canJump)
        {
            rb.AddForce(0, jumpForce, 0,ForceMode.Impulse);
            canJump = Time.time + timeBeforeNextJump;
            anim.SetTrigger("jump");
        }
    }
    public void PowerUp()
    {
        StartCoroutine(PowerUpIE());
    }
    IEnumerator PowerUpIE()
    {
        float movePower = movementSpeed;
        movementSpeed = 12f;
        yield return new WaitForSeconds(powerUpTime);
        movementSpeed = movePower;
    }
}
