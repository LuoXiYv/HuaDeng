using UnityEngine;

public class CameraFllow : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public  Vector3 minPosition;
    public  Vector3 maxPosition;
     void Start()
    {
        minPosition.x = -25.2f;
        maxPosition.x = 17.40f;
        minPosition.y = 1.60f;
        maxPosition.y = 1.60f;
        minPosition.z = -10f;
        maxPosition.z = -10f;
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            if (transform.position != target.position)
            {
                Vector3 targetPos = target.position;
                targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
                targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);
                targetPos.z = Mathf.Clamp(targetPos.z, minPosition.z, maxPosition.z);
                transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
            }
        }


    }
    public void Lock()
    {
        if (Collider2D.shop && (Revolve.newFace == 7 || Revolve.newFace == 8 || Revolve.newFace == 9 || Revolve.newFace == 10 || Revolve.newFace == 11 || Revolve.newFace == 0))
        {
            minPosition.x = -6.78f;
            maxPosition.x = -6.78f;
            minPosition.y = 40.2f;
            maxPosition.y = 40.2f;
            minPosition.z = -10f;
            maxPosition.z = -10f;
        }
        else if (Collider2D.workShop)
        {
            minPosition.x = -22.24f;
            maxPosition.x = -22.24f;
            minPosition.y = 28.9f;
            maxPosition.y = 28.9f;
            minPosition.z = -10f;
            maxPosition.z = -10f;
        }
    }

    public void UnLock()
    {
        minPosition.x = -25.2f;
        maxPosition.x = 17.40f;
        minPosition.y = 1.60f;
        maxPosition.y = 1.60f;
        minPosition.z = -10f;
        maxPosition.z = -10f;
    }
    
}
