using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect(object focusedObject)
    {
        var clickedObject = focusedObject as GameObject;

        // Do a raycast into the world based on the user's
        // head position and orientation.
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;
        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            // If the raycast hit a hologram, use that as the focused object.
            clickedObject = hitInfo.collider.gameObject;

            float x = 0;
            float y = 0;
            float z = 0;
            switch (clickedObject.name)
            {
                case "Laengstträger":
                    x = 0.234f;
                    y = -0.268f;
                    z = 0.361f;
                    break;
                case "Laengsträger2":
                    x = 0.234f;
                    y = -0.268f;
                    z = 0.361f;
                    break;
                /*case "Gewinde":
                    x = clickedObject.transform.localPosition.x;
                    y = clickedObject.transform.localPosition.y + 0.5f;
                    z = clickedObject.transform.localPosition.z;
                    break;*/
                case "HaltebockParent":
                    x = 0.234f;
                    y = -0.268f;
                    z = 0.361f;
                    break;
                case "Schottteil":
                    x = 0.36f;
                    y = -0.462f;
                    z = 0.226f;
                    break;
            }

            clickedObject.transform.localPosition = new Vector3(x, y, z);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit, 100))
        //    {
        //        GameObject clickedObject = hit.transform.gameObject;
        //        Debug.Log(clickedObject.name + " / " + clickedObject.transform.localPosition);

        //        float x = 0;
        //        float y = 0;
        //        float z = 0;
        //        switch (clickedObject.name)
        //        {
        //            case "Laengstraeger":
        //                x = clickedObject.transform.localPosition.x;
        //                y = clickedObject.transform.localPosition.y + 0.5f;
        //                z = clickedObject.transform.localPosition.z;
        //                break;
        //            case "Laengstraeger2":
        //                x = clickedObject.transform.localPosition.x;
        //                y = clickedObject.transform.localPosition.y + 0.5f;
        //                z = clickedObject.transform.localPosition.z;
        //                break;
        //            case "Gewinde":
        //                x = clickedObject.transform.localPosition.x;
        //                y = clickedObject.transform.localPosition.y + 0.5f;
        //                z = clickedObject.transform.localPosition.z;
        //                break;
        //            case "Haltebock":
        //                x = clickedObject.transform.localPosition.x;
        //                y = clickedObject.transform.localPosition.y + 0.5f;
        //                z = clickedObject.transform.localPosition.z;
        //                break;
        //            case "Schottteil":
        //                x = clickedObject.transform.localPosition.x;
        //                y = clickedObject.transform.localPosition.y + 0.5f;
        //                z = clickedObject.transform.localPosition.z;
        //                break;
        //        }

        //        clickedObject.transform.localPosition = new Vector3(x, y, z);
        //    }
        //}
    }
}
