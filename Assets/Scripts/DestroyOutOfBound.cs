using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    // Update is called once per frame
    public int outOfBound = 20;
    void Update()
    {
        if (transform.position.z > outOfBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -outOfBound)
        {
               Destroy(gameObject);
        }
    }
}
