using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthBarPer : MonoBehaviour
{
    [SerializeField]
    private Image foregroundImage;
    [SerializeField]
    private float UpdateSpeedSeconds = 0.5f;
   
    private void Awake()
    {
        GetComponentInParent<HealthBar>().OnHealtPctChanged += HandleHealthChanged;
      
    }
    private void HandleHealthChanged(float pct)
    {
        StartCoroutine(ChangeToPct(pct));
    }
    private IEnumerator ChangeToPct(float pct)
    {
        float preChangePct = foregroundImage.fillAmount;
        float elapsed = 0f;
        while(elapsed<UpdateSpeedSeconds)
        {
            elapsed += Time.deltaTime;
            foregroundImage.fillAmount = Mathf.Lerp(preChangePct, pct, elapsed / UpdateSpeedSeconds);
            yield return null;
        }
        foregroundImage.fillAmount = pct;
    }
    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, 0);
    }
    private void Update()
    {
        if(foregroundImage.fillAmount==0)
        {
            SceneManager.LoadScene("Finish");
        }
    }
}
