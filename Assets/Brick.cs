using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : CollisionObject
{
    [SerializeField] private PlayerBall ballF;
    private Collision collision;

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
        ballF.speedY *= -1;
        Destroy(this.gameObject);
    }
}
