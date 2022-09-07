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
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        //Changing Direcions
    }
}
