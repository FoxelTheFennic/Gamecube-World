using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPlayer : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            source.PlayOneShot(clip);
        }

        if(Input.GetKeyDown("g"))
        {
            gameObject.transform.position = new Vector3(-0.8199997f, 3.22f, -4.5f);
            source.PlayOneShot(clip);
        }
    }
}
