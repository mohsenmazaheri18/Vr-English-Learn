using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Animation_Work : MonoBehaviour
{
    public Transform vrCamera;

    public float toggleAngle = 30.0f;

    public float speed = 3.0f;

    public bool moveForward;

    public Animator Anim;

    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("vrCamera.eulerAngles.x: " + vrCamera.eulerAngles.x);
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
            Anim.Play("male_move_walk_front");
        }
        else
        {
            moveForward = false;
            Anim.Play("male_idle_breath");
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
    }
}