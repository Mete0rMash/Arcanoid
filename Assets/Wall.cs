using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Wall : CollisionObject
{
    [SerializeField] RectTransform plat;
    [SerializeField] RectTransform ball;
    [SerializeField] PlayerPlatform platform;
    [SerializeField] private PlayerBall ballF;
    Collision collision;

    private void Awake()
    {
        collision = this.GetComponent<Collision>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collision.CheckCollision())
        {
            OnCollision();
        }
    }

    public override void OnCollision()
    {
        plat.position += Vector3.left * Input.GetAxis("Horizontal") * 5;

        if (!platform.ballStart)
        {
            ball.position += Vector3.left * Input.GetAxis("Horizontal") * 5;
        }

        ballF.speedX *= -1;
    }
}
