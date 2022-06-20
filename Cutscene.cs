using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    [SerializeField] private GameObject cutSceneCamera;
    [SerializeField] private GameObject gameCamera;
    [SerializeField] private GameObject cutscene;
    [SerializeField] private Animator cutsceneAnim;
    [SerializeField] private GameObject trigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            trigger.SetActive(false);
            gameCamera.SetActive(false);
            cutscene.SetActive(true);
            cutSceneCamera.SetActive(true);
            PlayerMovement.isControlled = false;
            cutsceneAnim.SetTrigger("Appearing");
        }
    }

    public void CutSceneEnd()
    {
        gameCamera.SetActive(true);
        cutSceneCamera.SetActive(false);
        PlayerMovement.isControlled = true;
        cutscene.SetActive(false);
    }
}
