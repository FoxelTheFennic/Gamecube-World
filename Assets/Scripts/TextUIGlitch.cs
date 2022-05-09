using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 
using System;

public class TextUIGlitch : MonoBehaviour 
{
    public string username;
    public List<string> Glitch = new List<string>();
    private TextMeshProUGUI textMesH;

    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI> ();
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




        Glitch.Add("N̸̡̨̧̡̢̨̡̡̡̢̛̥̘̫̮̦͓͇͕͉̹͙̱̪̘͓͈̫̬͈͍͖͔̫̰̰̜͚̖̹͚̼̗̹͖͖͎͇̜̬̖̖̟͖͙̱̤͖̗̳̞̞̠͙͌́̓̊͗̑̍̎̈̈́̽̓͐̏̇̀̒͐͋̾̓̈́͌̈́͋̏͗́̎̅̍͋̾͌̈̊̊͂͐͋͗̆͘̚͘͜͠͝͝͝͝͠͝ͅǪ̵̛̻̬̝̣̖̫͎̠̬̲̲͚͙͔̻̩̞͔̣̥̪͙̮̱̦͉͙̻̺̯̭̠̪̼̖̠̩̤̜͓͖̤͙̩̼̙̗̦̘̱͕̰̃̓̃͂́̍̈̍̉̅̀̿̈́̐̈́͊̊̍̀͐̽̓̌̋͗̽̒̆̀̏̉̾̂̅̀̊̑̀̓̎̽͒̎́̐͑͂͑̿̈́̓̆̈́̽̍̓̾̽̈́͆̿̾̑̒̕̚̚̕̕͘̚͜͝͝͝͠͝͝͝͝͠͠ͅͅ ̶̨̨̢̛̠̲̙͓̜̰͕̹̩̞̺͖̩̗̥͖͓͎̠̘̟̥͖̥̫̺̺̺̪͎̲͔̳̫͇͖̯̣͍̓́̈́͑̇̓̓̎͌͑͛͌͑͋̔͐̽̎̚̚͜͝͝E̵̢̧̧̡̨̺̻̮̳̺͉̹̤̺̦̟̮̪̺̞̻̤̲̗̲̲̠͎̣̥̦̗͔̦͔̯̠͚̬̘͈̖̮̻̥̺̼͍̖̩͙̤̮̼̠̖̭̣̲͔̩̬̭̙̻͖̜̪̙̥̝͔͔̝̣͎̦̿̓̎́̿̚͜͜Ș̸̢̨̧̡̡̛͙͓̲͖̦͎͕̳̱̠͇͚͖̪͚̜͎̮͓̫̳̼̺̣̤̩̯̲̣͔͇̰̥̲͔̞̹̫͇̪͔̯̹͆͐̽̏̍̌̈͌͂͌͒̌̄͆̅͒͊̋͂̂̔̉̔́̂̿̇̅̂̆̃̃͂̈̀͂̐̔̇̏̇̌͗̚͜͜͜͜͝͝͝͝ͅC̸̢̡̡̢̨̢̢̨̳̞̻̠͙̮̠̘̲͍̟͙̗͇̤͍̻̬͕̩͎̹̖͎͍̝̥̬̫̤̗̰̱̗̩̻̖͇̹͉͔͙͖̻̗̲̟̠͓̣̥̬̻̪̝͉̦̥̰̤̘͚̟͐̋͐̊͑̋̀̑͗̿́̀̇̌̋͘͜͜ͅͅͅȀ̵̢̨̡̨̨̢͉̙̙̠̰̳͍̞͈̩̝̰̼̪̲̘͖̙͕͖͓̥̝̳̳̰̪̲͕̳̩̰̭̫̩̲̮̖̪͍̖̙̲̺̮͈̟̞͙͈̻̱͎̦̘̱͍̟͙̖̺̦̦̘̣̟̦̲̲͉͉̃̿̆̈̍̌͆̔̊̈́͛̑̑̽̽̽̄̌͒̇̈́͂̄̈́̇̾̔͐̋́͂̄͌̋̍͑͆̈́̀͌̈́̿̏͌̾̐́͆͒̀̀̆̅̔͌̿̌̉́͒͂̎͗͐͘͘̕̚͠͠͠͝͝͝͝ͅͅP̷̧̛̛̛̼͍̠̫̥͚͎͙͇͇̳̲͙̙̘̜̯͈̤̤͌̐̆̊͌̈́̍̊̒͛͊̈́̀͆̑́̂̾́̍̐̔̋̓̈́̋̾̈́̄̊̈́̃̓́̽̆̀͗̏̿̑̈̉̈̌̉͋͆͆͛̍͛͂̊̎̀͌́͑̌̈́̏͛́̈̐̊̌͘͘̚̕̕̕͜͝͝͝ͅȨ̶̨̧̡̢̧͎̫̪̰̮̜̞̳̟͖̱̞̝͙̮̞̰̜̭͕̲̠͈͈̫͕̦͉̳̹͕͙͕̻͈͚̫̙̖͖̬͍̮̳͓̜͉̙̥͔̯̗̘̬̟̫̦̘͕̮̹̬̟̺̝̄̈̾͌̒͑̍̈̉̈́̑͒͜͜͝ͅͅͅ ̵̧̨̡̡̨̞͖̥̘̰͈͚̥̖̟̼̲͚̭̪͎̗̉̒̌͛͒͛̀͌̈͌̂͗̑̐͌͗̑̀̂̅͒͘͜͝͝N̷̢̡̢̧̛̛͔̙͍̱̱̮̥͚̠͙̙͚̙̗̞̖͇͓̪̝̤̰͚͈̘̙̺̦̮̠̥̻̺̰͚͕̙̖̜̦͑̒̉̈́̅͌̑̔́͑́͆͑͑̇̓̄͐̿͗̑̀͗̈́͘͘͜͝ͅͅƠ̷̡̨̧̡̛̙̯͈̤̳̹̬̟̳̦͇̲͚̲͉̣͓̙͈͙̬͙͕̭̭̹͙̜̺̜͎̥̜̗̖͙͓̪͍̪͇̺̰̻͖̺̝͙̜̳̗̣̙͎̝̫̬̜̆̾̈́͗̀́́͂̅͛̂͆̑̍́̆̎̎͌͒͑̒͗̊͌̔͛̎̆͒̇̕͝͠͠͝ͅͅ ̴̧̨̡̡̢̡̨̧̢̰̪̯͔̠̝̙̮͓̼̠͇͕̤̘̼͕͕̜̦̖̟̫̺͇̦͖̟͙̯͔̝̲͔̤͇͔̫͋̒̅̈́́͂͂̄̌͂̔̍͒̔̽̆̉͂̈́͂̈́̈́̓̀̿͑̂́̓͌͛̈̽͒̃͂̄̽̀̅̀̃̈͌̓̓͊̆̂̽͘̚̕͜͝͝͝ͅE̶̡̧̧̢̢̛̛̛̳͈̻̱͇͕̳̟̠̠͍̖͓̼̗̜̻̣̣̼͉̟̝̞͚̦͕̹̝̫̳̥̯̮͓͕̟̿̈́̄̇͗̓̀͊̈́̾̔̈́̔̾̋̎͛̆̂͆͗̾͗́̊͆͛͗̿̋͊͐̽̋̉̿͐̐͑̿̀̓̉̂̌͌͛͐̀͛̂̎́͑̾̆͐̈́͗̆͛̈́̄̆͗͐͑̕̚̚͘͜͜͜͠͠͠͠͝͝͝͝͠͝S̷̡̢̧̡̛̼͍̦̖͈͇̻͎̲͖̥̼͓̜͇̩͙̖̲̫͍̻̫̗͖̜̩̹͓͓̺̞̝̩̺̲̹̠̥̝̞̘͙͉̮̘̬͈̥̖̝̠̰͉̤̹̱̦͓̮͕̮̫̒̍̆̒̇́̇̈́̄̐͂̃̉̄̄̉̽͠͝Ç̷̛̛̪̮̟̰͍̜̫̟͍̗̹̺̖͍̗̫͉͇̘͔͉͈̦̲̫͓̙͉̱͓͓͔͖̹͖̞͙̹͚̘͍̘̤̣͎̬̝͙͚̟̦̒̾͗͌̋̈́̾̎̽̃̇̆̈͒̋̿͑̚͘̚͜͜͜͝͠͝͠͝͝ͅͅȀ̶̧̛̛̛̗͖̮̙̞̹̑̃̈́͐͋̈́̑̏̈͛̾̃̿͒̌̀̾͗͊͒̄̇̓̐̈́̾̀̉̏́̍̓̓̍͛̏̃̊̓͋͐͐͂͆̅͑̓͗̈́́̓̾̄͒̐̍͗̑͆͆̔̚̕̚̚͜͠͝͝͝͠P̶̢̨̧̢̡̢̧̛̟͔͚͈̝̱̲̗͙̭̱̱̩̮̳̮̟̯̜͉̱̰͖͍̬̭̼̜̼̖̬̙̞͖͈͕̗̲̹̘͓͓̘̦̣̝̤̻̠͙̭̼̪͉͔̲̥̘̣̝͚̞̻̳̙̱͆͂͑̐̒͛͐͌̽̍͌̐̀ͅͅͅͅȨ̷̡̛̬͓̖̥̬̣̫̦͈͕͈͉̣̜̫̺̟̮̗̩̪͔̠̟͈̞̜̖͈͉͖̫̪̰̤͖̾͑͋́̌̈́̾͌͑̾̌̆̀̅̐̏͂͋̽̄̑̈̉͛̿̈́̓́̈́̂̈́̉̈́͗͐̆̆̉̅̔̆̓̅͑͒͆̚̚͜͜͝͝͝͝͝ͅͅͅ");
        Glitch.Add("w̵̧̢̨̧̡̨̡̧̨̡̨̧̡̛̛̛̛̛̛̛̱̱͉͉̟͉͚̥͇̦̝̮͈̤̟͇̘̫͍̞̬̘̜͕͚̥͙͙̭̺͖͙̭̬̼̼̭̠̺͚̮̼͓͇̥̥͕̱͙̟̠̤̮͎͖̣̩̣̱̦̬̤̰̦̪͉̮͍̺̦̜̬̲̩̩̫͉͈͈̮̬̖̮̰͉̤̫͆̏̆͒͛̓̂̏̒͐̆̃̅̂̒͛͗̃͋̌́̐͊͗̉̈́͋̉́͐̂̐͑͋͊̈́̃̎̏̈́̽̈́̌͒̔̓̓͋́̋́̈͒̿̎̀̈́̑̉̋̆̽̐̅́̈́̑͆̒̐̌͋̉̀̌̽̿͗̆̓̓͑̔̀̄̊͆̐̐̀͌́͊̎͛́̑̐̄́̈́́͑̋͑̓̽͆̆̈́̃̍͆̃̚͘̚͘̚̕͘̕͘͘̚̕̚͜͜͜͝͝͝͝͝͝͝͝͝͠͝͝͝ͅẖ̴̡̨̧̨̨̛͍̫̘̱͎͉̻͍̻̯̝̻̱͇̜̮̠͔͈̱͇͕̗̩̩̬̺͉͖̫͈͚͔̠̥̗̳͚̟̝̥̟̳̯̝̤̤͊̿̓̒͂̇͋̏̾̓̿̿̏̎̑͑̑͋̈́̊͂̌͒̈́̓̇̾̍̑͐͐̀̓͋̔͂̈́̄͐̃́̉̆̑͑̉͗̂̌̈͒͘͘͘͘͜͝͝͠͠͝e̷̩̖͎̟̬͓̭̼̖̟͎̘̔͋͋͗̉̍̽͆̅͒̂̍̂̅̾͐̂͆́͌̇̿͒̽͑͑̏̎̑͌̏̀̅́̓̓̃̍̊̔̎̈́̆̏̆͛͆̎̓́̃͋̏̀̑̏͒̄̈́͌̄̐̽̽͊̎̈́́̂̂̎͒̌̽́͋̇̋̈́͗͋̂̏̋̚͘̕͘͘͠͝͝͠͝͠͝͠͝r̸̨̢̢̧̢̡̡̢̢̡̡̨̢̡̛̛̘̘̼͕͎͓̯̞̥͚̦͙͇͍̦̫̮̻̭̪̥̗̝̱͉͎̘̩͙̼̗̪̣͇̜̩̠̻̼͓͙͎̙͖̯͖͖͕͎̺͕̯̯̬͉̳̜̰̱̺̭͉̲̭̹͇̳͓͖̦̮̙̥͚̤̩̖͚̮̺͉̟͖̦̠͍̙̥̤̲̳̲̗̱̜̰̲̖̝͕̯̹̤̦̯̞͍͓̭͓̘̳̪̠̭͙̳͍͕̹̬̭̞͎̜̦̱̖̠̤͖̞̥̦̖̞̬̣͕͎͇̺͚͙̮̻̭̟̬̖̣̰̣̬̣̬̮͎̟̫̠̺̙͎̟͙̤̥̫̺̺̙̮͕͕̩͓͐̔̎̿͛̈́̓̊͋̈͂̆̍͒̃̀͐̇̈́̀̉́͋̃́̍͛̀̃́̾̊̏̌̉̇̾̈́̓̓͋̒̀̈̔̈́̀́̈́̈́͆͒̅̆͌̑̐̔̀͌̈̄́̑̎̃͋͊̅̾̓̓̔̃̕͘̕͘͜͜͜͜͝͝͝͝͝͝͠ͅͅͅͅͅͅͅͅę̵̡̨̡̡̨̨̧̧̨̛̛̛̛̛̛͓̠̗̹̭̣͙̹͇̥̯͔͉͈̪̫̩͈̦̩͕͎̖̫͙̠̝̤͓̲̞̪̜͎̬͇̠̺̳̬̠̞̮̜̘̗̺̲̼̥͍̱͓̞̝̞͔̘͚̗̱͍̞̬̠͉͉̱͖̥͎͙̞̫̺̮̣̳͓͚̰̪̫̗̱͉̫͙̻͉͔͈͇̹̭̬̣̰̫̤̼̱̟͆̓̽̊͑̾̍̈́̂͒̏̓̈́̆̋͐̈́̿͋̄͊̉̈̀̔̂̈́̄̿̎̏̈́̈̓̅̊͗͒̅̌̀͗̽͂͑̀̍̇̌̊̓͑͛̂̽̔̀̊̍̈̇̀͆͂̏̃̉̉͊̔̈́͊̋̂̂̃͑͋̓͋͋̎̓̈̽̊̏͐̽͊̂̉̽̌̀̔̋̎͗̄̉̔̈́̿̊̅̈́̐̆̂̄͗̽́̈́̎̔́͐̾̇̎̐͛̎̅̾́͆͆͌̓̂̊̆̇̅͐̇̏̈́̏͋̽̊̿̾̏̈́̈́̾̈͋͛̒͂͑̍̒̄̋̾̈́̐͑͌̿̒̅̑̊̒̈́͆̔̿̾̍̈̀̓̂́̃̀̄̔̆͗̆͗̃͌͒́̎̿́̿͂̿̓̑̓̓̈́̌̈̈́͂͛̒͒̏̈́̈́̆̓́̍̚͘̕̚͘͘̚͘̚̚̚̕͘̚̚̕͘͜͜͜͜͠͝͝͝͝͝͠͝͝͝͠͝͠͠͝͝͝͝͝͠͝͝͝ͅ ̴̧̧̢̨̧̡̡̨̧̧̨̡̡̛̛̛̛̛̛̛̩̪̠͈̞̘̼̰̼̭̙̖̯̬̭̝̠͇̯̩̠̙̣͈̜̖̱̺̱͙̝̱͙͖̫͔̗̞̭̹͉̜͚̞̤̣͉̙͚̟̹̜̱͕̜̺̱̯̹̙̦̻̣̦̤͖̞̭͍̫̙̺̯̼͔̼̩̥͉̺͉͉̯̘̖̠̤̬͉̬̣̙̘̮̘̙̟͉͇̼͇͎̠̠̩͉̼͇̤̲͓̞͓̣̼̫̻͎̩̜̠̺̹͎̯͚̼̻̖̱̥̇̒͑̀͌͋̀̍̆̐̓̓͐̌̓̓͌̏̃̌̓̽͑̏̈̽̓̍̓̈́͊̏͗̅̆̌̅̂̈́̍̉̌͊̏̀̉͗̒̀̌̒̒͊͑͆͊̈́̓̂̈́̈́́̐̀̃̈́́̽̊̉̄̀̌́̊͋͑̿́̀̐̈͌͂͆̓͂̓͊͐̿̄̔̑̀̋̅̃́̈́̐̈̔͛̂̓̔͂̅͒͐̉̎̓̒̈́͑͒̃͌̊̃̄̓́̈́̽̀̆̅̾͆̋̀́̒̒̄͂͆̇́̍̈́͗͑̔͊̆̆̒͌̽̀̈́̽͑̃͌͑̆̏̔̔͌̿̋̉̆̊̐̏̃͘͘͘͘̕͘͘̚̚̕̕̕͘̚̕͜͝͝͝͝͝͝͠͝͝͝͝͝͠ͅͅͅͅͅͅȃ̵̡̢̧̧̧̡̡̢̧̧̨̧̧̢̨̢̛̦̣͖͎̠̗̪̱̪͙̜̯̩̲̟̠̗̪̤͕̤̳̤̙͉̦͍̮͙͔̪̯̙̝̩̗͍͕͔͖̗͎̦̹̲̦̦̮͖͙̞̞̝̘̤̗͎̣̖͉͇̠̪̰̗̣͚̲̺̯̹̣̻͔̞̮̝̳͓͉͍͕̲̻͚̞̯̳̤͙̱̥͕̙̝͖̥͍̰̜͕̱̺̬̰̪̹͓̥̲̠̠̤̣̺̥͇̹̠̹̞͕̻̱̳̜͔͎̟̝͕̭͕̦̖̬̠͍̥͉͎̪̲̝͎͔̺̹̭͈̟̱̤͉̤̹̺̙̣̙̗̠̗̣̮͖͓̤̩͎̱̯͕̝͓͖͈̥̝͚͔̺̻͕͎͚̺͉̠͍̘̟̘͙̉̂̌̈́͑͑̅̈͛͆̊͛̔̿͗̂̈́̆̂̔̀̓͑̽̋̎̉̓͌̊̇́̈̽̓̀̄̄́̐̅̍̽́͒́̂̋̂́͌̿́͗̐͛̓̒̇̌͌̂͘̚͘͜͜͜͜͜͜͠͝͝͝͝͠ͅͅͅͅͅͅͅm̷̡̨̨̡̨̡̧̢̡̢̢̛̲̣̬͓̫͔̞̠̩̞͚̠̘̤̹̪͚̹̙͖̰̰̼̪͔̤̼͚̱̠̜̜̝̖̤̣̝͓͚̘͕̭̫͔̤̭͇̮̳͚̗͖̞̟̤̜̳͇̦̥̥̗̼̱̞̟̼͙̹̬̟̫͉̱͖̘͖͕̜̻͈͈̬͉̹̩̻̪̪͎̮̳͎̝̝̤̟͓̹̫̠͖͎͔̭̈̎̃̀̃̀̍͑̅̀͆̓̍̋̅̉̔́̀̿́̒̃̔̓͂́̏̉͑̂́̔́͌̓̐̃̂̇̅͐͆̽͋̉̏͂̓͂̎̈͊̅̑̿̈́͘̕͘͜͜͜͜͝͠͝͝͝ͅͅͅ ̵̢̨̧̢̧̢̢̡̨̧̧̡̨̨̧̭͈͓̜̩̞̭͓̩͖͔̺̬̭͍̺͕̺̺̳̹̺̯͈̤̼͍̘̪̖̱͍͇̘̭̯̥̙̠̠͉͉͖̗̜̟͎͚̩̙̙͔͖̹̤͚͕̻̩̭̘̱̱͉͓͚̜͇̺̝̬̳͔̠̻͓̺͈̭̬̳͔̝̪͇͙̣̲̞̻̱̮̠̱̝͖̆́͋̉͌̚͜͜ͅͅͅͅͅͅͅͅi̷̡̨̢̧̢̧̧̨̡̨̢̡̨̨̨̢̡̢̧̢̨̢̡͇̜̰̻̼̖͈͙̰̲̼͍̟̠̱̰̪̲̝͍̩͚̯̱͓͍̙͈͎̤̜̬̺͍̘͚͇̦͍̠̹̯̬̜̼̬̯͇̖͔̺̜̰̥͕͔̻̞̙͓͎̱̣̟̱̮͎͖͔̜͚̱͕̖̤̻̺̯̞̥̦͍͓̩̹̲̲̤͙̱̞͈̥̤̫͔͖̘̯̻̼͚̩̳͖̳̙̰̪̘͕̻͍͕̬̖̗̖̭̝͍͇͓͖͙̹͙̭̠̙͓̻̗͚̘̯̙̘̟̰̩̝̭̺̠̺͕̙̳̙͉̖̮̱͙̖̮̖̺͎̖̬̬̩̰̩̰̪̣̳̜͎̪͎͕̟̣̩̯̠̜̙͇̝̣̰̲̳̙̹̺̤̲̝͕̖̹͖̲̩̬̻̭͉̲͈͈̤̤̐̍͂͋̄̓̄͛̽͗̄̓̓̌͌̑̈́̍̓̍̽̔̽̄͊̓̍̀͌̌̔̈́̀͒̊͗́͋͗͊̀́̋͆̈́̃͋̂͊͊̍͛́̑̏̄͛̓̌̂̐̏̃͗͛̎͗̉̍́̉̉̆̂͛̈̐͂̈́̄͗̔̏͋̀̏͑́̀̀́̍͑̋͒͑̎̋̿̎̍̿̐̎̋̿͂̈͌̾͑̏͆̅̕̕͘̚͘͜͜͜͜͜͝͝͝͝͝͠͝͝͝͝͝͝ͅͅͅͅͅͅ.̵̨̢̨͎͇͖̥͈̼̳̯͙͉̱̩̟͖̫̜͎̪̜̗͖͕͇͚͎̙̳̙̥̺̜̖̹̥̪̜̝͉̭̘̋̓̂̕͜.̸̨̡̢̢̢̡̡̡̧̧̡̢̡̡̛̛̛̛̛̛̛̛̛͉̬̤͔̳͎͕͔̘͕̳͕̫͔͖̙̖̠̼̗̬̝̱̫̺͔̝̟͎̪̦̫͍͔͈̤̬͕͇̻̹̜̹̥̳̳̫̻̥̦̺̪̗̮̻̮̥͖̣̘̩̯̞̪̳̟̹̱͎̮͕͔͖̲̗̺͇̭̘̜̳̼̹̝̖̼̘͚̲̤͇̮͉̭͚̮̪̭̱̲̟̞̪͎̲̻̲̯̰̠̹̠̻͉̝͓̩͖̥͎̞̤̭͔͕͕͕͉̘͉̱̲̥͓͕͎̬͉̫͔̘͎͉̣͚̪̪̲̩̲̩͇̙̮͔͍̱̥̝̩̙͎͎̲̬̝̭͙̪͎̣̍̈́̐͐̾̀̌̔̈́̐͂͒́͂̍͆̆̈́̍͐̈́̊͊͂̇͗̓̎̀̈̄̑̂͛́͊͊̌̔͐̄͌̅̎̓͒͒͑̆̔́͋̑̂̀̀̂̑͋̑͐͌̓͂̅̒̈́̿̑̐̆̒̋̈̇́͆͗̌͆̎́̍͆̂̏͛̈̈́̓̈́̄͒̀̂̇̅́̅͐̍̃̋̈͆̅͐͌̈́͑̉̌̇̓͌̏̌͆̋̿͂̔̌̏̿̌̀̌̿̀̑̏̋̿̓̅́̈͌͐̓͆̊̀̇͐̑͗̎͂͂͛̄̿̋́̑͗͑́̓͐̂̆̀́̒̓̍̂͊̑̐̔̈́̄̎̀̒͌͗̏̇́͌̐̀̿̌̄̎̐̈͐̐̈́̐̉̏̀̉̊͊͑̑͌̎̉̃̿͘̚̕̕͘͘̚̕͘̕͘̚͘̕͘̚̚̕̚͜͜͠͝͝͝͠͝͝͠͝͠͝͠͝͝͝͝͠ͅͅͅͅͅ.̶̨̧̧̢̡̛̛̯̼̳͍̮͖̳̮̥͉̼̖͓͕͔̻̖͍͍̲̦̟̹̲̱͎͕͍͈͚̞̦̘̮̻͈̬͇̥̣̙͙͈̝͔͙̜̫͓̤͎̺̠̤̙̯̗̝̘͎̣̜̗̜͙̯̑́̊̈́́̽̒̓̊͌̀̌̃̓̎̓̄̈́̌̀̌͂̎̆̅͂̅̿͂͊́́̉͐̔͐̅̈́̈́̀̿͆̌̐͛̓̽̃̂̑̊̂͋̋͋̐̆̿̓̅̾̔̂͌̍͗̉̊͂̿́̐̾̏̾̿̈́͂̀͐̌̊͆͑̋̈́̿͊͆̚̕͜͜͝͝͝͝͝ͅ");
        Glitch.Add("D̴̗̿̃̚a̵̩̤͚̖͌̓̌́̄̎̕y̷̥͇̠͉͙͇̎̄̄̔̾̔̽ ̷̧̢̱̥͚̺͛͊͗͛͆̚ͅ3̶͍͍̜̺̘̮͈̝̝͖̘͕͋̀̊͐̀2̴͇̈́̋̑̑́̄̔̑̌̒́̕̕6̸̙͓͈̞̞̭́̽̅̈́̂͗̾ͅ,̶̨̤̙̠̲̼͈̔̐ ̴̨͗̈́̐̏̈́̓̂͒̾͑͘I̴͍̝͈̭̻̗͚̺̜̓͝ͅ ̵̧̨͍̳̮̮͇̮̻̩͍͕̬̿͛̀́̊̄̾͐̽͝c̷̢̨̧̱̼̰͌́͋̿͝a̴͎͛̔͑͛̂͑̍̓̊͗̌͝n̷̰̻͖̲͍̹̦͎͐̔̐̿̎̀'̷̡̃̂t̷̡̢̨̯̖͔̼̬͛̏̋͜ ̸̹̊e̴̦̙̿̐̓͑v̷̼̎̐̃̈́̇ȩ̶̞̦̣͙̝͕̜̋̂́̾̿̆̃̊̕ͅͅn̸̜̖̩͕̖̜̖̮͊͆̈́͌͋͆̊̂ͅ ̶̙̣̥͖͍̙̘̜̳͈̈́͛̽̀̿͒̽́́̽͝r̸̨̙̺͕̮͓̺̅̇̋͑̽͌̇̾͌̊̕͜ę̸͉̹̼̈́̿̒͊̔̈̌͐͌̕̕̚͜͝m̴̨̧͕̣͉̟̰̖̭̱̝̫̈́̈́̀̂͋̏̈̎̀ę̴̪̤̝̼͎̬̘̙̜̫̎m̴̡̝̹͂͑b̶̺̬̠̱̜̐e̴͈̣͕̦̜̦͈̙̜̬̹͑̋̏̊̓̐̓̐͒͘ͅr̵̡̄̉͊̅͒͐ ̷͉̃̂͒͐̓̽̽̑͌̔̿̅w̶̤͙̝̗̺͔͆́͐̒̈́̅̋̂̕̚͝͝h̶̩̄̄̑̏̀̿̏̅̅̐͛͘a̵̛͇̼̥̮̟͗͋ṱ̴̘̝͎̣̫̀̂͘ ̶̧̯̠͍̮͉͔̣̳̌ḩ̵͔̤̘̯̎̌̅̽͛́o̶͓̓͐̏͐̈͛̓̂͂̕͠m̵̡͉̝̖̩̥͚̟̤̤̲̻͂͗̿e̷̢̛̛̟̹͕͉̟̅͗̈̀̿̂̉̿͠͝ ̶̢̛̠̠̳͇͚͍̖͈̋̓́̓͝͝ͅl̸̛̮͝ó̶͈͔͔̺̳̝͚̤̌́͂̓̇͊̿̏̅o̵͖͙̣͖̎̄̃̊͂̚̕ḵ̸͉̓ͅs̶̨̟̹̞̏̅̏͑̈́͗̊̇̊̏̔͘͜ ̵̡̛͙̖̥͔̖̖͈̤̦̃l̵̡̛̖̝͆̄̿̈́̈̃̿̑̈́î̷͇̪͓͍̻͚̺̅͒͑̅̀́́̏̃́k̵̛̗̩͎̙̜̤̘͍̰̯͌̑̑̆̚͜ȅ̶̯̣̜͍̺͖̥̟̘̘̪̯̓́̉̃ ̴̡̤͙͔̙͚̤͎͂̊a̸̧̡͕̙̗͔̖̺͆͛ǹ̴̻̲̙̻̺̹̳͍̠͍̺̣͂͂̅͜͝y̶̧͈͈̮̦̥͖̖̻̦̟̗͒̽̒̀̌͊̈̿̾̏̓̕̕ͅḿ̴̼͚̹̥̤͔o̶͎͕͐̀͊͑̆̋́͊͛͠͝r̵̡̧̨͔̘̟̖͑͗͛e̶͉̠͎̣͕̟͉̙̺̐͜.̵̭̙͔̜̻̼̔̄̏͐̒̍̿̓͘ ̵̧͍̙͍̫̈́͋͗̾ͅį̷̟̯̭̜̖͛͊̈́̃̑͝͝ͅt̵̟̪͈̰̬̙͈̬̓̔͐̇s̷̨͖̝̺̪̼͕͖̬̭͑́̍ ̷͎̗̥͈̬̼̓̃̑̎̎͋ͅs̴̨̭̤̠͓͆̓̓͛͆̉̎̔̒̊͠ó̸̧͕̹̱̬̣͎̟͍͠ ̸̢̲͚̬͍̗̟̖̰̐́̆̀͌̋̉̂̃̈́̏̍͘ͅc̴̘̖̽ò̴͉͇̬̙̩̳̤̲̩͗̀͒̽͘͝l̸̡̝͇̼̩̩͇̩̘̘͓͕͌͗̈́͑̍͛͛͋͆̐͝ͅd̸̜̞͇̬̬͚̩̾́̂͑̂́̐̒.̷̭̻̟̒͠ ̴̪̗̥̫̙͓̘̬̓͐̑͐̏͌́̒̔̓͑̍̾ȋ̴̩̞͑͂͋̀̔́'̶̮̠͚͉͖͎̜̦͎̉͋̉͐͆̿̈́̈͆m̵̯̞̓͗͂͂̋ ̴̥͈̽́͊̎̓̈͊̿̎̓ş̴̪̮̹̼͉̝̬̋̈́̒̽̾̓͜͠ớ̴̫̠̙̑́́͐̎̇́̋ ̶̨͚̳͚̮̤͇͚̥̙́͊̿̈̿̓̇̎̚ͅḩ̵̡̲̈̅̇͒͗̓̍͐̈́͊̄ú̶̧̧̧̡̢͕̦̲͎̮͛͜͝ń̸͖̰̼͕̹̝̋g̵̨̼̼̱̜̣͕̳̓͒̈́̈́͒̎͋̕͝͝ŗ̶͓̩͔͈̲̱̼̫̣̎̀̒͐y̴̠̩̙̽̕.̵̧̯̤̦̰̦̟̿ ̴̹̱͗͗͒̃i̴̧̝̦̟͙͚̦͌́̆̿̋̆̂͊̑ ̸̝̯̲͕͆̿͋d̸̻̾̐̿o̶͙̓̐͘n̷̫̕t̵͕͉͎̻̣̟͇̦̤̗̽̈́̅̌̊͜͝ ̷̜̥̞͖͎̖̞͈̣͆̍͜͠k̸̢͚̩̺̀͗̋n̶̳̝̱͈͛ò̶̧̻̟̖̖̬̏͌̌͠ẘ̸̹͒͛̋ ̷͖̰͓̱͎͔̜̏̈́̄̈́͌̈́͜͜͠͠ͅͅi̷̬̞̲͔̤͗̏̑̇͗̾̐͜f̸̡̳̣̟̺̟͔̪̠̩̺̳̒̒̆̄͊́̆̀̉͆̐͘͠ ̴̫̺̈́̂̀̇̅͑̎̉͗͘͜͜i̴̧̮̳͔̫̱̖̟̞̺̘͉̩͗͐́̽̊̚̕͝ ̸̩̦̫͈̔ç̵̡̹̞̖̯̦̓̈́̃̒̐̐̿̃̇̃̔͊̚ą̸̳̼̺̠̣̰̣̣̦̑̎͆̑̂̑n̵̖͈̘͈̦̪̦̏͌̇͊ ̶̳̳̘̺̺̪̺̞̙̮̞̎͜t̸͍̹͔̮̊́͂̀̕a̸̝̞̦̖͗̀̓k̶̡̝̦͍͉͖͇̿͐̑̎̇̓̅̑͛̏̈́͝e̷͈̥̎͒̿͘ ̵͔̫̽͌̎̍͌͘͜t̷̥̞͈̬͙̰̩̳͔̣̹̒̐̌͌͛̏́̑͛͒̀ḧ̴̥̹̟̟͇̣̗́̃̋̃̄͐̚i̸̛̬͖͖̙͖̪͔̳̠̤͙̐̓̎̀̔͗̿̏͑͘͝ͅs̵̡̛̲͔͓̞͓̼̪͊ ̴̛͍̖̈́͑̈́̅̎͆̉̓̐ȃ̵̬̝̟̳̪̰̖̺̫͖̣̺͎́̔͘n̸̡͔̤̞͚͈̠̬̗̳̙̉̃́̐̅̿̐̑̇͂̈́̚͠y̷̖̽͑̍̓̄͋̔͌̈͘m̵̩͉̥̭̀̉͂̅́ȏ̴̱ȓ̴͕̜̪̠̾ȩ̸̟̮̳̝͙͍͎̇͌̀̽͊̈.̶͎̒̒͌̒̚");
        Glitch.Add("Ḑ̴̢̨̧̭̯͓̳̫̠͎̦̱͕̖̰̺̹̦̣̘̘͉͚̻̦͉̖͈̠̤̥̟̭̳̺̝̣͚̙̟̲̫̯̬̭̲̒̎̎̃̋̾̆̋́̄̀̀̿͒̾̽̃̊̉̀̀̇̑͑͌́̀̓̐̓̿̔̑̔̿͋́̆̓̒́̇͑͆͛̀̅̈̊̈́̒̃̀͋̋̄̎̋̓̄̎̍̌̿̃̉͒̏̏͒͆̌̈̊͒̾̆̎͆̇̒̑̌̓̆̑̄̃͊̓̔̃͌̔̒͂̓͘̚͘̕̕͘͘͘̕̕͘͝͠͝͝a̸̡̧̧̨̧̧̢̨̧̢̨̡̧̛̙̠̥̹̯͔͙̩͕̟͖͈̬͎͎̻̟̹̳͙̪͎̥̹̬̜̼͎̺̬̺̬̟̘͔̥̖͖̳̥̱͈̰̤̣̫̟̟̹̩̟̜̗̱̭̗̱̣̞̬̖̖͇̞̮̝͙̰̣̗͍͔͉͇̞̤̖̞̫̖͓̻̥̰͓̤̜̺̫̖̬̺̺̺̩̰͇͚̾͒̐͗́̂͐̇͆͑̏͂̍̎̀͊͒̀͆̃͐̐̈́̽̈̈́̓͋̇̐̐͑͒̓̄̀͒͆͒͒̈̈́̓̆̿̅͊̇̋͆̄̉̂͂̽͛́̊̔̅͐͐̊̿̾̔̀́̓̓̇̄̉̋̈̑̓̓͌̃̀͒͌́͑̏̊̎̄̊͊̂̇͛̀͂̓̕̕̚̚̕̕̚͘͜͜͝͝͝͝͝͝ͅͅͅͅỵ̷̡̢̢̨̡̧̡̨̨̧̨̨̧̡̧̢̧̛̛̛̛̛̭͖͕͉͙̘̺̟͖̟̣͇͖̹̘̖̮̭͉̫͔̬̫̗͇̣̮̺̰͈̺̘̘̻̘̣͚̠͙̜͇̮̼̣̭̙̻͖̜̣̼͎̹̱̙͍̲̞̜̞͇̰̖̜͉͔̰͍̗̫̟̟̫̘̭̳̩͖͚̬̱̳̺̙͍̺̠̘͇͕̠͈̖͖̣̰̭̪̱̤̺̼͉̠̤̲̦̖̖͎͓̼͕̳̰̥̖̼̝̘̬̤̣̥̬̯̪͙̯͎͖̔́̀͛͂́͆͛̂̇̈́̆͂̒́́̊͐̃̒̈́̀́̿͒̒͗̃̐́͗͐̓̌̈̃̄̆̌̔̃̈́̇̐̊͊̇͋̄̇͊̇͐̎́͋̀͊͌̈̀̈́͛̒̈́̌̈́̀̀́̏͒̔͊̌̀̎͆̄͑͆̈̈́̍̐̈́́̆͆̆̿͗́̆̎̊͂̀̿̅̃̄͆̐̌̄͋͑͗͋͊̇̔͆̑͋͊̎͌͆̄͊̔̆͊̄̑̈́̈̌̈́̃̏̌͘͘͘͘̚͘̕͜͜͜͝͝͝͝͝͠͝ͅͅͅͅͅ ̶̡̧̧̢̢̡̧̧̧̢̛̛̙̤̝̲̦̤̙̮̼̻̥̥͖̳̦͔̤͎̯̦̠̰̠͚̭̲̹̘͓̮̪͇̘̹̗̙̦̗̘̲̖̮̤͍̙̦̭̖̥̪̠̻̼̣̩͙̟͇̦̩͔̲̺̻̠͔͙̭͉̰̥̱̪̟͍͇̣͓͉̣̹̞̯͔̹̫͔͍̝͓̪̠͓͎̰̯͎̫̗͇͉̬̯͖̳̻̬̝̖̣̖̘͎̪̱̜͙̼̲̰̟̤͎̳͔̤̳̲̱̻͎̖̠̹͚̘̞̯̱̒̔̎̿͐̃̽̏́̋̋̉͂̿͊̒̎̃̒͂̀̃̌̏̅͗̈́̉̈́̒̈́͆̃̏̈̽͐̑̆̓̄͋̅͋̓̍̐̿̓͋̽̅̈́͊̓͌̓̔̿̒̅͋̇͗̈̐͒̅́͑͑͐̃̈̑̑̌͊̏͆͌͌͐̈́̀̈̉̈́͂̓̉̉͋̊̚̚̕̕̚̕͜͜͜͜͠͝͝ͅ5̵̡̛̛̛̻̦͔̲͔͓̲̐̆͒̀͋̄̇̈̿̉͑͋̒͛̄̈́͑͗̈́̓̈́̽̔͗͌͒̍̌͋̃́̈́͗́̈́̆̀̋͗͂͌̇̈́͛̉̂͆͌̿́̄̃̽̅̄́̍́̓͆͗͐̽͊̀̄́̒̄̅͛̍͑͊̀̏͌͋̇͗̓̾̓͆̓͗̍̂̆͒̋̐͗̈́̒̔̅̿͆̈́̿̔̈̏̾̊̅̔̈́͋́͒̋͋́̋̀̎̆̋̅̎̆̌́̓̀͘̚̕͘̕͘̕̚͘̕͘̕͠͠͝͝͝͝͠͝͝͝͠,̷̢̢̛̛̛̮̥̣̫̻̲̖͕̪͔͇̺̪̩̥̻͇̣̤̝̖͈̺̪̏̎̑̀̎͐̉͌̔̿͊͆̍̃̌̋͑̃͌̄̿̏̀́̍͆̓̃̎̑̋̑̉͐̅̈́̐̅̈́́̊̊̽̓̍̋̈́̅́͂̇̔̓̋̃̃̄͆̆̎͐͐̅̂͑͒͊͒͐̊̌͗̈̚̕͘̚͘̚͘̕͠͠͝͝͝͝ͅ ̴̧̨̡̡̡̡̧̢̡̧̢̢̨̮̦͉̝̰̩͓͕͍͔̻̳̰̱͚̬̖͔̠̱͈̠͎̳̞̘̘̞̻͕̭͈̫̪̩̣̞͈̞͓͓͖̝̲̳̤̥̮͈̫̞̬͙̪̺̦̰̘̙͉̭͓̞̝̭̗͕͈͇̺̲̮̗͖̘̑͆̒͐̋͆̋̾̑̍̈̑̽̆̓̈́̋̊͆̊̑̇́͊̉͑̐͗̓̉̽̄̔̀̏͂̉͂̋̒́̔̓͛̀̒̊̑̀̄̄͂̈̈́̅̄̉͗͌̂̈́̓́͌̈́̓̈́̔̓̈͛̂̀͒͆͆́̑͒̽̏̆̎̍̋̒́̒̏͗̈̿̈́́̈́̐̄͛̅̌̄͊͗̅̈́͊́̐̀̕̕͜͜͠͝͝͠͝͝͝͝i̸̡̨̡̢̡̡̧̛̛̟̤̦͇̩̖͈̩͕̭͉̣̻̮̠͔̖͉͙͙̳̟̩̙̱̹̯̻̲̻͔̯̗̙̬͚̟̫̼̟̩̦̲͉̺̤̩̥͔̊͗̈́͆̍̎̓̿͊̽̆̔͊̍̐́͒́̈́̉̔͑͑̃̄͛̀̑̒̔́͗͑̋̾́̎̾̽̈͌͐̉̉̂̓̀̍́̒͛̂̎͒̆́̇̐̋͐̽̓͋̄̌͒̈́͑͆̊͊̀̊͒̃̑̒̈́̽͑̒͛̇́͆͊̈́̈́̈̉͊͆̈́̔̓̊̿̃̀̽͗͋̓̈́͛́̋̍̔̑͗́̔́̏̐̇̋́̿̕̕͘͘̚̕̚͜͜͜͜͝͝͝͝͝͝͝͠ͅ'̷̧̡̨̧̧̡̢̢̨̛̛̛̭̩̤͙͚̤̫͚͕̬͕̝̼̤̲̙̺̲̳̣͎̤̻̹̳͈̝̰̯̙̝̺̻̭̱̘̰̱͉͓̳̼͇̠͔̳̰͔̟̩̣͇̙͕̖̟̤̲̬̰̗̥̮̼͇̟͍̥͈̩̬͖͚̤̼͉͕̘̻̦͖̱̞̪̹͚̄̎̆͋̀̋̊̾̀̉͗̀̄̃͒͐͌̌̅̓͒̔̈́̀̽̓̐̎̏͑̏̇̽̒̽͂́̔͛̊̌̾̽̈̆́̿͐̈́̓͐̒̄̂̏̽̎̓̓̈́́͒̃̆̌͂̄̇̑̉͌̍͐͆͑́͛̍̈́͐̾̓̀̀̾̽͑̾̚̚̕͜͜͠͝͠͝͝͝͝ͅͅv̸̨̢̛̛̛͈̮̺̠̗̭̲̳͕͕̟̦́̒̈́̔̀͐̍̃̀̎͒̎̽̌̈́̂̂̇̆͊̔̏͊̍̈́̄́͛̽͐͂͆͗̑̽̑̑͛̅͆̾̍̈̃̀̾̆̀̈́̅̉̑̉̾̿͛̐̀̇̀̃͐͛̌̈́̓͐̾͑́́̓̆͂̐͐̄̊́̀͘̕̚̕̚͘̕͘͜͝͝͝ͅe̶̡̡̨̢̧̨̡̢̢̨̡̨̢̧̨̧̡̡̧̨̧̧̨̡̧̛̛̬̤͚̻͚̹̮̣̝͉̤̳͚͓̦̪̖̖̼̪̯̬͓̠͖̩͇̙̻̪̪̫̦̦͍͍̺̭̳̳̝̭͉̩̮̜͍̬̞̲̥͇̣̞̳̫̭̘̬̩̠͇͉̺̙̦̤̟̺͖̗̟͖͇͕͖̩̩̦̯̪̲͙͚̦̯̬̗̦̰͖̩͇̪̤̠͈̰̭̳̖̖̜͇̳̪̺̣̜̣̝̖̱̪̞̜̱̘͎͓̺̗͚̫͖̘̲̩̯̦̭̱̺͓͖̝͈̫̰͖͚̊͂͆̿̾̄̌̂̉̈̇͊͂̌̃̀͂͐̉̓̓͆͂̇̍̈́͌͂̈́̒̈́̆̿̒̈́̈́̄̀̉̒̏͆͊̐̃͑̿̉̋̂̉̋͋̂̎͂̓̄̅̇̽̈́̈́̉͊̀̒̏̓̉̍͌̌̋̅͂̌̅̀̿̽̋̽̓͗̋̂͛͑̄̔̿̽͗́̄̅̀̒̊̐̐̂̔̀͗̒̋́̈́̄̀̀̔̄͒̓̀͘̚͘͘̚͘͘͜͜͠͠͝͝͝͝ ̴̢̢̡̨̨̧̨̡̛̤̳͖͎̙̹͍̞̱͙̙̜͇̯̜̭͈̙̭̼̼͎̘̰̹͖̣̫̬͔̥̼̺̲̩͔̲͓̰̣͎̻̰̪̖̺̺͕̼̝͖͇̹̹̣̪̱̠͍͎̼̝̾̅̀̇̓̑̈́̃̋͌͆͊̀͑̋͋̂͐̈́̈͐̋̿̀̍͛̈́̈̐̈̑͌̇͐̀̇̋̈̃̀̃̒͂̅̀̎̉͘͠͝͠͠͝͝ͅͅd̴̠̬̖͕̞̯͖̠̗͈̠̝̬̜̜̻̟̣͈̮̟̲̥̫̻̱͙̟̹̻̺̺̬̙͊̈́́̽̌̆̌̊̾͛̀̇̓̎̾̿͌͋́͑̈́̈͆̂̈́̍̑͗̀̀̌̇̑͌͒͊͐͋̈́̃̒̀̾̐̊̀͆̀͋̎̆̋̑̆͂͛̓̉̀̈̃͆̈́̀͆̀̔́́̈́̔̓͒̔̑͑̈́̃͒͛̈́͛̊̌̅̇̈́̑́̏̒͌͑́̄̾̈́̀̔̌̀͐̽̂͌̿̓͒̄̔̒͒͒̒̋͛̎͑̃́̐̀͌̈́̑̅̈̀́̓̎̃̄̅̈́̎͗͘̚͘̚̚̕̕͘̚͘͘̕̕̚͜͜͜͝͠͝͝͝͠͝ͅe̸̡̢̢̧̧̧̨̨̨̧̨̡̡̢̨̛̛̛̛̛̩̻̝͙̻̖̬̮̝͍͍̥̝̱̤̹̬͙̰̯̗̪͚̻̬͚̖̗̮̬͖̥̱͓͍͔̖͖͈͔̟̩͕̙̯͔̞̙͚̙̲͙̱̲̰̞̼͙̝̺̱̞̖̫̥̝̦͖͇̦̫̗̜̞̠̜̣͕̱̣̠̪̙̱͓͉̟̥̖̘̗̞̜͕̥͉͚͙͕̺͍̙̮̬̳̫̫̲̙͉̺̯͇̭͎̖͚̿̽̂̎̏̔̾̐̉͐̋̈͆̑̎͒̾͋̇̈́̄̑̊̀͐̓̈͂̓̓͑̓̍̏̅́̈̓̆̃̈̊̋͑̄̋̈́͊̅̍̔͗͒̿̐͊̂̅̀̓̽̉͆̀͂̽̎̾̿̃̎̊̉̆͊͒͗̀͐́̈́̔͗̅͊̈́̏̌̀͆̀́͑͑̃̉̐̈͆̋̂̇̊̀̀̒̃̾̕̕͘̕̕̚̚͘͜͜͜͜͜͜͜͠͝͠͝͠ͅͅͅͅc̵̢̧̨̢̨̢̧̢̢̨̨̨̛͓̯͍̰͎̣͔̹̠̟̦̫̯͖̻̝̺̫̼̼̬̫̙͎̹̩̫͔̪̮͉̙̹̲̫͖̻̼͙͎͓̬͓̮͓̠͓̪̰̠͈̦͓̮̟̥̦̬͔̣͇̳̯̬͖̞͉͈̘͈̗͇̱̬̲̩̠̟̻͇̝̳͖̭̖͈̺͕̺̙̠͙͇̻̰̻̰̺̭̯̤͈̯̬͍͔̙͓͎͔̖͙͈͎͚̘̰̖̭̱̲͓̫̦̾͒͂̓͛͊͛͂͌͆̓̎̌̂̈́̏̍̔́̉̆́̂̀̈́̈̈́̋͒̽̈̈́̐̋̊͐̓̏̈́̌̆̀̎̓̂̀͗̍́́͊̓̅͗́̐͒̀͐̏͑͗͂́̋̏͑̅͆̈́̑̿̅̍͂̓̆̏̽͛̎̌̑̎̃͐͆͒̏̉͊́̽̐̋̐̓̌́̐͒̑̊̊͋̎̈́͑͌̋̎͆̈́̌̓̌͒̏̑̽́͂͘̕͘͘̚͘͘̕̚͘͘͜͜͜͝͝͠͠͠͝ͅͅͅͅͅͅi̴̧̨̢̢̧̢̨̧̧̨̨̛̛̛͕͚͎͖͈̣͉͎̩̱̜̱̩̪̳̳͔̭͈̼̻̱͔̝̞̱͙̪̞̪͇̤̝̻̪̺͕̱̫̮̟̘̗͙̮͕͉͈̠̰͖̱͍̭̙̘̭̪̰̮͙͎̟͉̫͈̪͓̝̮̞̼͈͇̣̠̳͇̖̦̭͎̱̳͍̝̠͚̮̱̫̫̭̲̙̖̜̱̲̲͍̖̥̾̒̿̿͋͑̈́̇̔̀͌̊͛̋̊͊̇́́̇͗́͋͑̈́͋̉͒̎̈́̿̇̅̾̈͆̄͌̃͐̽͐͂̈́̑̍͋̓̎̐̊̈́̀̈́̽̓̾̓͌̀̿́̉̀̑̒̕̚̚͘͜͠͝͠͝͝ͅͅͅd̶̢̨̛̛̛̛̛̛̩͈̟̙̟̟̫̠̙̟͎̮͕̱̜̫̤̦͖͊̍̓̔̇̈̎̂̏̽̽̓̈́̃̌͐̈́̊͌̿̇͌̉̆̎̓̑̍͂̏̓̈͌͗͂̑͛̓͑͌̎̐́͐̇̐́͆́̉̈́̾͌̇̀̐̀̊̀̃́͆̽͆̈́̔͋́̓̽̑̄͐̊̽̂̓̈́̈́͊̍͌̅͂̈́̒̃̈̅͐͂͊̈́́̄̀̓̂̾́̓̀̎͋͋͑̔͋̇̽̏̔̐̌́͊̈́̎͘͘̕͘̚̚͜͝͠͝͝͠͝͝͝͠͠͝ę̵̢̢̧̢̨̧̡̨̧͖͍̰͓̩͔͓̯͔̜̗̹̱͚̠̝̫̯͍͎̥̣̥̯͚͙̱̼͍̭̘̟̪̯̣̩͖͙̲͔̹̱̥̩̫̠͉͕̮̰̞̱̳̼̭̎͌̍̓͌͋̎̍̿́̿̌̍͆̑̅̽͑̔̂̇̋͆́̓̔̈̿̿̈̔̇͛̀̎̔́̐̊̅̀͋͗̋̈́͂̀̓̓̊̔̈́̎̾̉̇̊́̈́̒̀͂͆̿̓̓̋̆̈́̎̑̀̍̈́͌͋̀̊͆̏͛̔̑̇̒̊͂́̎͊̓̒͂̒̽̅̀͊͐̋́̕͘͘̚̚̚͜͜͜͝͝͠͝͠͠ͅd̴̢̨̧̧̛̛͕͍̤̤̰͍̹̰͍͎̗̱̗̲̜̳̘͚̞̬̺̠͚̫͕͙̮͚̗̟̠̳͚̗͙̤̓͐̓͐̀̃̇̎̀̀̅͊͑͒̔̎̿̈̈́̈́̆̅͒̐͆̈́̈́̅̎́̾͐͂̐̓̿̅̈́̈́͊̉̾͗͆̐͂̎̔̎̓̊̄͑̊̉̀̆̉̈́̀̽͘̚͘͘̕͘͜͝͠͝͝͝ ̶̢̨̡̧̢̡̨̢̲͕̮̖͓̠̘̜͕͖̹̖͔͍̭̳͕̞̺͍̩̙͙̰͈̮̩͍͚̦̼̠͎͕͓̳͉͚͚̺͈̫̬̭̦͚̘̥̦͖̣̠̬̙̯̳̯̭̬̟̮̟̳̟̻͍͉͉̟̭͍̬̫̮͎͍̱̙̮̠͙̘͍͉̬͈͖̗̗̫̜͉̹̭̠̖̞̝̬͕̞̫̦̲̻̜̭̪͖̰̘̘͉͓̻̥͎̩̦̙̟̟̱͋̊̋̊̈́̀̆͂̒̀͆̆̋̌̄͋͋̽̉̓͋́͘̚͜͝ͅͅi̴̧̡̨̨̧̡̢̢̧̧̢̡̡̧̡̨̨̗̣͓̗͎̞̩͍̞̣̗̞̣̥͔͖̫͓̠̭̝̠̗̟͍̜̣̝͉͉̯̘͓̭̦̜̺̺̙͙͔͈̹̖̗͍̺͖̭̟͇̼̹͖͙͖̗̦̠̜̯̱͉͎̳̖̣͓̱͖̣̬͎̣̟͈͎̗̮͎͈̼̳̖͖̥͕̖̹̯͈̋͑̍̊͋̑͒͌̊͛̈́͂̎̓͋̀̋̍͆̌͑̃̋̀́̈́̄͗͋̔̚͘͜͜͜͜͜͝͠͝͝ͅͅͅͅͅͅm̵̧̧̧̢̢̛͖̩̼͉͉͍͈̝̘͙̳̗̤͙͎̫̠̫̯̱͓̦̯̳̩͈̳̗͙̠̩̭̖̣̗̜̱͇̜̯̙̥͖̦͎͈̘͇͔̞̞͋̏̋͐̆̔͛͂̾́̈́̐̊̓̒͐͒͛́̌̏̈́̃͐̇̍̅̆́̍͆̆̏̿̏̓͂̌̏̽̚͘͝͝͝͠͠͝ͅ ̷̡̨̨̨̢̡̢̢̢͓͕̰̜͍͎͔̭̻̘̫̼̰̘̱͔̬̼̩͇̗̪͖̯͕̭͙͇̮͔̞͕͉̻̜̜̜͇̬̙̙̫͕͙̣̳̙̻̳̫̬̱͉̠̣̻̘̱̼͉̝͖̝̣̘͎̺̣͈͒̐̐̋͋͒̿̍̇͂́̃̋̃̐͆̋̒͛̍͒̀̃͘̕̚͜͜͜͜͜͝g̵̨̧̢̨̨̡̨̨̡̡̢̨̧̨̧̨̧̨̛̛̛̛̝͎͓̻͈̞̘͖̟̙͉͙̘͚̤͔̦̹͓͎̞͓̪̺͓͕̩̝͇̦̜͔̱̲̥͔͈̯̭̠̻̗̲̦͈̱̯͈͈̪̫̜̹͔̣͚̝̘̼̖͓̤͔̥̪̻̩̰̮̥͓̣̭̦͇͚͇̺̘̬̫̟̦̺͚̖̠̺͖̱͈̜̗͕̟̦̥͖̝͙̪͈̼͓̥̬̞̖͉̝͓̼͕̙͕̻͍̗͔̻͓̠̞̙̙̥͇͍̥͖̜̪͍̺̠̼͎̦̰̻̩̣̥̫̏̃̀͂̆͛͐̉̿́̑̾̔͒͆̆̈̑͗́͋̀͌̄̑͑͊̐͒̎͛̀͐̓̈́̃́̑̃̈́̊̆̒͊͆̐̍̎̈́͊̾͆̓̈́̀̿̂̿͛́́́͌̉͆̐̂͌͑̈́̔́̓̉̓̓̀̀̆̅͌̔͒͆̄͌̎̃́͌̒̍͑̐̀̈͒̅̋͊̇̓͂̓̎͐̍̔́͆̐̾̄̏̃̈́̔͆̈́̈̕̕͘̚̕̕̕̚͜͜͜͜͜͝͝͝͝͝͝ͅͅͅͅͅo̵̧̧̨̡̧̧̢̢̢̢̧̢̨̨̢̧̡̢̡̧̨͖̜͙̩̰͓̖̺͎͇̱͇̪̘̦̙̣̭͇̲̲̺͉̜̠͔̖͍͉̖͓̝͇̻͓̘̹̳̞̙͓̩͍̝̠̫̮̰͈͇̬̫̳̹̹̟͖̥͍͇̘̼̗̲͖͓̝̗̳̰̲̖̤̥̘̗̹͈̬̭̪͈̬̪͇̘̬̭͔̤͎̻̝̯̟̺̼̥͈̹͓̻̻̥̮̼͉̠̮̬̣̩̳̫̺͍͙̥͉̖͖̦̺̫̪̯̰̹͍̼̖̪͔̦͇̳͕̗͕͍͖͖̰͙̣̐̀͗̀͗͆̓̽͆̈́̆̉͒́͋̃̈́͂̆́̔̐̊̔̕̚͘̕͜͜͜͜ͅͅͅņ̶̧̨̢̨̡̛̛̱̻̘͉̝͚͖̠͇̻͍͉̠͈̖̠̭̗̮̬̘̟̼̺͓̬͈̤̩̣̤̖̲͔͓̠̫̘̠̖͔̜͔̹͙͚̱̹̬̯̞͍̩̱̙̼̣͎̱̖̠̥̩͈̲̺̼̙̬͖̜̼̾̀͒̈́̾̄̓͗̓͛̇͑̍̒̀̊̎̈̏̅͒͂̽́̓̑͛͋̅͛̾́́̔́͑̐̃̍̋͊͛͗̑̇̈́̉̐̍͛́̐̽̔̆̌͒̊͛̈́͑͊̈́̐́̄̀̈́̑̉̃̈́̎̉͑͆̊́͌̈́̋̏̾̐̈́̾̽̋͊̚̕̚͘̚̚̚̕͜͜͠͝͠͝͠ͅņ̶̨̨̧̧̛̛̛̺̦̻͙̱̪̩̼̹͖̣̤̗̼̠̟̼̺̜̗̦̣͖͔̥̘̗͍̪̝̪̞̝̜̗͈̙̖̺̞̊͋̆̀̾̏̌̈́̍̐̀̈́̈̐̆̇̆͒̽̿͆̂̉̆̾̊͑̀̀̃̿̄̏̂̓͑̎̒̉̿̀͋̃̈́͒̑́̒̌̇̈̓̔̑̾̂̏͋̄͊̽͊͋̓͛́̏̎̓̿͊̓͋̆̅́̓̀̅̓̉́̈̃̈͑̽̈́͆͊͒̈̃͂́̏͐̀̔̃͘̕̕͘͘̕͜͝͝͝͠͝͝͠͝͝͝͝ͅä̶̢̢̡̡̢̛̛͖͙̮̮͙̬̘͈̜͉͈̘̞͈̯̜̲̬̟̱̱͍̝͚̺͍͕̹̫͉͙̬̮̤̲̙͙̪͙̬̼̼̪̺̥̳̗̖̩̎̀̐̋̈́̊̔̓̉̇̌̔́̽̈́͊͒́́̋̍͛͋͐̓̿̉̊͂͒̏̾̅͛̄̓̏͗͗͒̓̅̽̂͛̿̈́̈́̑̋̔̊͐̊̍̃́̿͂͛́̌̂̑͋͆̐̊̾͆̀́̈́̑̊͛̍̇̌͌̍͊͊͐̈͛̿͘͘̚̚̚͘̚͜͜͜͜͜͝͝͠͝͠͝͝͝ ̶̧̡̧̧̨̧̧̛̛̛̛̛̛̹̥̙̙̝̦͖̠͙͓̝̙̮̹̝̳͙̘̼̝͔̪͈̼̞̖̯̲̘̜͖̟̺̘͓͉͎͚̺̬͈͖̙̳͎̲̙̟͚͓̲͖̦̗̙͕͉͓͈̹̱̙͖̦̠̖̤̭͕͙͖͉̯̗͖̺̲̩̤͍̟͔̙̗̬̗̲͍̮͈̦̟̩̟͖͕̠̠̬̮̬͓͉̻͍̼͉̥̫͎͍̱̣̭͕͍̜̥̳͈͇̖̹̐̅̒͋͆̋̄̈͊̋̎̃̎̈̑͑̎̎͊̄̽̇̔̋͆͑̈̑̈́͐͊̓̓̿̍̒͆̈͒͛̎̉̃̓̃̿͂̊͋́̓̈́̽̒̑̍͒̇͊̓͗̒́͒͋̇͛̒̈͆̏̓͐̍̑̏̑͛̈́̌̾̾̀͋͌͋͆̓̃̊̈̈́͑́͗̆͗̃̀̑͐̏͂̂͐͒̌̂̎͂̌̎̓̂̀̆̍̄̊͆̈̄̿͂̉̽̈́͒͌̆͌͋̈́̈̀̊͗͋̉̇́̀͌͗͘̕͘̚͘͜͜͜͠͝͠͝͠͠͠͝͝͝ͅͅͅͅͅs̶̢̧̮͕̖̖̠̹̘͓̦̳͙͕̺̖̱̮͕͚̞̀̎̓̅̄̇͋̔̿͆̂́̈́̐̓̓̅͋͋͛̈̆̄͑̀̽̒̽͑͑͆͋̀̽̓͆̈́̈́̔̉̈́͆̈́̃͂͋̔̄́̔̅͆͐̄͗̈́̋͛́̿̊̓̒̀̂̐̓̂̋͊̍̌̐̑͊̀̾͊́̃̇̎͊̆̽̿̈́̈́̚͘͘͘̚̚͘͘͘̚̕̕͠͝͝͠͠t̶̨̛̛̝̥͐͗͐̄̓̓̎̃̔́̅̑̂̑̅̏̎͊̃́͋̔̉̊á̴̢̨̨̡̡̡̧̡̡̡̡̡̨̛̛̖̖̱̠̞̲̬͖͈̼͈̺̝̖͍̣̱̙̩͚͓̭͓̯̠̖͓̘̟̖͚̭̳̮͔͓̹͔̜̱̖̹̰̝̗͎̰̗̺͍̣̼̯̗̮͔͔̹̜̥̞͍͖̬̫̼͙̙̯̖̲̯̱̟̘͖̩̪̯͈̳̠̼̭̭̜̳̬̗̲̪̹̗̣̪̺͖͚̦̝̜͇̗͍͕̝̜̣͈̺̝͇̫̫̰̣̼̱̘̪̞̺̫̺͎̘͙̰̗͈̥̗̺͓̩̖̫͔̠̠̪͔͇̓̉̐̔͑̾̀̇̏̋̋̅̈͒̄̈́̀͊̈͆͌̅̄́́̈̏͗̐̇̈̌͋̎̈́͋͛̈́͑̊͗̑̆̄̇̌̓͋̽́̌͋̔͗̋͐͐͝͠͝ͅͅͅͅͅͅͅͅͅ ̷̡̡̡̡̢̢̨̨̢̨̡̡̛̛̛̱̟͔̫͈̠̠̟̘̠̝̫͓̮̰̩͉͕̰̯͎̬̫̞̤̯͍͎̪̟͉̘̻̻̟͍̫͍̣̜͔̥̝͕͈̟̠̥̹̥̟̰̞̠͍̩̳̲̜̮̙̝͇͓͚̤̹͎͕̪̥͔̯͙͚̙̋̇̒͊̇̀̐̂̍́́̑͛̂̈̈́͊̃̽́̌̈́̈̈́̈́̈́̏͋̃̊̓̒̂̾̆̿̅̄͐̒͆̃́̆̋̀̽̃́̄͒̃́͌̇͊͛̈́̆̿̊̇̽͐̌͆̎̃̊̂̏̀͗̀̂̊͗͛̎̆̌̊́̃̂̃̎̋̕̕͘̚͘͜͝͝͝͝͠͠ͅ ̸̧̨̨̨̨̢̧̧̧̡̡̢̡̢̛̛̛̛̺̖̪̩̜̞͎̪̬͚̦̫͖͔̜̣̼̮̦̥͚̘͔̱̝̹̲̞̪̞̟͙̱̱̻̰͕͎̖̭̱̭͚͉͚͚̥̝͍̣̱͇̳̞̫͙̭̬̩̖̬̹̱͇͔̥̘̮͉͕̥̭͖̞̮̮͈̦͖̜̥̲͙͚͈̣͕̜̱̺̯̮̖̙̠̭̪̪̦̻̤̠̙̜̱̯̺̻̞̰̯̱̻̪̜̭̙̟̻͚̰͇̯̼̥̲̬͓̙̼͖̤̰͉̤̱̥̈̈́̆̔̇̓̿͋̏͐̎̀̍̑̈̊̈́̃͂̀̿̂͑̓͒̿̊̂̈̌̍́̐̂̄̈́͆́̿̾̈́́̉͑͐̎͛̌̾͐̈̍́̍̋͐̿̓̀̂̈̄͌̉́̔̑̐̉͐̉̾̍̏̀͆̔͊̐̾̽̒̓̎͌̒̔̽̔͒͌͐̽̐̔̄͆̉̈́͌̄̊͘̚̕̕̕̕͘̕̚͜͜͜͜͠͝͝͝ͅͅͅͅͅͅ ̸̧̛̛̜̙̭̝̗͙̭̩̻̖̲̫̯́̉̏̄̆̄͑̈́̈́͗̓͛̍̆͗̋̀͗͌͗̊̅̃͋͋̌̇͌͆̾̓̆̃̃̉̀̐̋̎̒́̀̓̎͊̒̑̆̍̔̍͒̑̃̋̈́͆͒̀͗̆̏̍̈́̅̐̋̏̾͗́́́̉̽̎͐͛̍̐̿͐̉̿̆̃̽̋͑͗̀̇̾̆̊̐̍̉͛̈́͋́̑̍͘̕̕̚̚̚͘̚͘͘͠͝͠͝͠͝͠͠͠͠ ̷̡̢̧͉̼͈͎̮͈͕̼͖̺̮͔̺͖͙̮̹̟̯̪͉͙̘̗̞̩͇͙͔̦̫̰̥͔̬̼̞̣͎̬̙͔̱͛͛͗̏͘̚͜ͅͅt̷̨̨̧̧̢̢̢̧̢̧̨̨̢̨̡͙̼̦̦̺̦̜̙̱̜̺͚̟̖̻̝̟̤̙̘̜̹̻̻͕͈̗̗̝̞̼͖̟̤̘̤͎̲̳̙̖͓̭͇̯͈͕̣͓͎̝̥̗͕̩̺̬̦̤̣̗̳͓͉̮͔̰͙̗̝̯̙̖̳͚̰̩̩̘̥͖̩̦̟̟̞̱̺̦̫̜̠̼͓͓̫̪͎̝͇̱͔̫͇̠̺͚̭̻̬͓̫͕̫̼̤̣̯̺̞͈͖̣̣̦̜͍͔̪̗̖̱̩͖͍̖̫̩̘͕͓͈̜̗̗̩̘͈̻̹̿́̑̾̃̏̀͋̃͛̉̓̎͂̂̽͋͋̌̽͐͊̈́̽̎̒͒̀͌̍͆̐́̈̄̃͒̽͌̓̄͛͒̈̃̔̃͌̃́̈͒̐͗̀͐̑̿̅̽̔̽͗̌͐͑̀̾͌͐͐́͛̅̔͋̈́͐͊͘̕͘͘̚̕̕̕͘͜͜͜͜͜͝͠͝͠ͅͅͅͅͅ ̷̧̛̺̯̻͙̞͓̩̝̗̣̊͛̈̐̈́̋̐̔̎̄̍̄̽͊̔́̇̓̅̿̽̈́͂̈́̐͒̀̐̓̎͑̿̔̐́́͆̅̋̈́̈̃̊͐̐̃̀̀̄̄̈́͊͐̾͘̚͘̕͝͝ẁ̸̛̛̛̛̭̪̗͇̱͙̬̥̪̈̈̌̀̆̒̀͐͛̂̂̍̃̉̀̽̍̀̀̎̆̽͋̓̅͑̿͋́͋̊͐͑͊͂̃̆͐̃̑̏̇̉͐̓̑͂͋̇̈́̅̄̒́̾̿̀̉̏́̇̕̕̚̕͘͝͠͠͠͝͝͠͠͝r̶̢̡̢̨̡̧̢̢̨̨̨̛̛̝̭̟̰͎̼̬̣̺͈̘͓̘͕̫̺̙͖̣͇̞̲̖̲̘͈͓͓̣͔̰͈̞̙̖̹͕̤̦̯̭̜͖͈̯̺͉͎̼̖̖̺͚͙̯̰͙̳̞̤̠̘̘̬͙̙̦̰̤̫̬͖͚͚̙̭̥̜̰̱̥̺̹͇̱̝̬͇̺͉͚̭̠̳͖͔̦͓̠̦̞̼͖̯̪̻͍͓͇̼̺̪͓̪̭̠̫̘͓͙̈́̐͌̀̅̂̈́͑̾́̂͗̇̊͛́͆͒͗̋̑̐̏͆́̽̒̅̾͊͛̔̃̄͋̽̎̒̑͛̿͂́́̐͐̾̒͆͗̈͂̊̉͛̓̾͆̃̅̉̈̑͌̃̀̿̏̎̓̾̒͗͆́̇͘͘͜͜͜͜͝͝͝͝͠ͅͅͅͅͅ ̸̧̡̡̨̨̨̡̢̧̧̛̛̛̛͍̩͙̼̬̟͉̦̹̮͚̯͔̰͉̼̻̲̞͍̺͔͉̫̘̳͎͚̟̳̘̙̬̠͎͚̗͔̱̹̩̜̫͇̪͖̗͎̘͕̲̪̞̻̝̰͖̤̞̤̦͉̞̟̘̘͉̲̺̝͇̜̖̹̺͙͉̬͎̤̜͙̙̬͊̅̄̈́́̄͛̓͂̌̍̔̎̐̾̈́̐̀͗̇́̈́͂̆̈́̀̅́̓̓́̈̓̊́̊̑́̈́̓́̓̒̌̃̊̄̾̈́̓̉̊͂̑̄̇̿̈́̔̂͂̃̓̐̔̊̋̓̆̌̈̉̔̊̎͛͌͋́̒͂͑̑͒̈͐͊͒̾̈́̌͐̒̈́̅̈́̍͑́̋͐̉͌̊̑̈́̒̏̏͆͂͂̐͂͋̄̑͆̂̌̽̓͛̉͌̋̊͋̔̾͆̃͂͛̆̋̽̄͛̇͛͛͊̈́̔̓̽͂̚̕̚̚̕̕̕͘̕̚͜͜͜͠͝͠͝͠͠͠͠͠͝͝͝͠ͅi̸̧̢̧̡̢̧̡̫͉̩̲̣̰̺͎͎̹̤̭̬̹̳̤͙͕̰̻̦̗͉̘̯͙̼͖̺̩͖͉͍͈̦̝͇̦̼̹̦͙͕̲̖͔̞̻͔̬̩͙͍̝̟̰͖͙̤̙̮̤̣̦͕̫̠̘̻͍͔̭̝̗̠̱͙͈͓̥͔̯̯̯͇̪̞͕̩̠̣̬̻̻̤̥̜̲̹͕̳͂̆̎̔͗̒͊̒͛̊͑̏̾͂̂̎̈́̽̌́̊̈́̇̋͛̽͒̓̇͛̈́̈̔̋̈́̚͘͜͝͠͝͝ͅͅͅͅͅ ̸̨̨̨̨̡̡̨̨̘̣̗͙̮̣̣̰̝͙̫̰͙̲̩͔͕̖̳̭͖͍̱̯̣̦̭̺̦̦͓͈̥̺̳̘̭̪̜͔̟̠͚̘͈̙̝̯̟̜̮̖͉͓͎͙͙̝͍͎̭͖͖͓̫͕̰͉͉̬̘̪͚͓̙̤̠̗͙̗̞̭̗̦͙͓̩̮̰̖͇͈̣̱̪͈̩̬̳͔͎̞̺̙̭̫͍̖͉͍͇͇͉̠͙͔̞͔̭̯͍͇̬̯̹̼̣̟̜̫͒̈̒̊̓̈́̑̓͊̓̓̈́̾̈́̓̉̇̈́̾̑̍͒̿̈́̈́̚͜ͅͅ ̸̨̡̢̡̧̢̨̢̡̧̛̛̛̛͎̠̜̜͍̺̘̬̺̹̞̞̯̗̺̥͎̙̦̤͔̬̪̝̣̩͙̱̖̠̠͍̗͖͕̪̲͍̝̞̠͓̪͈̘̖͔̜̪͚̯͙̗̫̯̥̹̺̥̦͙͕̼͕̮͉̹̞̱̠̘͖̻̙̣͈͚̻͈͍̘͖̘̰̘͓̱̮͉͍͉͉̝̼̳͉̙̱̱̟̫͖̠̝̜̘̱̱̱͙͙̬̜̠̦̠̥̻̩͇͉̲̯͍͖̥͓͙̻͔̙̰̳̝̫̯̯͂̿̉̾̑͆̿̀̄́͐̐̐̈́͆͑̃̐͌̿͊̈́̈́̈͌̿̎̉̽̾̊̈́̿̉͗́̀̇̀̈̋͆͗̊́̒̈̈́̆̋̆̔̿̉̍̎͒̅̈́̂͑̏́͊̌̏̑́͒̿̆̐̉̄̿̍̀͆̈̀͊̄̆́̍͋͗̈́͐̒͗̏̃͛̐́͂̾͑̕̚̚̕͘̚͜͜͜͝͠͝͝͝͠͠͠͠͠͝͠͝͝͠͝ͅͅͅͅ ̴̢̧̡̛̮̞͈͍̰̣̜̥̳̟̯͖̳͖̟̜̰̜͔͖͕̺͕͚̞̥̮̖̟̥̠̣̩̮͕̖̲̙͚̮͇͍̘͎͇͎̪̯̗͓͉͕̫̫͎̗͇̹̃̽̍̎͛͛̓̾̒̿͘͜͜͝ͅͅț̶̡̢̢̧̛̛̗͖̙̩̹͕͍̪̻̗͙̘͙͕̥͍̭̣̘̻̖͔̮̟͇̬͙͕̰̻͙̙͉̻̬̲̦̹̲̻͙̻̱͔̙̣͚̦̆̾̊̒͂̅̋̍̑̀͛̍̔̂͗͒̈́̐͐̅̅̀̏̀̂̊̽̀͛̀́̆͂̿̄̌̅̀̊̿̍̅̽͗̔͌̆̂͌͑͂̉̽͊͗̈́̌̃̑͂̒͛̈́̐͋̓̿̇͆̓̎̉͋̓̊̇̆̏́̈́͒̑̄̋̉̐͛̉̉͋̋̂̂̆͋̑̑͊̌̈́̔̅͑̓̈́̂͛͑̓͛̒̄͌͂͊̌̾̄͒̽̌̍͒̒̄͐̋̊̀̆̍̀̇̚͘̚̚͘͘̚͘͘͘͘̚͘̚̕̕͜͠͠͠͠͝͠͠͝͝ͅͅ ̴̢̛̛̟͚̙͍̲̘̝̳̮̯̈̑́̂͒̐͑̾̈́̅́͌̅̇͂̈́́̐̐͑̀̒͑̊̈́́͋̊̂̍͌̏̔̔͐̊̊͛̋̆̎͛̎͆͊͘̚̚͠͝͠͝͠͝ͅd̷̡̨̢̨̨̧̨̡̢̢̡̢̢̨̛̗̺͈̜̦̘̦̟̹͎̳͖͇̻̩͎̳̥͕̹̪̝̜̗̲̻͈̞̙̠̯̮̣̭̞̲̖̭̫̹͕͚̞̣̹̦̪̲̘̻̭̼̤͔̖͍̰͕͇̖̪̯̼̝̦̜̖̰̮͕͕͍͖̳͕̳͈̲̪͓͔͙̺̠̺̹̹͇̗͙͔͎͖̖̮̯̭̺̥̺͓̲̙̥̘͙̮̹͉͙͍͍̩̣̬̙̭͍̣̬͚̰͕̱͈̲̤̦̣̹̪̱̰̻͇͇͓͂͒̊̀̎͂̑͊́̏͂̒͑̈͌͛͐̎̄̆̂͐̽̂̽̇̉̍͌̿̕̕͜͜͜͜͝͠͠ͅͅͅ ̸̨̢̡̧̧̨̧̢̢̛̛̦̱̲̮̹̯͖͓̼̝͕͈̟̹͓̣̯̞̦͖̪̗̮̞̭͉̩̙͓̤̘͖̼͉̩̱̭̜̭̹̳̪̺͎̲͎̪͕̖̫̘̘͉̟̩̟̟͓̘̗͕̜̝̗͚̘͖͈̼̬͓̩̠̗͓̗͓͖̯͕̱̳̮͎͖́̐̍̋͋̀͗̉̽̉̓̎̌̌̉̽͒̍͛̀͑́̓̔̇̓́͆͌̑̆͆͋̐́̈́͋̍̐̒͌̎͐͑̐̾̐̐̋͑̽͂̓̈́̓́͗̅̒͆̑͂̂̊̔̎̌̈́̐̈̃̉̊́̕̕̕͘͘̕͘͘͜͝͝͝͝͝͝͠ͅͅͅ ̶̢̡̡̢̢̛̛̛̤̣̖̺̘͈̖͍͎̜̲̞̠̥̠͚͚͙̣̫̖̯͍͕͖̜̩̣͓͓̖̤͈̦͕̙̠̦̙̹̖͓͇͙̜͓͍̤̭̘̆̃̓̓͒̇̃͛̂͌͆͆̄̎̒̆́̾̈́̋̉̄͌̾̈̊̍̌̆́̆̓̈̆̑̇͗̈̈́͑̌̃́͆̿̒͛͊̐̏͊̒̆̄́̾́̈͌̒̂̾͗́͛̀̚̕̚͜͜͜͝͝ͅͅ ̴̨̧̛̮͈̜̼͈̮͔͎̗̦͕͎̙̯̻̤̺̹̥̫͙͍̗̱̻͈͎̗̜̞̥̬̝̟̙͔̺̟̰̼͚̰̲̳̪̘̘͖̦̫͎̝̗̯̝̺̝̀͒͒̋̄̈́̔̓̑͆̈̋̀̿́̂̒̌̋͗̐͗̋̑͆͗͐̾̓̈̉̈́̄͊̏̈́̀̇̓̋̉̈́̍̾̆̓̑̐̎̄̐̐͘̕̕͜͝͝͠͝͝͠͝ ̸̢̢̧̨̧̢̧̞̯̙̪̰̲̬͕̯̥̯͇͚̼̦̤̮̰̤̞̞̯̙̪̪͇̦͈̩̼̝͉̖̣̠̜̫̲̥̪̺͕͍̼̦̱̭͔̯̭̖͈̮̹̫̀̐̎̉͊͗͋̽̐͒̎́̂̇̽̄̀̊̿̽̽̿̋̊̔̆̿́̽̐͛̒͒̀̅͒̾̂̓̉̄̄́̉̈́̄͘̚͝͝ͅͅͅͅͅǫ̷̢̢̨̢̢̢̨̢̛̛̛̛̛̛̛̛̛̛̛̤̘̩̮̣̱͓̬͕̞̻̪̟̻̖̯̞̩̜͇̳̣̰͇̟̜̞̩̩͖̹̳̥̘̹͈̙̭̭̲͍͍͎̹̘̼̭͍̳̜̣̦̱̖͕̪͕̮̼͚͓̺̘̮͍̮̤̱̱̗̝̥̝̞͙̯̲̖͉͚͙̫̼̫̟̙͎̰̮͍͙̮̝̯̲͙̳̭̟̜̱͓̲͓͔͎͖̞̦̥͕̫̼̘̭̬̰̩̼̪̲͎̲̱̰͍̳̥͂̈̈́̿́̽͊̇̾̓̈́̐͒͒̍̇̇̏̋̽͋̄͛͆͑͑͛̎̐̽̆̅́͛̑̀̄́̒̆̈́̉́͊̂͌̄͋́̌̄͋̓̽̎̂̆͛͋͑̌̆̈̑͋͑͑͗̉̀̇̎̀̇̓̆̄̀̉̾̋́̄̔̋̒͆̉͛̿̌̓͊̋̋̋͛̆̾͋̑̇̃̓́̿̾̂̎͂̈́͆̀͋́̑̋̿͋̅̅̃̇̋̒̏̏̋͐́͊̔̐̅̍̉͂̌̇̾͂̈́͆̚͘͘͘͘̚͘͘̚͜͝͠͝͝͠͝͠͝͝ͅͅͅ ̸̢̢̡̨̡̛̗̣̯̫̳͔̞͕̼̤̠̤̪̙͔̥͍͔̣̎̃͆̈́̏̅̅͊̀͂̈́̾̉̓̀͝ͅ ̶̛̛̭̪̗͒͑̿͗̀̈́̏͆́́̍̇̔̍̀́̈͛͑̀͐̾̊̄̋͊͐͑̊̎̆̃̾̇̉͐͐̀̈́́̽̎̉̂̊̈́̍̌͊̉͂̅̍͆̌̄̾̏̑̏̽̉͂́̊̑̿̓̂̆̉̇̅̅̿̈̃̍͆͑̅̌̀́̉̒̄̾̈̋͋͒̓͂̍̀̆́̾̉̓̇̂̏̐̃͋̚̕̚͘͘̚̕̕̕͝͝͠͝͝͠͝͠͝͝͠f̴̛̖͉̝̬̽̈̽̽̑̎̔̔͒͆̔̿̔̒̃̏̈́͛̔͗͆̔̄̍̈́͌͋͊͐̈́̾͗̔̽̋͌͂͒̈̍͌̓͂̈̕̚͜͠͠͝͠͝ ̸̢̧̧̢̨̢̡̨̧̡̨̛̛̛̛͇͍̯̺͖̮͍̯̗͙̜̗̫̠̱̣̮̤̳̝̥̞̞̜͎͍̰̝̮̞̝̝͈͔̹̭͈͇̠̻̹̥͙͖̻͕̹̱̩̺̥͖̙͕̼͇̙̗͖̼̹̗̮̩̗̮̲̭͔͇͖͉̺̗̤̼̬̥͇̣͍̠̝̞͎̣͚̤͕̙̘̤͇̗̫͙̞̰̤̫͔͕͍̺̲̤͉͇͂͋̿͌̏̉̀̎͆́̅͆̌̿̊̊͐͌̃̐̎͛̉͒̎̾̍̿͑̇̂͑́̂͒̃͊̓̈́̉̈́͗̆̑͋̊̾̈̽̌́̈́̿̇̉̄͂̏̄̈́̈̏͋͋̑́̌͊̈́̎̾͆̉̽̏͆̐̆͊̀̈́̿͐̐̏̈́̄͗͑́̏̒̽̂͊̀̕͘̕̚̚͘͜͜͜͝͝͝͠͝ͅͅͅͅͅd̸̨̢̧̛̛̛͉̮͎͕͙͖̮̩̟̳̻̾̒̒̊̌̃̾̽̈́͂͌̋̈̅͊̀̽͌̊̌͂͐̈́̾̆͂̓̇͌̄͂͗̃̀̇̐̈́̇̓̃̀̆̾̎̀̒̐̈́͗̈́̀͑́́͑̈́̈͑̏̓̃̀̐̇̉͋̆̆̌̈́̽̏͑̅͒͒̀͛̿̏̔͐̑͂̓̑͒͆̍͂̔͋̐̒̋́͂͑̌̋̐̂͊̀͊͗͗́̅̃̓̈͊̍͆̀́͗̽̈́̐̐͋̔́̿͑̂̊͛̀͛̒̐̅̈́̔͑̑͗̑̀̊́͘̚͜͝͠͠͠͝͠͠͠ ̴̧̢̡̨̢̡̢̢̨̧̢̧̢̖͚̘̣̪̦̤̭̼̖̻̱̯̫̰͎̙͉̗̣̝̹̪̞͈͇̠̺̞̮͈̬̤͓̪̙̬̜̹̪̗͙̲̣͕̦̪̙̳͕͇̪̞͎͈͖͈͚̦̞̺͍̹̟̥̻̬̼̳̖͇̙̙͖̳̠̰͍̗͔̜̘͕̱͓̦̯̫͇̼͈̗͙̳̝̱̠̲͕̫̗̠͈̱̳̘̙͖̯̼̠̟͉̬̲͍̼͍̖̝͚͔̝̦̰̱͈̜̳̞̂͛̍̓̐͒̉̽͐̾͊̿̉͊́̄̃͐̅͛̄̓͌̏͌̌̈́́̂͋́̚͜͜͜͜͝͝͝ͅͅf̷̛̣̱͎̬̞̰̃̿͋̋̀̊͗͛̈́̂̒̾̈́̓̽͘̚͘͝͝ͅd̷̨̢̢̨̢̡̨̢̧̡̢̛̛̛̠̬͍̯̺̤̖̠̫͖̟͎̠̗̹̼̻̼̝̙̹̣͎̹̘͇̰͚͈͉̖͔̬͈̰̮̳̥̦̺̱͚̭̥͖̺͖̱̪̦̹̳̳̰͕͖͈̦̫̲̲̥͎̻̹̟͔̳̘͎͇̖͈̟̣̭͖̲͉̗͓̩̞͓͉̼̠͍̲̤̲̯̮͎͉̥̥̞̘̱͓͍͙̗̠̯̳̻͔̞͔̫̟̬͖̺̗̫͖̹̼̯̜̤̟̬̓̀̒̈̐̍͑̇̈́̂̇̊͂̐͐̈́͗͗͐́̀̓̓̃̿͋̓̀̍͌̾̐̀͌̂̄̎̌̈́̐̓̊͌̈́̋͐̌̓̋̒̽̉͋̄͑̆̂̓̍͗̒̅̈́̔̈́̔̾̈̃̑̆̈́̓́̿̋̊̏̾͌̋͊͛͌̋̈̾̈́̚̚̕̕͘͜͜͜͜͠͝͝͠͝͝ͅͅş̵̢̢̧̨̧̡̢̛̘̪̣͉̱͇̻̠̝͕̩̝̱̞̻̼̫̯̯̞̩̹̹͙̰̤̟̝͈̹̭̖͔̩̦̞͙̗͚͔͔͉̰̥̦̙͖͉̆́͆̀͛̈̀͌̂̈́͋̈́̐̏̉́͋͂̀̇̉̈̈̈̓̀̉̄͑̊̈́͒̆̑͛̆̀́̽̍̃̔̎̔̈́̾͗̀͋̽̃̓̃̈̓̄̉̎̅̋͗̈́͐̈̋̏̋̓̒̉͌͋͆͘͘̕̚̚̚̚͜͜͜͝͝͝͝͝ͅͅ ̶̡̧̢̢̨̨̨̨̢̢̨̢̨̤̳͍͖̮͈̖͖͍̝͕̱͈͕͖̠̰̺̤͎̰̱̥͇̖͈̘̰̱̻̗̱͉̥̩͔̗͍̱̮̠̳͎͇̜͖̥̟̞͈͚̩̥̩͈̬̰̝̘̜͈͖͎͍̣͚̟̣͍͔̟̖̩̜̮̬̰̠̘̬͇̩̪̟͈̺̖͎̙͈̭̰̞͉͉̣̩̪̱͇͉͕̩͓̰͔̦͓͔͇̳̲̻̫̙̥͍̳̹̙̤͔̦̻̗̞̥̻̙̲͎̥̺͙̻̫́̏͛̆̔̄̋̈́̿́́͌̒̔̆͂̇̑̽̀͗̍́̿͑̈̅̈́̍̒̉̀͌̌̋͒͌̈́͑̆̄͋͆́͒̉̆̌͋͗̆͘̕̚̕͘͜͜͜͜͠͠͠͝ͅͅä̷̢̢̢̢̨̡̨̨̢̡̡̨̢͎̭͍̠̫̳̯̮̺̝̘͓̗͍̩̪̗̫͉̖̝̞͈̖̝͉͍̬̥̪͙̦̣̮̫͕̤͓͉̗̯͓̹̻̪̖̣̝̠̙͍̖͍̮̜̪̥̝̟͓̦̝̣̳̲̥̙͎̞̪̖̦̱̳̰̫̖̙́̊̍́̀͒́̃̌̓̄̀͊̓̽̇̈́̇́̍̀͑̊̾̾̌̄͌͒̋̓̌̇̈́̆̊̑̓͑͒̀͗̐̈́̀̇̋̇̎̏̉̈́̋͐͌̈́̒͑͐̾̑́͂̎̈́̌̊͛̓̔̎̌̓̑͗͊̈́͗͂͑̍͛̉̚̚̚̕̕̚̕͜͝͠͝͠͝͠ͅͅͅ ̷̨̧̢̢̨̨̢̨̡̢̢̧̡͖̱̗̲̲̰͉͚͍̙̠͈̠̜̼̭̪̝̞̩͉̭͉͇̙͖̳̠͎̤͍̜̮͍̣̗̘̰̥̤͇̝̟͖̮̥̝̯̗̫͎̱̲͍̮̦̩̖̹̹͇͙͕͖̤̠͕̹̪̦͍͓̦̠͔̼̙̥̦̮̣̬̪͚̲̞̳͎̝̙̫̞̗̫̠̯̤͇͙͙̲͖̱̘͓͕̮͔̱̳̱̰̮̘͕͚̞͙͍̗̟̉̈́̔̔̐̒̍̄̆̾̐̒͊̓͌́͆̈́̉͐̿̄̀͗͆̊͋̍̈́̆̀͑̾̀̈͗̽̀̾͛̈́̍͂̋̓͋͑͆͑̑̈́̄̔̽͊͑̈͂̎͘̕̚̕̕͜͜͜͜͜͝͝͝͝͝͝͠͝͝ͅͅ{̶̢̡̡̢̡̢̢̨̨̢̢̧̨̨̡̡̨̛̛̬̼̞̟͕͇̖͈̖͎͓͚̭̖̘͕͈̞̘͇̤̫͖͕̟̩͍̘͖͖̖̹̖̜̥̙̙̖͖͉̖̮͔̹̣̜̤̟͓̬͔̫̙̲̻̣̺͇̜͖̻̯̻̲̩̜̠̬͉̖̼̲̙̺͈͇̹̤̜̮̱͔̤̞̦͖̞̫̝̪̲̟̺͈̱͓͙͍̪̬͖̫͖͖̺͖̙̭̹̣̩̥̟̞͇̥̖͎̯̦̈͊͌͌̀̆̒̇̇́͊̆̓́̄̓̆͐͛̀̈͊̒͆̅̄̉̊̈́͂̾͗̈̌̂̈́͒̈̑͗̄̀̀̏͊̐̓́̊̐̊̿̇͑̓̓̂̂̄̑̃̒͂͂̀̀̎͂̈́̀͋̔̈́͛̃̉̎̎̓͑̀͑̾̋͋̀̾̆̾̇́̾̆̔̒̀̆̈́̇̚̕̕͘̕̕͜͜͜͜͜͜͝͠͝͝͝͝͝͝͠͝ͅͅͅͅͅ{̴̧̨̡̨̧̧̢̧̧̡̨̧̢̛̥͓͎̬͚̘̜̙͚̹̘͓̜̺̫͖͖̞̗̥͚̮̥̗̰̩̪͈̲̲̝͙͇̝̩̙͔̲̣̼̝͍̫̘̱̹̩̰̮̦̩̦͇̖̦͖̪̗̜̤͙͚̟̫̣͍̤̗̱͕̰̦̭͚̤͉̜̠͙͙͍̬̖̜̞̠̗̮̣̱͈̲̩͎̼̰͉͓̦͈̬͔̱͓̱͖̜̹̬͕͚̥̺͎̱̥̱̺̈͊̇̀́͊̋̾͋̐̿̃̾́̎̈̀͗̋͛͑̋͐͒̉̑̌͐̒͌̇̍͊̈͛̿̅̊̉͊̀̓̅͊̏̂͒̈́̽̈́́͂̍̀̾̍̾͂̈́̈́̇͌̈́̽̍͋͛̂̈̉̔̈̏̃́͐̈́͌͆́́͋̉̀͗̋̿́͂̽̔̽͛̒͑̈́̈́̿̇̿̃͋̒̅͑̽̂̏̀͂̀͗̓́̂̏̔̋͑́͑̚͘͘̕̚̕̕͘͘͜͜͝͝͝͠͝͝͝͠͝͝͠͠͝͝ͅͅͅͅ{̶̧̧̢̧̧̢̧̡̡̡̨̢̢̡̛̛̛͙͎͚̙͉̻̪̩͈͚̜̝͖̥̙̲̰̦͍̭̥̗͖̱̺͎̰͚͚̹͕̩̖̹̙͖̤̯̣͙̮̻̻̲̞̯͔̟͍͓̠̮̩̲̦̮̳̮̩̮͕̫̜͕͎̦̹̻̘͈̫̞̲͇̱̪͍͚̩̝̺͚͎̯͇͈̲̖̖̟̳̭̭̼̳͇͚̘͇̗͎͈̤̤͍̙̪̖̮͕͍̟̩̯͖̘͕͉͇͙̣̬̤͔̳̲̘̰̘̯̻̯̩̹̜͙̑͂͌͐͊̉͛͊̈́̀̾̑͆̏͐̿̂̿̂̄̋̈́̆̑̓̉̉̾͐̾̔͋̍̉̀̌̈́̄̔͛̐̆̄̊̃̏͆͊̄͌̑̍̈́̃̕͘̕͜͜͜͝͝͝͝͝͠ͅ{̷̢̨̛̛̛̛̛̛̝͈̯̖̠̪͙͙̪̺͙̮̥̝̠̘̣̩̗̻͈͓͙̝̮̳͚̦̗̗̬̳̹̖̠̼̫͚̳̼̻̻͇̄̑̈̓̀̒͑́́̀̈́̐̑͌̐̔̏̈́̈̈̋́́̓̃́̅̈́̄̔̌̋͂̄̊͗̈́͊̊́̓͂̽̔̓͆̅̊̍̓̈̉͑͌̿̅̈́͊͒̿̈́͆͛̃̀̌̿̈̾̈́͊̌̓̉̅̒̂͐͒̀̅͋́̅̾͆̓̑̔͛̆͆͒͊͌̀̇̀́̅̋̿͐̅͛̀͛͋̐͒͑͒̄̌̓͋̃̍̾͑̍̇̉̽̊̊̈́͒́͒͆̎͘̚͘͘̕͘̚͘͘͘̚͜͜͜͜͜͠͝͝͠͝͠͝͝͠ͅͅ{̴̧̧̢̧̨̠͚͇̲͈̤̟̫̰̱̮̟̟̞̦̬̗͓̻͎̲̰̺̯͉͈̮̣̯̰̌̽̽̓̅̊́̓͂̇̾͛̄̀̐̒̑́̍́͌̐̈́̏̿̃̈́̆̆͋́͒͗͛̄̑̾͛̇̂̅͆͋̆͋͑̀͑̾́͆͐̐̀̏̽̍͊̈̓̄͗͑͒̈́̓͒̉͑̿̈́̈́͒̅̌̉̀̑̅̕̕̚̚͘͘̚͝͠͝͠͠͝͝͝͝͝͠ͅͅ{̵̡̡̡̢̧̧̛̛̛̻̹̪̜̙̪̙̞̝̟̼̬̮̝̠͖̪̻̻̖̜̠̱̤̟̻̺̪̝̙̫͔̦̪͍͙̤̼̺̘̩̜̻̟̪̗̝̖̲̜̟̹͙̟͔̜̻̜̣̼̞̜̥̜̫͕̰͕͌͋͌͛̓͗̑͋̊̒̌̎͋̄͗͂͊̒̃̃͋̈́͂͆̌̏͗͑̈͛͌͛̍̎̐͌̆̑͊̐́̆̌̇̽̀̓̆̆̏̆͑͑̀̏̑̈́͊͗̀͂̿̓̑̊̈́͋͐́̎̎̾͌͒̌̌̔́͋̊̆̎́́̄̍̔̉͐̈́̒͐̀́͂̿͗̉̽̾̒͐̈́̿͗͆̈́̏̈́̏̈́̽͋̉͂͑̌̒͗̾͑̏̾́̉̇̆̆͐̊̏͌̇́̅̊̆̌͛̉̀̚̕͘̕͘̚̕͘͘͘̕͝͝͠͝͠͝͠͝͠͝͠͝ͅͅͅͅ{̷̨̧̢̢̢̨̛̜̘͚̝͍̝͔̬̖͖̮̤̰̫̜̻͓͚̖̼̗͍̣̟̲̗͚̱̞͓̹͔͍̖̹̫̲̝̻͈̳̪̳̗͈̮̘̪̙̤̪̩͖̟̮̩̠̲̼̞͔̞̘̰͉̱͔͓̤̫͍͇͉͈̩̗̱̫̖̣̋͗̿̈́̃͆̑̑̋̽̊͆̀̂̑̆̇̾̂̔̉̃́́͌́͆̽̆̌͌̿̓̔̔̅́̈́̐̽̍̑̆́̿̇̓̎͌̍̆͂͊̅̌́̆͌́͊͂̀̒̾̍̿̆̌̄̓͐̇̑͊͐̌͂͐͐͐̅̀͆̊̊͘̚̚̕͘͘̕͘̕̕̕͜͜͝͠͝͠͝͠͠ͅͅ{̵̢̧̢̛̛̛̛̛̛̛̛͎̪̙̬̺̲̤̖̤̱̱̳͙͎̖͔̺̖̙̺̫̱̫̫̜͚̻̺̻̙̼̟̰̲̭̠̱̪͍̘̳̻̰͔͇̞͚̥͔̟̞͈̺̟̝̪͚̟̰͔͉̜̺̗̰̯͕̱͕̩̖͔̰̼̩̙́̔͋͒̌͐̊̄͗̾͊̒̽̽̆͑̔͆̑̔̀̑̔́̔̏̍͛̀̔͆̓̈́͊̀͗̒͊̽̍̒͂̓͗̈́̊̐̋̃͐̆̂͂̌̑̑̈́̄̂̈́̅̋̔̎͋͋̅̅̐̓̂͆͌̐̑̿̚̕̕̕̕͜͝͝͠͠͝ͅͅͅ");
        Glitch.Add("W̶̢̮̟̤̙͕̦̞͖̮͎͔͇͛̅̃̑̄͛͒͂͒̆̀͘͠͝͝ͅḨ̸̩̝̗͓͔̥͙̥̯̻̮̜̬͇̙̤̭̤́̾̊͠ͅŸ̸̰͉̙̰̻̻̖̫̣̼̗̱̾̀̃́̓̎̈̿̅͌̈̔͆͐͊͋͌̑́͘̚͝͠͠ͅ ̴͔̝̹͓̯̯̩̓̿̀͆̑͝͠͠ͅČ̶͚͚͙̮̯̳̠̘̱̄́̌̀̽̓̏̔̈́̊͑̔͆̀̔͑͛̇̆͘̕̕̚A̶̪͔͙͕͇̲̘̙̾̓̏̾̐̉̎͋̊̓̈̂̎̂̈̏͐̽N̴̡̡̛̗̠̳̱͕̱͕͕͎̝͕͔̫͎̳̩͆͐̃͊́͒́̂̄́̀́́̽̄̈́́͒̃͌̄̚͘T̴̡̨̢̡̨̨̹̹̯̬̞̞̠͇̯̙̪͖̩̞̗̗͔͇̃͐̇̏͗́̉̚ͅ ̴̢̘̋̾͗̓̉̌́̔͊̽͗́̎͐̓̐̉͗̍͂̋̍̔͝͠I̴̢̛̤̪̗͚̫̟̳͗͌́̉̆͌͆̌́̈́̏̑͑͋̊̆̽̈́̂̏̀̀͝͠ ̵̛̣̦̪͕͖̦̥͕̓̋̾͒̋̓̉́͊́͝͠ͅD̴̨̤̝͉̱̰̖̖͍̣̠͙̘̈́̕͜Į̴̳̥̯͔̲͎̼̉̎̑͆͂̒̓̀̒̔̍̈͛́̇̾̑͠ͅE̶̗̝̣͈̞͆̄̆̌͠͝͝ ̴̢̛̜̹̲̟̲̰̖̝̟̤̺̦̖͓̑̐̏̃̽̈́̅̿̄̈͆̈́͘ͅW̵̡̨̧͉̜̖̺̼̫̠͉̘̜͇̺͎͍̩͍͒̋͑̀̂̑̉͜͝H̴̪͍͕̠͉̱̯̬̗͙͓̻̫̖̫̒̏͆͑̉͗̎̈͒̀͆͒͆̈̽͂̚͘͝͠ͅY̷̨̡̡̘̠͎̝͕̟̳̱̯̜̫̮͕͖̎̋̓̇̿̐̿͗͋̇̆̑͌̃͛̅̕̚̚͝͝ͅ ̸̺͕̀̈́̕Ç̷͈̹͚͖̙̟̪̥͍̣̱̟̯̬͉̮̲̣̲̩̪̯̿͘͜À̴̡̨̯͍̺̬͚̞̯̗͙͇̮͔̖͇͍̼̜̤̹̈́̄̐̿̏͛͐̕N̴̦̻͍̫̣͎͇̹̐͑̎͛͐̒́̀̑̓͘͜͠T̵̼͐̒̈́̄͊̋͑̌̅̉͌̓̀͛̐̕̚ ̵̝͕͊͂̏͌͗͋̀̓́̒̒̈́̈́̀̚͝I̶̢̱̥̺̗̞̤̮͕͚̰̗͖̤̟̎͗̊̋̌̄͂͒̊̆͆̆́͌̆̎̽͛͘͜͝͠ͅ ̷̡̧̡̛̮͇͚̥̗͚̞̣͔͇͍̰̤̣̪̟̠̪̂̑̎͘͜͠ͅD̵̡̨̡͖͖͔͙̞̩̬͓͕̫͙̥͈͚̩͇̮̹̘̈͜͜Ḭ̷̢̛̼̥̩͙̠̙̖̦̲̳̯̦̉̉̒̓̋́̿̑̅͂̓̀̎͛̾̓̔͜͝͝͝ͅE̸̢͙̹͉̍̀̓͑͗̈́͗̋͒̂̓̿̀͋͠͝͝͝͝ ̴̢̨͖͈̩̹̣̗̺͉͙͕̼͔̇̈́͋̀̏͛̄̀͂͂̏̈̑̅͆̃̉̓̇̕̚̚̚͝͠Ẅ̸̧̦͕͍̗͖͓̤̥́̂̀̄̿Ĥ̷̨̢̛̼̺͉̮̱͍̖̮͉͔͈̪̥̪̻̼͙̍͛̋̔̉̽̽͛͊̓̂̓̋̍͊͗̀̐̌͂͘̕͠Y̴͎̹̩̭͑̒͒̾̏̈̅͑̆̓̐̑̇̎̈́̂͌̚͠ ̵̨̧͍̦͕̬͖͉͙̻̫̲͓͈͙̯̤̜̬̮̰͋̃̆͒͑̂̿̀̈́̎̍̚C̴̢̛͔͚̥̱͕͍̰̐̈́̇̃͗͆̒͗͊̒̈́̄̌̄̌̽͊͌̎̃̋ͅA̶̛̻̪͖̔́͗̑̋̇̐̇̑͊̈́͒̏̚N̶̺̝͚̆̾̓̀̌̏͆͐́̓̉͊̈́͗̅̿̐̕̕͘̚͘͝Ţ̸̛̯͎̮̭̩̓͒͑̏̉̏͗̀͐̿͐̍̍͘͠ͅ ̷̛̤̹̪̮̩͙̻͓̖̬̥͇͎͚̫̮̓̂͛̄̆̑̂̑̃̈́̿̀̌̔̔̆́͗̽͆̕̚͜͠ͅI̷̛̤̣͔͕̺͇̗̯̝̳̗̼̩̗͑̅̉̀̀̄͆̓̈́͂̀̂͛͊̌̇̐̽̉̚͜͠ ̸͔̹̹͓̌̉Ḑ̷̝͉̱͚̣͈͖̣̪̙̰͈̼̹̬̳̘͆̿̍͒̀̀̅̅̐̒͝Ḭ̴͕̜̩͕̼̻͎̱̲̤͓͈̞̊̔̾͛̑̀̀͊͛̃́͛͑̕̚͝E̶̛͈̙̯̹̬̻͖̭̞̪̔̃̆̀̒̓̀̽̈́̿̋̎̀̒̎̒̆̚̚̚͜͝͠͝ͅ ̴̢̡͔̹̞̣̜̤̲͙͍͎̹̻̀͐̂̏̾̀̏̅̓͂̉͊̚̚͜͝͠W̸̧͈͕̜̪͔͚̪̮̦̏̀̾͆̊̀̀̊͝H̷̢̘̟͖̙͔͖̾͌̎͗̎͂̽͂̌̊͐̋̋̍̉̈̈́̇͜͠͠Ỳ̵̛͉̹̻̞͌́̐͊͐͑́͊͑̏͌̿̿̽͌̊͐́͝ ̴̥̺͙̰̭̹̣͚͉̭̈́C̵̨̨̣̱͙̲͉̯͈͎͎̟̠̘͈͙͔̼̦͚͋̅̓̉̒̉̽̃́̐̂̕̚Ā̶̯̟͚̩͙͎̻̰͖͉̟̝̌́͐̓́̓͑͐͂̎̓̃͒͝N̶̡͚͎̣̩͖̹͍̙̟̣̻̱̗̣̦̙̤̟̭͈͕̊̂̒̇́̈̍̂́͐̈̓̓̋̔̌̉̾̒̆̏͝͠͠Ť̶̢͚͇͎̌̑͗͒̅̌͒̐͆͊̋́̿͘͘͠͝͝͝ ̸̨̢̛̫̲̰̮̟͇̺̪̗̫̜͈͔̪̐̉̿̊̔̓̊͆̈́̉̊͐͘Ȉ̸̬̦͚̮̣̫̺͔̦̰̑̔̇̄̐͆͒͂̋̏́͆̽́̌̐͛̄̆̄͊̕͝ ̵̡̜̺̰̯̌͌̈́̀͘͜Ḑ̵̨̢͇̯̲͇̙̥͓̤͍̮͔̹̞͍͖͉̮̻̬̎̽̊̿̒̉͑̇͛͊̋͌̍̌̾̂̓̄̈́̚͝͝͝I̴̫̖̭͔͖̋̎̈̀̈̓̏͑͛͂̽̿͗̓͝͝È̸̲̤̰̱̞̮͇̝̀́̽̾̐̃̂͆̒̒̿͒̽͑̕͝͝ ̸̧̦̺̪͓̪̟͇͙̗̤͇͍̙̫̫̜̒W̶̭̻̰̭͇̫̫̾̏̀̆͘H̷̛͓͉̣̽̅͆̀̀̓̄͛̈́̽͊͆̀̊̏̓̀̾͝Ẏ̵̨̛͓͕͈̦̲̖͋́̀̃̈́́̎̈́̇̃̃̂̑͑̏̀͝ ̶̨̢̯͖̬̰̥̯̮̖̼͎̯͉̝͊͋̾̃̍̎̇̐̑̿̅̆̿͗̈́̈́̇̚͠͝C̸̢̨̨̧͚̩̹̬̘͇̺̖̰̭̪̙̼̙͉̹̻̲̊̌͗̎̇͐͛͂̂͌͗̔͗̓̈͛̈́͝͝Ą̷̡̨̫̲͇͖͇͍̯̰̟̱͍̱͖̲̩̼͋̇̓̀̏̐̌͊̈͑͌͗̉̌͝N̷̢̡͎̳̪̹̪͔͖̻̬̤͈̳̪̖͇̩̪̆̐̚ͅT̴̻̩͓̤̱͖̲̓̓̀̔̄͂̈̊͊̀͆̄͝͠ ̵̧̢̛̦̳̮͖͙͚͉̻̱̳̻̹̞̳̠̜͇͇̖̜͚̏̈̄̌̉̌̃͐́̎̇̃̅̆̕̕Į̵̢̢̱̘̱͉͔͚̙͉̺̞̰͔͖̹̖̲̩͚̘̊͂͋̔̃̀̚͜ ̶̛̩̖͈̘̖̋͛̓͌͆ͅD̴̦̭̰͎̣̪͎̠͎͇̠̻͎̲̱̰̳̟̟̲̟̀̿̿̎̾̉̈́̄̑̅̋̾̕̕̚͜Į̵̧̡͇͈̙̭͙̝̩̝̖̤̝̬̘͑̌͐͘ͅȨ̵͕̙͈̙̟̺͈͕̥̺̯̞̰͊͂͜ͅ ̵̢̢̜͇̥̤͓̰̝͖̲͍͔̦͎̫͓̺̐͗͛̓͊̌͜͜W̵̢̨̧̢̳͓͓̯̬̬̭͉̺̝̖͔̼̳̏̑̊̕̚͜H̵̯̙̰̝͙̹͖̩̬̙̄͂̎͌̋Ý̴̡̡͎̭͕͓̣̬̗͇͙̹̘̦̫̼͕̗͚̖̊̈́̎͛̈́͌́̄̓̓̂͆͊͗̊͆̑̂͘͝͝ͅ ̴̡̡̤͉̲̙̤̠̲͕̞̥̟͈̟͉̞͓̥̞̗͈͚͂͂̈́̈́ͅC̶̳̠̙̃̿̈́͗̐̐ͅA̶̡̡̨̢̳̹̲̘̤̜͎̟̱͉̗̻̬͈͙̩̰̤̰̾̀̋̓̏̈́̅͐͊̃̎̑̒̕Ṋ̴̳̮̈́̈́̍̿̎̂̄̂̈̿͗͌͐̉̄̕͘̚Ţ̵̥̮̳̭̰̖̞̭͎̦̳̬͚͔̠͑͐̎̃̈́̈́̾̾̓̏̂̆̿̀̂́̍̍̐̅͊̍̒̕ ̶̺̭̖̗̊͌̒̋͐͋͌̃̇̂͜ͅĮ̵̖̏͂̏̓͊̿̍́̽̎́̅̾̎̐̈͘͠͝͠ ̸̱̖͈̗͖͉̠̯͕̪̤̈̄̒̈́͂̄̇͆̈́̈́̊̀̋̕͝D̶̳͚̞̣̤͒̈I̵̛͎̬͍͉͎̙̼̣̩̣̠̳̗̼̫͙̖͉͚̥̔̀̒͆̓́̊̐̂͌͆́͐̃̃̇́̊̕̚͝͠͝͝ͅͅḜ̷̛̪̩͎͚̠̝͓̭̠̤̬̮̳̼̼̏̿̾̐̃̈̑͒̽̽͌͆͌͂̊̉̕̕͜͝͝ ̵̢̡̛͓̦̱̙̬͉̝̻̙̬̱́̌̋̔́̉̆͗́́̂́͝Ẃ̶̢̡͓͖̗̥̞̠̱̜̰͇̮̽̈̎̂̍̈̑͋̓̀̉̓͝ͅḦ̷̺̩͉̲̏̿Y̴̡̧̧̡̡̛͈̱̱̦̱̼̞͔̘̟̲͙͕͍̻̝̪̖̩̋̐͐͌̒̓͑̒̈́͊͊͘̕̕ͅ ̴͍̥̼̬̲̥̉͆̅͛̅̾͒̋̒̾͐̋̓͗̑͒̄̄̑̔͝C̵̳̻͉͖͉̞̦̮̞͈͓̺̖̓͋͐͛͑́ͅĄ̷̡̡̲͚̟͙̩͙̯͓̪̳͕͕̪́͌Ņ̶̡̛͖̯̣̝͇̪̜̺̩̣̠̳̯̲͔̮͙͉̄̾̌̎͂̅̓ͅT̶̢͕̹̼̜͎̫͇̿̈̇̍̓͜ͅ ̵̛̱̾̐̔̀̏̀̉́̚İ̶̧̨̩̳̗̬̹̼̹̩̣̃̀̊́̓̀̆̕̕̕ͅ ̸̩̻͚̻̻̞̼̞̀̄̀͛̽̒̈́͐̚Ḑ̴̡̛͖͇̤̖̱̍̌́̍̀͗̈́͐̏̐̽̌͐̀͌͠Ị̶̡̖͖̭̺̘̯͎̖̀͊̈́͜E̸̛͉̩̯͍̰̞̳̪̗̞̋͋̈́͌̊̇̈́͂̑̈́͗̽̂͒̕͜͜͠ͅ ̵̨̫̹̥̈́̈́̾̈͑W̴̢̠͚̹͇̪̹͖̲̥͓͖̥̟̬͉̫̬͇̎̂̓̀̈́͂̀́̃̽̈́̆̔̔̎́͘ͅH̸̢̨̡̛̛̞̟̟͍̳͙̙̰̮͓̙̮̘͚̮̹̋̔̈́̿͆̎̀̓̀̏̆̈́́̌̋̃͝͝͠Y̵̨̧̤̹̖͇͇̳͋̏̏̿͌̂ ̷͇̻̙̙̼͓͛̂͑̇́̈́̀͑̈́̾̈́̾̊͜͝C̵̲̜̻̹̦͙̜̍͗̈́̎̅̃̂̔͜A̷̡͈̜͍̣̥̟̳̺̦̙̬̰̤͓̋͑̄͐͋̕͠N̵̢̡̧͈̖̩̦̘͍͓͖͓̼̩̤͙͔̠̟̱̤̟̟̰̓͑̆̿̉͛͗̋̑̋͒͋͂̄̌̚̕͘͝͝͝T̶̨̨͇̝̬̩̠͓̳̘̜̰͇̹͎͖̈́̎͐̐̓͋͆̑̈̈́̍̕̕͜͜͠ ̴̡̧͕̟̯̬̭̻͓̲̹̪̠̹͉͇͔̝̆̈́͐̑́̀̇ͅĨ̸͔̰͛ͅ ̸̛̣̦̮͙͖̟̗̥̺̘͉̪̗̳̯̄̀́͐̾́͑̅͌ͅḐ̴̧̧̡̡̧̺̦̮̹̞̭̞͙̗̜̦̲̈́̾̏̀̅̽̐̄̒̍͗̑̋̔̔̚̚͝͠I̶͍͔̥͕͉̳̗̪̣͕͓̼̽͊̈̎̄̅̓̃̄̂̾̊̋͗̓̋͌͂͘͜E̶̛̫̫͇̲̜̰͇͉͓͔̱͕̹̣͙͚̹͙͎̅̈̔͐̐͌͗͐̽́̈́̿̽̃͆̏̂͗͋̃̑̉̕͜͝ ̷̛͖̼͎̯̺̔̀̏̒́͋̇̒̚̚̕͠Ẇ̸̡̛̠̟̱̙̬͕̝̭͓̥̗͇̥͚̮̼̩̞͚̻̯̏̐̄̿̂̀́̓̆̃͂̑͜͜͝Ḩ̸̢̟̰̰͉̖̞̃͗̋ͅY̸̧̧̨̟̱͇̯̹͍̹͖̠̓͐̈́̊̽̈́͆̊́̅͗̍̃̈́͒͛͗̄́͆̅̚̚͜͝͠ͅ ̸̨̡̣̲̯̞̣͔͖̣̟̳̪̦̘͇̥͖͎͙͑͜C̵̨̛̛̱̰̺̙̝̤͉̞͕̜̰̼͉̲̺͇̤̞͒̈͂͛́̐̓̅͐̿͐̍͛́̈́̆̍͠͝ͅǍ̴̢̨͎͍̲̼̮̫̘͕̣̈͋̉̾̌͐͒̇͑́̋͑͌͌̏̓̾̚N̷̬̣͂̊̉̑̏͌́͐̈́̽͂̈́͘͘͝T̶̛̘̦̦͈͉̮͙̱̼͈̼̮̺̩̲̝̼̬̱͉͕̩̿̍͗̑̐̓͛̿͋̿́́͆͘͜͠ͅ ̷̧̼͔̟͚̗͈̹̩̦̻̰̫͔̠̳̟͇̣̼̓̓̌̄̆̇͛͜I̵̜͍̟̺̯̔̓ ̶̛̮̮͙̭̖̰͖̲͍̰̥́̀̿̈́̀̔̌͌̐́̊̈͘͠D̷̡̧̯̫̗͉́̍̚I̴̧̯̯̝̎̊͛̈́̃̂͒̈́̈͛̃̊͂͆̎̈́̋̀̽̃Ȩ̸̨̛͖͖̞̗͇̀͗͒̈́̊̓̑̑̃̂̍̑͒͋̕͘͝ ̵̢̛͚̻̳̠̹̖̹̤̥̲̰̠̎̂̂͛̇̎͊͋̏̑͛͊̅̄̐͝͝͝Ẃ̸̧̧̛̰̺͓̦̦͍̙̠̲̘̦͇̲̙̩̊̅̃̉͗̃͑͒̋̐͒̑͘͝H̸̡̨̡̟̜͍̲̎̈́̎̽̑̀̓̅́̌͋͆̏͆̃͋̋̊̚͜͠Y̶̢̢͍̮̘̮͎̜̠͈̠̘̭̲̘͚̜̠̠̯͎̺̹̖̭͂̆͆͒͐̃́̄̆͗͑͘ ̴̥̹̞̬̤͖̜̘́͆̓̒̈́͊̈́̓̈́̾̆̓͐͝ͅC̸̛͖̈́̅͂͋̄̋́̎̚͠À̸͕͙̺̩͈͕̻̌̋́̒̔̎̾̂́N̵̛̥͔̺͕͍͕̼̣̦̤̫͙̾̂̾͐̉̎́͆͋̋̔̚͝͝Ṭ̵̤̰̫̮͔͈̗̰͕̮͍̰͚͈͖̳̱̳͊̾́́̓̽̒̈͗͗̀͂̄̌̌̀̂̐͐̒̇͜͠ͅ ̴͕̲̭̘̖͔̥͚̱̽͠Î̴̧̭̭̗̺͇͚̩̹͍̞͍̠̬͎̟̲̹̮̰̮̰̤͗ ̶͚̖͙͔̰͖̳͂̅̔̈́̽̑͘͘͝͝͝ͅD̶̡̨̧̮͔̭̯̜̞͔̞͇̞̓Į̴̡̨̡͈̝̼̺̣̞̠͔͙̟̟͔̘̤̰̙̩͚͐̇͛̌̾͠͝E̵̡̢̢̦̬͉͉͔̟̫͉̳̰̻̦̓͒̈̍̒͘͜͜͝ ̴̢̛̳̣̟̳̣̻͗̐̈͊̉̄̔͆W̷̛̪̦͉͕̮͇̟̱̽̌̌̀̐̎̅̆͗̾̀̅̿̆͋͑̿́̽́̕Ḥ̸̢̨̨̛͎̳͎̝͚͎̼̭͎̬͍̻̞̀̓̋̾̾͑̓̃̑̂̊̾͒̎̓̆͛̃͑͒̚͜͠͠͠Ý̸̢̢͓̳̺͚̬̯͍̟̪͉̼̟̩͉͓̙̗͖͋̀́͂͑̆̚͜͠ͅͅ ̴̧̛̛̭͇̹̙͍̲͉͙͖̭͍̰̬̹̮͙͍̗͉̭͑̓̑̓͗́͂̾͂͗̀͘͜͠ͅC̵̢̨̣̮̹̟̠̘͍͓͌̅̽̈̂̈͗̀͊́͒̇͆͛̃̌̃͛̊͋̓̍̚͘͝ͅÀ̴̡̛́͆͌͋̐̀̐̒͌̀̄͂̓̓͆̍͘̚Ń̵̢̧̥̳̭̩̹̒̾̉̈̉̍͗̽͗̊̔͗̑̔̾̌̑͑͘͝͠T̶̨̯̥͓͚̝̮̪̳͚͎͈̙̬̙̅̋͛͑͂̏̂̍̔̋̌̂̊̽́̅̈́ͅͅ ̶̫̝͈͕̖̾̔̆̇̽̓̈̿̍͛͑̓̾̄͌̀͋͘͠͠I̷̧̧̛̱̞̖̞͙͈̠͇̜͂̔̔̈́͋̑̾͗͆͠ ̸̢̧̨̩̹̥͉͕̤̥͌̓͘͜Ḑ̴̡̝̞͙̘̦̿̋͂͛́́͛İ̷͈͍̗̘̲̝̬̌͛̆̉͊̍̈́̽͋́́͂͗̂̑̚͜͜͝͠͝͝ͅÉ̷͕̩̺̟̫͈͇̈́̀͒͋̽͂̔͐̓͝ ̶̛̞̬̅́̋̓̓͛̒́̔̾̾̍̔́̌̕̕̕̕W̸̞̬͚̞̞̱̦̦̼̥̝̗̻̻̮͇̓̌͒̑̈́͗͆̚̕H̶̡̧̛͚͙̬͈̤̰͚̰̝͕̟͙̪̗̆̎́͆̏͂̉͛͐̿̒̈́͒̋͊̕̚̕̕̚͝Y̵̧̪̠̺̖̣͙͔̲͖̣̿̊̊͂͑̑̑͑͛̇̽ͅ ̵̨̫̭͍͔̥̄̀̂̇̆̆̽̉͊̒̏̇̿̾͒͗̚͝C̸̢̡͓̦͎̭̱̳̻̝̯̪̉̏̽͂̂̑A̸̡͕͚̱̟͉̪̝͈͖̠͙̪̜̤͔̰͍̍̾̒̇̉̓̊̈̌͛́͘̚N̵̢̨̼͍̲̘̝̳̫̺͍̙̞̤̪̤̜͓̰̲͇͐͗̆̌̿̀̅̎̍̕͝͠͠T̴͙̟̳̞͔̻͔͍̥͉̲̩͕̜̲̼̝̳͈͐͑̂̆͒̆͆ ̷̡̛̪̳͓͎̞̝͈͔͈͚̙̠̯̟͚̖͈̓͑͜ͅI̵̮̮̳̗̘̩̥̙̣̳͍̥̪̟̣̟͍̟̰̊̾̓̉͆̀́̈́̇̃̇̉͊̀̊̽͊̏̾̾́̚̚͘ ̸̨̢̢̛̛̙͍̦̤͖͉̳̤̟̿̑͌̽̈̍̈́̆̽̑̐͐̐͗̾̍̔̎̅͘̚͝D̴̝̻̰͎̮̭̝͖͈̜̰̝̩̬̥̮̍̒͌͑͋͐̐͂͜Ĩ̶̘̆̇̄̿̂̂̍͗̂͂͋̓̄̇̽͂͘̕͝͠͠ͅE̶͇̝̺̬̠̲͕̞͓̦͊́͆̊̓̈̂̑̂̏͘̚ ̵̹̰͍̞̙͎̪̹͍̏̓͋̚͝W̵̫̥̞̟̺̮̭̜̣̳͙͔̮̭̙̱͖̟͙͉̣͔͂̽̾̂̿̈͂̚͜Ȟ̶̳̰̥̣͊͂̐̃̊̃Y̷̡̧̛̹͙͍̠̤̞̲̼̤̻̟͓̺͕͐͊͂͊̓̋̂͆͊͗̒͊͌͌̽́̆͊̌͛̽̑̐̍ ̴̨̯͎̟̬̳̇̎́̔͛͊̈́̔͂̾̽͑̽͑̐̏͂C̷̢̡̨̛̭̟̤͎͈̮͍̻̜͚͚̹͉̺̬̝̆͒̚̚͘̚Ȁ̶͖̺̹̦̎̋̓̈́̿͋̽̋͒̈̍̽̓̚͝͝Ṋ̴̲̳̤̠̪̯̲̘̲̼̩͎̃͛̅̈́̀̀͑̐̎̇̋͐̀͑̈́̄̕͘͠ͅŢ̸̧̧̫̩̬͓̼͈͖͈̲͓̜̺͙͉̼̘̂̿̄̓̾̈͌̕̚ ̵̛̖̣̩͓͕̻̫̤͚̤̞̗̪͈̪̟͔̣̣̲̥͍̻̭̿̽̍͆͒͆̃͐̉̈̒̅̈̔͆́̕̚͘͘I̵̧̛͖̰̼͔̔́͒̉͜ ̶̣̖̙͒͑̂̄Ḑ̴̨̢̢̨̢̛̻̳͖͖̫̫͈͍̖͖̩͈̾̐̑͗̈́͋̇̋͊̍̾̈́͋̍͛̑̾͗̇̍͘͘̕ͅͅI̷̧̛̺̺̬̹͓̱̠̭̦̗̰͍̭̗̰̩͍̅̈̆̓̐͐̅̆͌̅̀̆̌̊̄̒͌̊̍̚͘͘͘E̶̛̱̼̺͙̝͉̹͑̽̀͊̓͒̓̉͆̊͋̎͆̽͒̍̍̏̑̉̕͝ ̶̨̡̢̛͓̦̺͙̟͖̫͔͚̜̠̮̞̻̯̯̯̟̹̈́͌̋̈́̽̅̔̄̉͒͗̂̉̚͝W̵̨̡̡̨̘̦̥̯͚̺͜͝ͅH̵̛̗̦͔̟͉̰͖͖̥͚̘̗̪͙̻̪̯̒̑̊̅̀̽̒́͌̎͐͋̂̔̈́̋̒͂̆̅̋̏͋͠Ŷ̶̛̛̖̗͕̤͍̃̆̽̇̐̐͑̇̕͝͝ ̷̡̨̨̪̺͖̳͎͚̗͍̼̞̳̙̤̞͓͆̊̿̏̄͗̆̐̌́̂̓̑̎̕͜C̶̲̟̝̑̔̔̄̂͋́̄̈́̈̔͂̏̒͘͠Ḁ̴̡̧̢̛̛͚̺͖̳͇͚̜̮̞̺͓̹͉̰͉̩̪̯̓͑̈́̓̓̅͌̂͂̅͐̒̎͒̍́͌́̎̈͘͘͠ͅŃ̵̨͎̖̥͙̲̫͍͉̒̽͂͛̆̀̀̽͒̿͛͌̏͆̕̚͜T̷̢̙͇̲͗̋̄͊̿̒̓͗̈̐̍͒́̓̄͛́̏̋̍̑͑̚͝ ̸̨͖̹̦̩̩̣̳͔͖͉̰͙̥̥̤̲̤̙͋̈́̿̔́̀̆̅̎͆̅̊͒͑̍̃͗̓̆̕̕̕͘͜͝͝Ï̴̡̝̹͖̯͔̱̼̖̘̙͕̭̩̯͌̀̀́̿̓͂̆̅̓̆͊͘͘ ̷̧̞͙͕̲͔͈̻̫̘̳͈͍̃̄̀̐̃̀́̀̊̈́̐́͜͜͝D̶̨̧̖͖͍͎͉̦͎͓̯̪̫̲̜̖̻̺̘͇͔̦̘͂̌͌͐͘͘͜ͅI̷̛̹̾̍̓̒̐̒̇̈̔̀̓͌͋͂̈́̉̂͋Ě̴͙̫̺͕̟̗͎̝̖̙͓̰̹̻̼͖͓̣̉̊̓̈́̈̔̋͋̓̏́͛̀͒ ̴̛͎̟̲̤̭͔͆͋͑̓̋̑͊̿̈̍̀̐́̅̾̄̓̋̃͌͠͝Ẉ̴͉̞̠̺̠͎̱̮̠͉̭̣̦̤̞̮̣͚́͆͜͜Ḫ̷̢̡̝̦̘̫̪̟̳͉͇̩̳͉̥̬̠͛͊̂̐͌̄̆ͅͅY̵̨̭͈̙̱͕̼̓̿́̂̆͐̎͒͗́̀͒̾̿̊̄̓̐̀̊͐̈̚̕͜ ̵̡̟̲̟̻͑̏͗̈́̔͒͂̿̇̉̇̅͘̕̕C̶̢̝̞̣̠̭͚͇͇̩͇͇̩͈̰͈̤̱͇̪̽̌̉̀͐̊̾̅̆̌͊̚̕͠ͅÀ̸̫̤̮̰̖̹͇͍͍̼͉̝̈́͌̏̈́̽̔̒̄͑͜͜͝N̴̪͖̱͎̥̭̤̤̳̺̞̼̹͚̟̭̲̲͆͌̔͜͜͜T̷̨̨̧̛͔͓̖͎̺̻͉̺̳͓͕̫̈́̐̏͛̌̓̊̂̇̀̈͋̇͒͒̎̀͋̋̐̀͝ ̶̦̋̈́̊́́͌Į̸̧̨̛͙͚͕̘̪̰͈̮̩̼̠͕̥̣̌̀̔̄̐̉͒̎͌̉͂̀̐͗̑̀͘͜͠ ̴̨̛̻̰̫͔̲̝̱͇̦̱̀͆͌̅̄̿͗̓̀̀̈́̊́͌͘͝D̷͈͈̳̞̠̈́̊̀͋̀̒̀Į̵̡̛̛̼̳̘̱͎͖͍͓̻̗̼͍̝̻̭̔̎̉͆͗̏̍͊̂́͊͌͐̓̽̌̅̚͠͝͠ͅË̸͕̠̭̮̰͑̍̎͊ ̸̨͍̰̻̅̄͌̊̈́̃̆̌̈́͋́͊̉̓̈́̾");
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = Glitch[UnityEngine.Random.Range(0, Glitch.Count)];
    }
}
