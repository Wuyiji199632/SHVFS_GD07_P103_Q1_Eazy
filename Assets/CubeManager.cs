using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject Cube;
    public Rigidbody CubeRigid;
    public float Timer;
    public float TimerForMoving;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        TimerForMoving -= Time.deltaTime;
        if(Timer<=0)
        {
            Instantiate(Cube, transform.position, Quaternion.identity);
        }
        if(TimerForMoving<=0)
        {
            CubeRigid.velocity = new Vector3(CubeRigid.transform.position.x, CubeRigid.transform.position.y, speed);
        }
            
    }
}
