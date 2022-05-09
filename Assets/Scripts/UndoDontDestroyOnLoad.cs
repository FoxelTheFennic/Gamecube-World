 using UnityEngine;
 using System.Collections;
 
 public class ExampleClass : MonoBehaviour
 {
     private void OnLevelWasLoaded(int level)
     {
         Destroy(gameObject);
     }
 }