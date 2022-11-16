using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 10f;
    [SerializeField]
    int sensivity = 3;
    [SerializeField]
    int maxdistance = 10000000;
    [SerializeField]
    int mindistance = 0;

    [SerializeField]
    public Transform targetPos;
   
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // êíîïêè A D 
        float y = Input.GetAxis("Vertical"); // êíîïêè W S 

        if (x != 0 || y != 0)
        {
            Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
                transform.position = newpos;
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
                transform.position = newpos;
        }

        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
            // transform.Rotate(Vector3.left*Input.GetAxis("Mouse Y")*sensivity);             
        }
    }

    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool move = false;
    Vector3 startPosition;
    Vector3 needPosition;
    float speed = 0.01f;
    float offset = 0;
  

    public void MoveFridge()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needPosition = new Vector3(-20.36945f, -7.771103f, -68.74017f);

        }

    }

    public void Move()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needPosition = new Vector3(124f, 24f, 6f);

        }

    }

    public void MoveShkaf()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needPosition = new Vector3(-72.97576f, 59.53535f, 192.336f);
        }

    }

    public void MoveDoor()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needPosition = new Vector3(-76.97799f, -99.58649f, 107.6785f);
        }

    }

    public void MoveComf()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needPosition = new Vector3(-148.6109f, -48.94456f, 104.8125f);
        }

    }

    public void MoveTarelka()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needPosition = new Vector3(-113.5821f, -88.44522f, -90.931f);
        }
    }


    void FixedUpdate()
    {
        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);

            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }

    
}


/*public class camera : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 10f;
    Transform targetPos;
    int sensivity = 3;
    int maxdistance = 20;
    int mindistance = 1;

    //  ÔÓÍÊÖÈß ÎÃÐÀÍÈ×ÅÍÈß ÏÐÅÄÅËÎÂ ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ 
    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance) return true;
        return false;
    }

    // ÂÐÀÙÅÍÈÅ ÂÎÊÐÓÃ ÖÅÍÒÐÀËÜÍÎÉ ÒÎ×ÊÈ ÓÑÒÀÍÎÂÊÈ Ñ ÇÀÆÀÒÎÉ ÏÐÀÂÎÉ ÊËÀÂÈØÅÉ ÌÛØÈ 
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
        }
        // ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ Â ÑÒÎÐÎÍÛ ÊËÀÂÈØÀÌÈ 

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x != 0 || y != 0)
        {
            transform.position += (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
            if (ControlDistance(Vector3.Distance(transform.position, targetPos.position))) transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
        }

        // ÏÐÈÁËÈÆÅÍÈÅ È ÓÄÀËÅÍÈÅ ÊÀÌÅÐÛ ÎÒ ÓÑÒÀÍÎÂÊÈ ÏÐÎÊÐÓÒÊÎÉ ÊÎËÅÑÀ ÌÛØÈ 
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            if (ControlDistance(Vector3.Distance(transform.position, targetPos.position))) transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
        }

    }
}*/
/*public class camera : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 10f;
    Transform targetPos;
    int sensivity = 3;
    int maxdistance = 20;
    int mindistance = 1;

    //  ÔÓÍÊÖÈß ÎÃÐÀÍÈ×ÅÍÈß ÏÐÅÄÅËÎÂ ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ 
    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance) return true;
        return false;
    }

    // ÂÐÀÙÅÍÈÅ ÂÎÊÐÓÃ ÖÅÍÒÐÀËÜÍÎÉ ÒÎ×ÊÈ ÓÑÒÀÍÎÂÊÈ Ñ ÇÀÆÀÒÎÉ ÏÐÀÂÎÉ ÊËÀÂÈØÅÉ ÌÛØÈ 
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
        }
        // ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ Â ÑÒÎÐÎÍÛ ÊËÀÂÈØÀÌÈ 

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x != 0 || y != 0)
        {
            Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position))) transform.position = newpos;
        }

        // ÏÐÈÁËÈÆÅÍÈÅ È ÓÄÀËÅÍÈÅ ÊÀÌÅÐÛ ÎÒ ÓÑÒÀÍÎÂÊÈ ÏÐÎÊÐÓÒÊÎÉ ÊÎËÅÑÀ ÌÛØÈ 
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position))) transform.position = newpos;
        }

    }
}*/

/*public class camera : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 10f;

    [SerializeField]
    Transform targetPos;
    int sensivity = 3;
    int maxdistance = 20;
    int mindistance = 1;

    //  ÔÓÍÊÖÈß ÎÃÐÀÍÈ×ÅÍÈß ÏÐÅÄÅËÎÂ ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ 
    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance) return true;
        return false;
    }

    // ÂÐÀÙÅÍÈÅ ÂÎÊÐÓÃ ÖÅÍÒÐÀËÜÍÎÉ ÒÎ×ÊÈ ÓÑÒÀÍÎÂÊÈ Ñ ÇÀÆÀÒÎÉ ÏÐÀÂÎÉ ÊËÀÂÈØÅÉ ÌÛØÈ 
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
        }
        // ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ Â ÑÒÎÐÎÍÛ ÊËÀÂÈØÀÌÈ 

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x != 0 || y != 0)
        {
            transform.position += (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;

        }

        // ÏÐÈÁËÈÆÅÍÈÅ È ÓÄÀËÅÍÈÅ ÊÀÌÅÐÛ ÎÒ ÓÑÒÀÍÎÂÊÈ ÏÐÎÊÐÓÒÊÎÉ ÊÎËÅÑÀ ÌÛØÈ 
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);

        }

    }
}
*/