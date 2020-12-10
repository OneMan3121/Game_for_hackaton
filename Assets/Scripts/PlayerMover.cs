using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMover : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);

    private Vector2 movement;
    private bool isFacingLeft = true;
    private Rigidbody2D rigidbody2d;
    private GameObject button_use;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        button_use = GameObject.FindGameObjectWithTag("Button_Use");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed_X", speed.x * inputX);
        float inputY = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed_Y", speed.y * inputY);
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);
        if (Input.GetKey((KeyCode)'e') && button_use.GetComponent<Button>().interactable)
        {
            ItemTriggerManager.deleteFindedEvidence();
        }

    }
    void FixedUpdate()
    {
        rigidbody2d.velocity = movement;

    }




}
