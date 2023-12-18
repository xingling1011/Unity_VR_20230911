
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //��ҼҦ�: �b�C�����u���@�Ӧs�b�ɾA�ΡA�ҦpGM
    //
    public static GameManager instance;
    [SerializeField,Header("�e�������e��")]
    private CanvasGroup groupFinal;
    [SerializeField, Header("�������D")]
    private TextMeshProUGUI textFinalTitle;
    [SerializeField, Header("���s���s�C��")]
    private Button btnReplay; 
    [SerializeField, Header("���s���}�C��")]
    private Button btnQuit;
    [SerializeField,Header("��j�t��")]
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
        SceneManager.LoadScene("���");
    }


    public void StartShowFinal(string finalTitle)
    {
        //��s�������D��r = �������D�Ѽ�
        textFinalTitle.text = finalTitle;
        //�}�l�H�J
        StartCoroutine(FadeIn());
        //�����}�j�t��
        fireSystem.enabled = false;
        
        //�ɶ��Ȱ�
        Time.timeScale = 0;

    }

    private IEnumerator FadeIn()
    {
        for (int i = 0;i<10;i++)
        {
            //�����e���s�� �z���� ���W0.1
            groupFinal.alpha += 0.1f;
            yield return new WaitForSecondsRealtime(0.03f);
        }
        groupFinal.interactable = true;
        groupFinal.blocksRaycasts = true;

        Cursor.lockState = CursorLockMode.Confined;
        
    }
}
