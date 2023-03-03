using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int itemCounter = 0;
    int totalItems = 10;
    private int level = 1;
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
    void Update()
    {
#if !UNITY_WEBGL
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
#endif
    }
    
    void nextLevel(){
        if (level == 0){
            SceneManager.LoadScene("Level 1");
        }
        else if (level == 1) {
            SceneManager.LoadScene("Level 2");
        }
        else {
            SceneManager.LoadScene("Over");
        }
    }
}
