using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    AndroidJavaObject ajo = null;
    AndroidJavaClass ajc = null;
    // Start is called before the first frame update
    void Awake() {
        ajo = new AndroidJavaObject("com.qualcomm.powersdk.PowerSDKJavaAPI");
        if(ajo != null)
            Debug.LogError("ajo is not null =================");
        else
            Debug.LogError("ajo is null===============");
    }
    void Start()
    {
        ajc = new AndroidJavaClass("com.qualcomm.powersdk.PowerControl");
        if (ajc != null)
            Debug.LogError("ajc is not null ===========");
        else
            Debug.LogError("ajc is null =============");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI() {
        GUILayout.BeginArea(new Rect(300, 300, 300, 100));
        GUILayout.BeginHorizontal();
        if(GUILayout.Button("Init")){
            ajc.CallStatic<bool>("init");
            Debug.LogError("Init");
        }
        if(GUILayout.Button("Hello")) {
            Debug.LogError("Hello");
        }
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
