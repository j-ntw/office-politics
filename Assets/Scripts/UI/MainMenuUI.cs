using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public Animator transition;
    public GameObject controlsPanel;
    public GameObject mapPanel;
    public GameObject shade;
    public GameObject notifsButton;
    public GameObject AchievementsPage;
    public GameObject creditsPage;
    public void PlayGame()
    {
        GameManager.instance.LevelStart();
        // fading in and out
        transition.SetTrigger("Start");
        StartCoroutine(LoadNextSceneAfterDelay("PowerUpScene", 0.5f));

        // sfx for main menu click "start work"
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuClick);
    }
    IEnumerator LoadNextSceneAfterDelay(string nextScene, float delay)
    {
        yield return new WaitForSeconds(delay);

        // Load the next scene after the delay
        SceneManager.LoadSceneAsync(nextScene);
    }
    public void QuitGame() => Application.Quit();

    public void Controls()
    {
        // Ensure the panel is initially at scale zero
        controlsPanel.transform.localScale = Vector3.zero;

        // Activate the panel
        controlsPanel.SetActive(true);

        // Start the opening animation
        controlsPanel.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        shade.SetActive(true);

        // sfx for pause menu click "controls"
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuClick);
    }
    public void CloseControls()
    {
        controlsPanel.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo().setOnComplete(() =>
        {
            controlsPanel.SetActive(false);
        });
        shade.SetActive(false);
        notifsButton.SetActive(false);

        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuBack);
    }
    public void Map()
    {
        // Ensure the panel is initially at scale zero
        mapPanel.transform.localScale = Vector3.zero;

        // Activate the panel
        mapPanel.SetActive(true);

        // Start the opening animation
        mapPanel.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuClick);
    }
    public void CloseMap()
    {
        mapPanel.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo().setOnComplete(() =>
        {
            mapPanel.SetActive(false);
        });
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuBack);
    }
    public void OpenAchievements()
    {
        // Ensure the panel is initially at scale zero
        AchievementsPage.transform.localScale = Vector3.zero;

        // Activate the panel
        AchievementsPage.SetActive(true);

        // Start the opening animation
        AchievementsPage.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuClick);
    }
    public void CloseAchievements()
    {
        AchievementsPage.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo().setOnComplete(() =>
        {
            AchievementsPage.SetActive(false);
        });
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuBack);
    }

    public void OpenCredits()
    {
        // Ensure the panel is initially at scale zero
        creditsPage.transform.localScale = Vector3.zero;

        // Activate the panel
        creditsPage.SetActive(true);

        // Start the opening animation
        creditsPage.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuClick);
    }
    public void CloseCredit()
    {
        creditsPage.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo().setOnComplete(() =>
        {
            creditsPage.SetActive(false);
        });
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.menuBack);
    }
}
