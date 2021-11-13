using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrapsController : MonoBehaviour
{
    public GameObject harmfulTrap;
    public GameObject deadPanel;
    public bool dead;
    void Start()
    {
        harmfulTrap = GameObject.FindGameObjectWithTag("Harmful Trap");
        deadPanel = GameObject.FindGameObjectWithTag("Dead_Panel");
        StartCoroutine(delay());

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            deadPanel.SetActive(true);
            dieResetfunc();
        }
    }
    public void dieResetfunc() //function to reset level after death
    {
        StartCoroutine(waitBeforeReset());
        
    }
    IEnumerator waitBeforeReset()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Main");
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        deadPanel.SetActive(false);
    }
}
