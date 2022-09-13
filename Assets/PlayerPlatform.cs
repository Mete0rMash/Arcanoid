using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : CollisionObject
{
    [SerializeField] private float speed;
    [SerializeField] private RectTransform platform;
    [SerializeField] private RectTransform ball;
    [SerializeField] private PlayerBall ballF;
    private Collision collision;
    private bool ballCanMove;
    public bool ballStart;

    private void Awake()
    {
        collision = this.GetComponent<Collision>();
        ballCanMove = true;
        ballStart = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();

        if (collision.CheckCollision())
        {
            OnCollision();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            CheckStart();
        }
    }

    void CheckInput()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            MovementX(Input.GetAxis("Horizontal"));
        }

        if (ballCanMove)
        {
            MovementBall(Input.GetAxis("Horizontal"));
        }
    }

    public void CheckStart()
    {
            ballCanMove = false;
            ballStart = true;
    }

    void MovementX(float axisMovement)
    {
        platform.position += Vector3.right * axisMovement * speed * Time.deltaTime;
    }

    void MovementBall(float axisMovement)
    {
        ball.position += Vector3.right * axisMovement * speed * Time.deltaTime;
    }

    public override void OnCollision()
    {
        ballF.speedY *= -1;
    }
}
