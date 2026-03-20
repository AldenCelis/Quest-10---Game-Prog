using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMenu : MonoBehaviour
{
    public void SelectFire()
    {
        CharacterSelection.SelectedCharacterIndex = 0;
        StartGame();
    }

    public void SelectWater()
    {
        CharacterSelection.SelectedCharacterIndex = 1;
        StartGame();
    }

    public void SelectGrass()
    {
        CharacterSelection.SelectedCharacterIndex = 2;
        StartGame();
    }

    private void StartGame()
    {

        SceneManager.LoadScene("GAMEPLAY");
    }
}