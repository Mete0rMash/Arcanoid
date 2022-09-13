using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Collision : CollisionObject
{
    [SerializeField] private RectTransform player;
    [SerializeField] private RectTransform wall;
    private CollisionObject collision;
    private float dXP;
    private float dYP;
    private float dXW;
    private float dYW;

    private void Awake()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dXP = player.sizeDelta.x/2;
        dYP = player.sizeDelta.y/2;
        dXW = wall.sizeDelta.x/2;
        dYW = wall.sizeDelta.y/2;
        CheckCollision();
    }

    public bool CheckCollision()
    {
        return (CheckCollisionXY());
    }

    bool CheckCollisionXY()
    {
        if ((dXP + dXW) >= Mathf.Abs(wall.position.x - player.position.x))
        {
            if (((dYP + dYW) >= Mathf.Abs(wall.position.y - player.position.y)))
            {
                return true;
            }
        }
        return false;
    }
}
