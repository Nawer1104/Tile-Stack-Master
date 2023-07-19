using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<Board> boards;

    private int startIndex = 0;

    private int currentIndex = 0;

    private void Awake()
    {
        boards[startIndex].gameObject.SetActive(true);

        currentIndex = startIndex;
    }

    public void NextLevel()
    {
        boards[currentIndex].gameObject.SetActive(false);

        foreach(Tile tile in boards[currentIndex].tiles)
        {
            tile.GetComponent<Animator>().SetBool("IsFlip", false);
        }

        OpenNextLevel();
    }

    public void OpenNextLevel()
    {
        currentIndex += 1;

        if (currentIndex == 3)
        {
            currentIndex = 0;
        } 

        boards[currentIndex].gameObject.SetActive(true);
    }
}
