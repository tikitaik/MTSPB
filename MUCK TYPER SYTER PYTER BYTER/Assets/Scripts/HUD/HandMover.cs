using UnityEngine;

public class HandMover : MonoBehaviour
{
    [SerializeField] float transY = 300f;
    public GameObject handLeft;
    public GameObject handRight;
    bool hand = false;

    void Awake()
    {
        handRight.transform.position = handRight.transform.position + new Vector3(0, transY, 0);
    }

    void Update()
    {
        if(Input.anyKeyDown)
        {
            if (hand == true)
            {
                handLeft.transform.position = handLeft.transform.position + new Vector3(0, transY * -1, 0);
                handRight.transform.position = handRight.transform.position + new Vector3(0, transY, 0);
            }
            else
            {
                handLeft.transform.position = handLeft.transform.position + new Vector3(0, transY, 0);
                handRight.transform.position = handRight.transform.position + new Vector3(0, transY * -1, 0);
            }

            hand = !hand;
        }
    }   
}