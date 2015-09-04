using UnityEngine;
using System.Collections;

public class DescriptionController : MonoBehaviour {

    const string FADEIN = "FadeIn";
    const string FADEOUT = "FadeOut";
    const string VISIBLE = "IsVisible";

    public Animator anim;

    private bool isVisible = true;

    public void FadeIn()
    {
        //Debug.Assert(anim != null);

        if (isVisible)
            return;
 
        Debug.Log(FADEIN);
        
        anim.SetTrigger(FADEIN);

        isVisible = true;

        anim.SetBool(VISIBLE, isVisible);
    }

    public void FadeOut()
    {
        //Debug.Assert(anim != null);

        if (!isVisible)
            return;

        Debug.Log(FADEOUT);
        
        anim.SetTrigger(FADEOUT);

        isVisible = false;
        
        anim.SetBool(VISIBLE, isVisible);
    }


    void OnGUI()
    {
        if (GUILayout.Button(FADEIN))
        {
            FadeIn();
        }

        if (GUILayout.Button(FADEOUT))
        {
            FadeOut();
        }
    }
}
