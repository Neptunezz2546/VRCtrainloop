
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class trainMovement : UdonSharpBehaviour
{
    public float speed = 3;
    public float Timer;
    public float TimerAdder;
    public GameObject cube;
    //need to set up an empty to where you want the geometry to teleport to
    //after a given time
    public Transform teleportTarget;
    private void Update()
    {
        movement();
    }

    void movement()
    {
        //using this formula it moves the geometry and also allows
        //for the user to speed up the movement
        cube.transform.Translate(Vector3.right * speed * Time.deltaTime);
        //using the timer to make infinite movement and to trigger events
        if (Timer > 0)
            Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            moreMovement();
            Timer += TimerAdder;
        }
    }
    
    //teleports geometry to teleportTarget object position
    void moreMovement()
    {
        cube.transform.position = teleportTarget.transform.position;
    }

}
