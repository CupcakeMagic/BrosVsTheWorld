using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInputHorisontal = Input.GetAxisRaw("Horizontal");
        float moveInputVertical = Input.GetAxisRaw("Vertical");
        Debug.Log("Хоризонтал: " + moveInputHorisontal + "    Вертикал: " + moveInputVertical);
        rb.velocity = new Vector2(moveInputHorisontal * speed, moveInputVertical * speed);
        if(moveInputHorisontal == 0 && moveInputVertical == 0)
        {
            anim.SetBool("IsMoving", false);
        }
        else
        {
            anim.SetBool("IsMoving", true);
        }
        if(moveInputHorisontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (moveInputHorisontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }
}
