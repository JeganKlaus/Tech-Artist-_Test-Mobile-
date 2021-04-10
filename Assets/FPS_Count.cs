using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_Count : MonoBehaviour
{
    // Start is called before the first frame update

    public Text FPS;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fps = 1.0f / Time.deltaTime;
        int temp = Mathf.RoundToInt(fps);
        FPS.text = temp.ToString();
    }
}
