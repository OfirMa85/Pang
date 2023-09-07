using UnityEngine;

public class LevelController : PangElement
{
    private GameObject loadedLevel;

    public void NextLevel()
    {
        app.model.level.currentLevel++;
        LoadLevel(app.model.level.currentLevel);
    }

    public void LoadLevel(int level)
    {
        int levelIndex = level - 1;
        if (levelIndex >= app.model.level.levels.Length)
        {
            GameWon();
            return;
        }

        StartCountdown();
        DestroyLevel(loadedLevel);
        SpawnLevel(levelIndex);
        app.model.balls.CountBalls();
    }

    private void StartCountdown()
    {
        app.controller.game.AddToPauseStack(1);
        app.view.countdown.StartCountdown();
    }

    private void SpawnLevel(int levelIndex)
    {
        GameObject obj = app.model.level.levels[levelIndex];
        Transform parent = app.model.level.levelParent;
        loadedLevel = Instantiate(obj, parent);
    }

    private void DestroyLevel(GameObject level)
    {
        if (level != null)
        {
            Destroy(level);
        }
    }

    private void GameWon()
    {
        Debug.Log("Game won!");
        GameEvents.gameWonEvent.Invoke();        
    }
}
