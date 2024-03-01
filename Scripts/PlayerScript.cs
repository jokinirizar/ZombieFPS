using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public  float maxHitPoints = 100;
    private  float hitPoints;
    public GameObject deathPanel;
    public float Hitpoints { get { return hitPoints; } set { hitPoints = value; OnHPDown(); } }
    public Slider HPSlider;
    void Start()
    {
        hitPoints = maxHitPoints; 
    }
    public void DealDamage(float damage)
    {
        Hitpoints -= damage;
        HPSlider.value = (hitPoints / maxHitPoints);
    }
    public void OnHPDown()
    { 
        if(hitPoints <= 0) {
            OnPlayerDeath();
        }
    }
    public void OnPlayerDeath()
    {
        deathPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
