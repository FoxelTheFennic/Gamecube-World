using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Collections;
using System;


public class TextGlitch : MonoBehaviour 
{

public List<string> Glitch = new List<string>();
public string username;
//string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;


    // Start is called before the first frame update
    void Start()
    {
        username = Environment.UserName;
        Glitch.Add("SDFGGASDHJODSFGHSFDALGJFASHJKDLALHJBFDJ33254#$$#%%#@%#");
        Glitch.Add("$##@h$$434GBH3H34k$#q#@$@#$HJKG34234KH245");
        Glitch.Add("$J%#KLH%@H*(RF@H*(F@H*)F#()DWSVDF(*V(V*(S)V*DSV}VSCV{VC");
        Glitch.Add("DSFJHJHLK**(****!@*#87238238932789798*&@*(");
        Glitch.Add("SDFGGASDHJODSFGHSFDALGJFASHJKDLALHJBFDJ33254#$$#%%#@%#");
        Glitch.Add("FDGSGFDS&&**");
        Glitch.Add("RUN");
        Glitch.Add("AAAAAAAGHGFHFDFHDHFDFHDHFDHFDDHFHDFS");
        Glitch.Add("&$*#$*@#*#*$#*$#(*&$");
        Glitch.Add("hello? is anyone there...?");
        Glitch.Add(";:{}{:'[];[]:[DFFDSSDF888");
        Glitch.Add("|||||||||||||||||||||||||||||");
        Glitch.Add(username  + "...");
        Glitch.Add(username  + ", you need to get out of here. now.");
        Glitch.Add("its not safe here, dont get trapped like me.");
        Glitch.Add(username + ", leave. this isnt a game. this is serious.");
        Glitch.Add(username  + "... im scared...");
        Glitch.Add("its coming. leave " + username + ".");
        Glitch.Add("NO ESCAPE");
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshPro mText = gameObject.GetComponent<TextMeshPro>();
        mText.text = Glitch[UnityEngine.Random.Range(0, Glitch.Count)];
    }
}
