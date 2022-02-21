using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //health debug
    public Transform pfHealthBar;

    // Start is called before the first frame update
    private void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);

        Transform healtBarTransform = Instantiate(pfHealthBar, new Vector3(0, 10), Quaternion.identity);
        HealthBar healthBar = healtBarTransform.GetComponent<HealthBar>();
        healthBar.Setup(healthSystem);
        
        Debug.Log("Health: " + healthSystem.GetHealth());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            healthSystem.Heal(5f);

            healthBar.Setup(healthSystem);
            Debug.Log("Health: " + healthSystem.GetHealth());
        }
        if (Input.GetKey(KeyCode.N))
        {
            healthSystem.Damage(5f);

            healthBar.Setup(healthSystem);
            Debug.Log("Health: " + healthSystem.GetHealth());
        }
    }
}
