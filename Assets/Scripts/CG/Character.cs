using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float flapHeight;
    public float time_of_startPlay = 300f;
    public float time_of_replay = 600f;
    public GameObject ads_button;
    public GameObject message;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Advertisement.isSupported) Advertisement.Initialize("3416893");
        StartCoroutine(ShowADSCOR());
    }
    IEnumerator ShowADSCOR()
    {
        yield return new WaitForSeconds(time_of_startPlay);
        while (!Advertisement.IsReady())
        {
            yield return null;
        }
        Advertisement.Show();
        yield return new WaitForSeconds(time_of_replay);
        while (!Advertisement.IsReady()) yield return null;
        if (Advertisement.IsReady()) Advertisement.Show();
        yield break;
    }
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);
        }
        if (transform.position.y > 268 || transform.position.y < -229)
        {
            Death();
            #region CheckWin
            if (Input.GetKeyDown(KeyCode.E))
            #endregion
            #region CheckLose
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("YOU LOSE :(");
            }
            #endregion
        }
    }
    public void ShowButtonAds()
    {

    }
    public void Death()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo", new ShowOptions
            {
                resultCallback = result =>
                {
                    if (result == ShowResult.Finished) message.SetActive(true);
                }
            });
        }
        if (trigger.gameObject.tag == "Finish")
        {
            string s = "1";
            int i = int.Parse(s);
            if (SceneManager.GetActiveScene().name == (LevelManager.countUnlockedLevel).ToString())
            {
                LevelManager.countUnlockedLevel++;
                PlayerPrefs.SetInt("Levels", LevelManager.countUnlockedLevel);
            }
            Debug.Log("YOU WIN!!!");
            SceneManager.LoadScene(5);
        }
        if (trigger.gameObject.tag == "INST")
        {
            SceneManager.LoadScene(6);
        }
    }
}