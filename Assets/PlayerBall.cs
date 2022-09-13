using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : CollisionObject
{
    [SerializeField] private RectTransform ball;
    [SerializeField] private PlayerPlatform platform;
    [SerializeField] public float speedY;
    public float speedX;

    private void Awake()
    {
        speedX = speedY;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (platform.ballStart)
        {
            Move();
        }
    }

    void Move()
    {
        ball.position += Vector3.up * speedY * Time.deltaTime;
        ball.position += Vector3.right * speedX * Time.deltaTime;
    }
}
