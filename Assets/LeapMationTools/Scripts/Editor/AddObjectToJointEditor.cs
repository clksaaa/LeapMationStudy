using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AddObjectToJoint))]
public class AddObjectToJointEditor : Editor
{
  public override void OnInspectorGUI()
  {
    base.OnInspectorGUI();
    if(GUILayout.Button("挂在物体到所有的关节下"))
    {
      //Debug.Log("点击了");
      (target as AddObjectToJoint).Add();
    }
    if(GUILayout.Button("删除挂在物体关节下生成的物体"))
    {
      //Debug.Log("点击了");
      (target as AddObjectToJoint).Clear();
    }
  }
}
