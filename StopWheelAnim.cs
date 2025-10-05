using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWheelAnim : MonoBehaviour
{
    public GameObject car;
    public GameObject trigger;
    public Animator wheelAniim;
    public GameObject text;
    public void StopWheelAnimation()
    {
        wheelAniim.enabled = false;
        text.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (car.transform.position.x < trigger.transform.position.x)
        {
            StopWheelAnimation();
        }
    }
}
