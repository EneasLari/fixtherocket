using Assets.Scripts.UserSystem.GlobalData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    private AudioSource BackgroundMusicAudioSource;//it is attached in the same gameobject
    public AudioSource RocketSfxAudioSource;//it is attached to the rocket
    public AudioClip[] adClips;
    public Slider SoundSlider;
    // Start is called before the first frame update
    void Start()
    {
        BackgroundMusicAudioSource = GetComponent<AudioSource>();
        ShuffleClipsArray(adClips);
        if (BackgroundMusicAudioSource != null) {
            StartCoroutine(playAudioSequentially());
        } else {
            print("AUDIOSOURCE MISSING");
        }
        BackgroundMusicAudioSource.volume = GlobalData.GeneralSettings.Mastervolume;
        RocketSfxAudioSource.volume = GlobalData.GeneralSettings.Mastervolume;
        SoundSlider.value= GlobalData.GeneralSettings.Mastervolume;
        RocketSfxAudioSource.mute = GlobalData.GeneralSettings.MuteSounds;
        BackgroundMusicAudioSource.mute = GlobalData.GeneralSettings.MuteMusic;
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
            BackgroundMusicAudioSource.clip = adClips[i];

            //3.Play Audio
            BackgroundMusicAudioSource.Play();

            //4.Wait for it to finish playing
            while (BackgroundMusicAudioSource.isPlaying) {
                yield return null;
            }

            //5. Go back to #2 and play the next audio in the adClips array
            if (i == adClips.Length - 1 && !BackgroundMusicAudioSource.isPlaying) {
                print("Restart Music");
                i = 0;
            }
        }
    }

    public void soundVolume() {
        if (BackgroundMusicAudioSource != null) {
            //print(SoundSlider.value);
            BackgroundMusicAudioSource.volume = SoundSlider.value;
            RocketSfxAudioSource.volume = SoundSlider.value;
            GlobalData.GeneralSettings.Mastervolume = BackgroundMusicAudioSource.volume;
        }
    }

    public void SetSliderValue() {
        SoundSlider.value= GlobalData.GeneralSettings.Mastervolume;
    }

    public void MuteSounds() {
        GlobalData.GeneralSettings.MuteSounds = !GlobalData.GeneralSettings.MuteSounds;
        RocketSfxAudioSource.mute= GlobalData.GeneralSettings.MuteSounds;
    }
    public void MuteBackgroundMusic() {
        GlobalData.GeneralSettings.MuteMusic = !GlobalData.GeneralSettings.MuteMusic;
        BackgroundMusicAudioSource.mute = GlobalData.GeneralSettings.MuteMusic;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
