using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour
{
    #region Variables

    // private string[] scenes = { "Level 1", "Cutscene", "PowerUpScene", "Level 2", "Cutscene", "PowerUpScene", "Level 3", "Cutscene", "PowerUpScene", "Level 4", "Cutscene" };
    public LevelVariables levelVariables;
    public Animator transition;
    Scene currentScene;
    private string nextScene;
    #endregion
    IEnumerator LoadNextSceneAfterDelay(string nextScene, float delay)
    {
        yield return new WaitForSeconds(delay);

        // Load the next scene after the delay
        SceneManager.LoadSceneAsync(nextScene);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        currentScene = SceneManager.GetActiveScene();
        if (collision.CompareTag("Player"))
        {
            // load next scene based on current scene
            if (currentScene.name == SceneNames.Cutscene)
            {
                nextScene = SceneNames.PowerUpScene;
                levelVariables.currentLevelIndex++; // since we've left the level, we can increment the currentLevelIndex
            }
            else if (currentScene.name == SceneNames.PowerUpScene)
            {   // change to some level
                nextScene = SceneNames.Levels[levelVariables.currentLevelIndex];
                GameManager.instance.LevelStart();
            }
            else if (SceneNames.Levels.Contains(currentScene.name))
            {

                if (GameManager.instance.overtime)
                {

                    GameManager.instance.endingVariables.OTCount++;
                }
                else
                {
                    GameManager.instance.endingVariables.Slacker = true;
                }
                GameManager.instance.levelVariables.ExitLevel();
                if (currentScene.name == SceneNames.Level4)
                {
                    nextScene = SceneNames.GoodEnding;
                }
                else
                {
                    // its currently either level 1, 2, or 3.
                    // load cutscene
                    nextScene = SceneNames.Cutscene;
                }

            }
            // fading in and out
            transition.SetTrigger("Start");
            // Start the coroutine to load the next scene after a delay
            StartCoroutine(LoadNextSceneAfterDelay(nextScene, 1f));

        }
    }
    public void StartBadEnding()
    {
        transition.SetTrigger("Start");
        // Start the coroutine to load the next scene after a delay
        StartCoroutine(LoadNextSceneAfterDelay(SceneNames.BadEnding, 1f));
    }
    void Awake()
    {
        GameManager.instance.gameOver.AddListener(StartBadEnding);
    }
}


public static class SceneNames
{
    public static readonly string MainMenu = "MainMenu";
    public static readonly string Level1 = "Level 1";
    public static readonly string Level2 = "Level 2";
    public static readonly string Level3 = "Level 3";
    public static readonly string Level4 = "Level 4";
    public static readonly string Cutscene = "Cutscene";
    public static readonly string PowerUpScene = "PowerUpScene";
    public static readonly string GoodEnding = "GoodEnding";
    public static readonly string BadEnding = "GameOver";
    public static readonly List<string> Levels = new() { Level1, Level2, Level3, Level4 };
}