using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EdgeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public string color;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            Enemy enemyScript = col.GetComponent<Enemy>();
            if(enemyScript.getColor() == color)
            {
                Destroy(col.gameObject);
                GameController.Instance.numOfEnemiesRemaining--;
            }
            else
            {
                Destroy(transform.parent.gameObject);
                SceneManager.LoadScene(GameController.Instance.thisLevelName);
            }
        }
    }
}
