using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity {
public class SoundEffectController : MonoBehaviour
{

    public AudioClip [] sounds;
    public string [] clipNames;
    public AudioSource source;
    
    [YarnCommand("playSound")]
    public void playSound(string effectName) {
        //play sound depending on the name
        for(int i = 0; i < sounds.Length; i++)  {
            if(clipNames[i].Equals(effectName)) {
                source.PlayOneShot(sounds[i]);
            }
        }
    }
}
}
