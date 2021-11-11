using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SoundManagerScript : MonoBehaviour
{
    GameObject gameManager;
    Menu menuRef;
    public AudioSource streetSoundSource;
    public AudioClip baggrundSound;

    public List<AudioSource> audioSourcesList = new List<AudioSource>();

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        menuRef = gameManager.GetComponent<Menu>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (menuRef.enabled == false) 
        {
            streetSoundSource.PlayOneShot(baggrundSound);
        }
    }

    public void PlayMusic()
    {
        streetSoundSource.PlayOneShot(baggrundSound);
    }

    public void StopAllSounds()
    {
        for (int i = 0; i < audioSourcesList.Count; i++)
        {
            audioSourcesList[i].Stop();
        }
    }
}
