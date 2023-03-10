using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int itemCounter = 0;
    public int totalItems = 1;
    public int level;
    public TextMeshProUGUI itemCounterUI;
    public TextMeshProUGUI levelUI;
    public Image livesUI;
    public Sprite[] livesSprites;
    private int lives = 3;
    public GameObject door;
    private void Awake()
    {
        if (FindObjectsOfType<GameManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        itemCounterUI.text = "Items Found: " + itemCounter + "/" + totalItems;
        levelUI.text = "Level " + level;
        livesUI.sprite = livesSprites[lives];
    }
    public void IncrementItemCounter(){
        itemCounter+=1;
        itemCounterUI.text = "Items Found: " + itemCounter + "/" + totalItems;
        if(totalItems == itemCounter){
            Instantiate(door);
        }
    }
    public void DecrementLives(){
        lives -=1;
        if (lives == 0){
            SceneManager.LoadScene("Game Over");
        }
        livesUI.sprite = livesSprites[lives];
    }
    public bool checkDoor(){
        return totalItems == itemCounter; 
    }
    // Update is called once per frame
    
    public void nextLevel(){
        if (itemCounter == totalItems){
            if (level == 1){
                SceneManager.LoadScene("Level 2");
            }
            else if (level == 2) {
                SceneManager.LoadScene("Level 3");
            }
            else if (level == 3) {
                SceneManager.LoadScene("Level 4");
            }
            else if (level == 4) {
                SceneManager.LoadScene("Level 5");
            }
            else {
                SceneManager.LoadScene("Game Over");
            }
        }
        Destroy(gameObject);
    }
}
