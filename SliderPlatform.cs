using UnityEngine;

public class SliderPlatform : MonoBehaviour
{
    public SliderJoint2D slider_platform;
    private JointMotor2D slider_motor;

    private void Start()
    {
        slider_platform = GetComponent<SliderJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "upperpoint")
        {
            slider_motor = slider_platform.motor;
            slider_motor.motorSpeed = -0.5f;
            slider_platform.motor = slider_motor;
            //Debug.Log("Upperpoint");
        }
        if (other.gameObject.tag == "lowerpoint")
        {
            slider_motor = slider_platform.motor;
            slider_motor.motorSpeed = 0.5f;
            slider_platform.motor = slider_motor;
            //Debug.Log("Lowerpoint");
        }


    }
}
