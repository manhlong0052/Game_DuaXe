using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rb;

    public Vector2 velocity = new Vector2(0f ,0f);

    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    public float speedUp = 0.5f;
    public float speedDown = 0.5f;
    public float speedMax = 20f;
    public float speedHorizontal = 3f;
    public bool autoRun = false;

    private void Awake()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");

        if (this.autoRun) this.pressVertical = 1;
    }

    private void FixedUpdate()
    {
        speedUpdate();
    }

    protected virtual void speedUpdate()
    {
        this.velocity.x = this.pressHorizontal * this.speedHorizontal;

        this.speedUpdateUp();
        this.speedUpdateDown();


        this.rb.MovePosition(this.rb.position + this.velocity * Time.fixedDeltaTime);
    }

    protected virtual void speedUpdateUp()
    {
        if (this.pressVertical > 0)
        {
            this.velocity.y += this.speedUp;

            if (this.velocity.y > this.speedMax)
            {
                this.velocity.y = this.speedMax;
            }

            if (transform.position.x < -7 || transform.position.x > 7)
            {
                this.velocity.y -= 1f;
                if (this.velocity.y < 3f) this.velocity.y = 3f;
            }
        }
    }

    protected virtual void speedUpdateDown()
    {
        if (this.pressVertical == 0)
        {
            this.velocity.y -= this.speedDown;
            if (this.velocity.y < 0) { this.velocity.y = 0; }
        }
    }
}
