using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TPToWiilink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update () {
         
     }
    void OnMouseDown(){
            // this object was clicked - do something
        SceneManager.LoadScene("Wiilink HQ");
    }   
}
