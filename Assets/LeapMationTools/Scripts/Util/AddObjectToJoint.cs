using System.Collections;
using System.Collections.Generic;
using Leap.Unity.Attachments;
using UnityEngine;

[RequireComponent(typeof(AttachmentHands))]
public class AddObjectToJoint : MonoBehaviour
{
    public GameObject addObg;
    public List<GameObject> addList = new List<GameObject>();
    public void Add()
    {
        if (addObg != null)
        {
            foreach (var obj in addList)
            {
                DestroyImmediate(obj.gameObject);
            }
            addList.Clear();
        }
        foreach (Transform item in transform)
        {
            foreach (Transform child in item.GetComponentsInChildren<Transform>())
            {
                if(child==item) continue;
                
                //Debug.Log(child.name,child.gameObject);
                var temp= Instantiate(addObg, child);
                addList.Add(temp);
            }
        }
    }

    public void Clear()
    {
        if (addObg != null)
        {
            foreach (var obj in addList)
            {
                DestroyImmediate(obj.gameObject);
            }
            addList.Clear();
        }
    }
    
}
