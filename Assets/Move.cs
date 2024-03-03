using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 10;
    public GameObject Car;

    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        Car.transform.Rotate(0, speed* 10 * Time.deltaTime, 0);  
    }
}
