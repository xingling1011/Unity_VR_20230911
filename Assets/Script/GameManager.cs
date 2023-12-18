
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //單例模式: 在遊戲中只有一個存在時適用，例如GM
    //
    public static GameManager instance;
    [SerializeField,Header("畫布結束畫面")]
    private CanvasGroup groupFinal;
    [SerializeField, Header("結束標題")]
    private TextMeshProUGUI textFinalTitle;
    [SerializeField, Header("按鈕重新遊戲")]
    private Button btnReplay; 
    [SerializeField, Header("按鈕離開遊戲")]
    private Button btnQuit;
    [SerializeField,Header("手槍系統")]
    private Firesystem fireSystem;

    private void Awake()
    {
        instance = this;
        btnQuit.onClick.AddListener(Quit);
        btnReplay.onClick.AddListener(Replay);
        Time.timeScale = 1;
    }

    private void Quit()
    {
        Application.Quit();
    }

    private void Replay()
    {
        SceneManager.LoadScene("後室");
    }


    public void StartShowFinal(string finalTitle)
    {
        //更新結束標題文字 = 結束標題參數
        textFinalTitle.text = finalTitle;
        //開始淡入
        StartCoroutine(FadeIn());
        //關閉開槍系統
        fireSystem.enabled = false;
        
        //時間暫停
        Time.timeScale = 0;

    }

    private IEnumerator FadeIn()
    {
        for (int i = 0;i<10;i++)
        {
            //結束畫布群組 透明度 遞增0.1
            groupFinal.alpha += 0.1f;
            yield return new WaitForSecondsRealtime(0.03f);
        }
        groupFinal.interactable = true;
        groupFinal.blocksRaycasts = true;

        Cursor.lockState = CursorLockMode.Confined;
        
    }
}
