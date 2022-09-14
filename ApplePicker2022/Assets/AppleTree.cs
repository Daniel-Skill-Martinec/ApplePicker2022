using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    //Prefab for Instantiating Apples
    public GameObject applePrefab;

    //speed at which AppleTree Moves
    public float speed = 1f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    //Chance the AppleTree will change directions
    public float ChangeDirChance = 0.1f;

    //Seconds between Apple instantiations
    public float appleDropDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Start Dropping Apples
        Invoke("DropApple", 2f);

    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Changing Direcions
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);//move right
        } else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);//move left
        }
        Debug.Log(pos.x);
    }

    private void FixedUpdate()
    {
        if (Random.value < ChangeDirChance)
        {
            speed *= -1;
        }
    }
}
