using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [Header("Player Prefabs")]
    [SerializeField] private GameObject[] playerPrefabs; 
    [SerializeField] private Transform spawnPoint;

    void Start()
    {
       
        int index = CharacterSelection.SelectedCharacterIndex;

        
        if (index < playerPrefabs.Length)
        {
            Instantiate(playerPrefabs[index], spawnPoint.position, Quaternion.identity);
        }
    }
}