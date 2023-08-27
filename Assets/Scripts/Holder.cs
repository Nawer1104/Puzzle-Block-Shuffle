using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Show()
    {
        StartCoroutine(PlayAnim());
    }

    IEnumerator PlayAnim()
    {
        anim.SetTrigger("Show");


        yield return new WaitForSeconds(2);

        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].holders.Remove(this);
    }

}
