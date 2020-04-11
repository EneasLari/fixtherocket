using Assets.Scripts.UserSystem.GlobalData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    private AudioSource adSource;
    public AudioClip[] adClips;
    public Slider SoundSlider;
    // Start is called before the first frame update
    void Start()
    {
        adSource = GetComponent<AudioSource>();
        ShuffleClipsArray(adClips);
        if (adSource != null) {
            StartCoroutine(playAudioSequentially());
        } else {
            print("AUDIOSOURCE MISSING");
        }
        adSource.volume = GlobalData.GeneralSettings.Mastervolume;
        SoundSlider.value= GlobalData.GeneralSettings.Mastervolume;
    }


    private void ShuffleClipsArray(AudioClip[] clips) {
        //1.Loop through each AudioClip
        for (int i = 0; i < clips.Length - 1; i++) {
            int j = Random.Range(i, clips.Length);
            AudioClip temp = clips[i];
            clips[i] = clips[j];
            clips[j] = temp;
        }

    }

    IEnumerator playAudioSequentially() {
        yield return null;

        //1.Loop through each AudioClip
        for (int i = 0; i < adClips.Length; i++) {
            //2.Assign current AudioClip to audiosource
            adSource.clip = adClips[i];

            //3.Play Audio
            adSource.Play();

            //4.Wait for it to finish playing
            while (adSource.isPlaying) {
                yield return null;
            }

            //5. Go back to #2 and play the next audio in the adClips array
            if (i == adClips.Length - 1 && !adSource.isPlaying) {
                print("Restart Music");
                i = 0;
            }
        }
    }

    public void soundVolume() {
        if (adSource != null) {
            print(SoundSlider.value);
            adSource.volume = SoundSlider.value;
            GlobalData.GeneralSettings.Mastervolume = adSource.volume;
        }
    }

    public void SetSliderValue() {
        SoundSlider.value= GlobalData.GeneralSettings.Mastervolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
