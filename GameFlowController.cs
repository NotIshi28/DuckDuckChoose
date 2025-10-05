using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameFlowController : MonoBehaviour
{
    public GameObject preChoice;
    public Animator preChoiceCar;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!preChoiceCar.enabled)
        {
            if (Input.GetButton("Jump"))
            {
                text.SetActive(false);
                preChoice.SetActive(false);
                Choice1.SetActive(true);
            }

            if (Input.GetButton("Submit"))
            {
                text.SetActive(false);
                preChoice.SetActive(false);
                Choice2.SetActive(true);
            }
        }
    }
}
