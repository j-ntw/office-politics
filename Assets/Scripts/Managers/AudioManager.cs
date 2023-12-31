using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    /* Description:
    This AudioManager is subscribed to the "onPlayAudioElement" AudioElementGameEvent.

    Any script that needs an AudioClip to be played would reference the respective AudioElement from the
    "AudioElements" scriptable object when raising the "onPlayAudioElement" AudioElementGameEvent through the
    GameManager's "PlayAudioElement(AudioElement audioElement)" function.

    The AudioManager chooses the appropriate AudioSource to play the raised AudioElement's AudioClip based on the
    AudioElement's AudioType. Each AudioSource is responsible for routing the AudioClip to the appropriate Audio Mixer
    group via its assigned outputAudioMixerGroup in Unity's Inspector.
    */

    /* Note:
    For this class, abbreviations like SFX are treated as normal words for better readability in the code editor.
     - e.g., "playerSfxAudioSource" instead of "playerSFXAudioSource"
    */

    public AudioElements audioElements;

    // audio sources
    private AudioSource bgmAudioSource;
    private AudioSource gameplayBgmIntensity1AudioSource;
    private AudioSource gameplayBgmIntensity2AudioSource;
    private AudioSource gameplayBgmIntensity3AudioSource;
    private AudioSource userInterfaceSfxAudioSource;
    private AudioSource playerSfxAudioSource;
    private AudioSource enemySfxAudioSource;
    private AudioSource nonPlayableCharacterSfxAudioSource;
    private AudioSource interactionSfxAudioSource;

    void Awake()
    {
        bgmAudioSource = transform.Find("BGM").GetComponent<AudioSource>();
        gameplayBgmIntensity1AudioSource = transform.Find("BGM").transform.Find("Gameplay BGM Intensity 1").GetComponent<AudioSource>();
        gameplayBgmIntensity2AudioSource = transform.Find("BGM").transform.Find("Gameplay BGM Intensity 2").GetComponent<AudioSource>();
        gameplayBgmIntensity3AudioSource = transform.Find("BGM").transform.Find("Gameplay BGM Intensity 3").GetComponent<AudioSource>();
        userInterfaceSfxAudioSource = transform.Find("UI SFX").GetComponent<AudioSource>();
        playerSfxAudioSource = transform.Find("Player SFX").GetComponent<AudioSource>();
        enemySfxAudioSource = transform.Find("Enemy SFX").GetComponent<AudioSource>();
        nonPlayableCharacterSfxAudioSource = transform.Find("NPC SFX").GetComponent<AudioSource>();
        interactionSfxAudioSource = transform.Find("Interaction SFX").GetComponent<AudioSource>();
    }


    void Start()
    {
        // wanted to use switch-case, but it does not work with SceneNames.MainMenu because "A
        // constant value of type 'string' is expected"
        if (SceneManager.GetActiveScene().name == SceneNames.MainMenu)
        {
            PlayAudioElement(audioElements.startMenuBGM);
        }
        else if (SceneManager.GetActiveScene().name == SceneNames.PowerUpScene)
        {
            PlayAudioElement(audioElements.pantryBGM);
        }
        else if (SceneManager.GetActiveScene().name == SceneNames.Level1 ||
            SceneManager.GetActiveScene().name == SceneNames.Level2 ||
            SceneManager.GetActiveScene().name == SceneNames.Level3 ||
            SceneManager.GetActiveScene().name == SceneNames.Level4)
        {
            PlayAudioElement(audioElements.lobbyBGM);
        }
        else if (SceneManager.GetActiveScene().name == SceneNames.Cutscene)
        {
            PlayAudioElement(audioElements.bedroomBGM);
        }
        else if (SceneManager.GetActiveScene().name == SceneNames.BadEnding)
        {
            PlayAudioElement(audioElements.badEndingBGM);
        }
        else if (SceneManager.GetActiveScene().name == SceneNames.GoodEnding)
        {
            PlayAudioElement(audioElements.goodEndingBGM);
            PlayAudioElement(audioElements.phoneCall);
        }
    }

    // Play given clip through correct audio source
    public void PlayAudioElement(AudioElement audioElement)
    {
        switch (audioElement.audioType)
        {
            case AudioType.BGM:
                if (audioElement.Equals(audioElements.badEndingBGM))
                {
                    bgmAudioSource.PlayOneShot(audioElement.audioClip);
                }
                else
                {
                    bgmAudioSource.clip = audioElement.audioClip;
                    bgmAudioSource.Play();
                }
                break;

            case AudioType.gameplayBGMIntensity1:
                gameplayBgmIntensity1AudioSource.clip = audioElement.audioClip;
                gameplayBgmIntensity1AudioSource.Play();
                break;

            case AudioType.gameplayBGMIntensity2:
                gameplayBgmIntensity2AudioSource.clip = audioElement.audioClip;
                gameplayBgmIntensity2AudioSource.Play();
                break;

            case AudioType.gameplayBGMIntensity3:
                gameplayBgmIntensity3AudioSource.clip = audioElement.audioClip;
                gameplayBgmIntensity3AudioSource.Play();
                break;

            case AudioType.userInterfaceSFX:
                if (audioElement.Equals(audioElements.phoneCall))
                {
                    userInterfaceSfxAudioSource.clip = audioElements.phoneCall.audioClip;

                    if (!userInterfaceSfxAudioSource.isPlaying)
                    {
                        userInterfaceSfxAudioSource.Play();
                    }
                }
                else if (audioElement.Equals(audioElements.stopPhoneCall))
                {
                    userInterfaceSfxAudioSource.clip = audioElements.stopPhoneCall.audioClip;
                }
                else
                {
                    userInterfaceSfxAudioSource.PlayOneShot(audioElement.audioClip);
                }
                break;

            case AudioType.playerSFX:
                if (audioElement.Equals(audioElements.playerWalk))
                {
                    playerSfxAudioSource.clip = audioElements.playerWalk.audioClip;

                    if (!playerSfxAudioSource.isPlaying)
                    {
                        playerSfxAudioSource.Play();
                    }
                }
                else if (audioElement.Equals(audioElements.playerStop))
                {
                    playerSfxAudioSource.clip = audioElements.playerStop.audioClip;
                }
                else
                {
                    playerSfxAudioSource.PlayOneShot(audioElement.audioClip);
                }
                break;

            case AudioType.enemySFX:
                enemySfxAudioSource.PlayOneShot(audioElement.audioClip);
                break;

            case AudioType.nonPlayableCharaterSFX:
                nonPlayableCharacterSfxAudioSource.PlayOneShot(audioElement.audioClip);
                break;

            case AudioType.interactionSFX:
                interactionSfxAudioSource.PlayOneShot(audioElement.audioClip);
                break;

            default:
                // Debug.Log("Error in AudioManager");
                break;
        }
    }
}
