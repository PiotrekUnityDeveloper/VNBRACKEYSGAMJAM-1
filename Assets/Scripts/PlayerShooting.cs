using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private GameObject bulletspawner;

    private float bulletSpawnOffset = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float targetangle = Mathf.Atan2(positionOnScreen.y - mouseOnScreen.y, positionOnScreen.x - mouseOnScreen.x) * Mathf.Rad2Deg;

        this.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, targetangle)); //change ONLY the z rotation

        if(Input.GetMouseButtonDown(0))
        {
            //shoot!
            Shoot();
        }
    }

    private List<GameObject> instantiatedBullets = new List<GameObject>();

    public void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, new Vector2(bulletspawner.transform.position.x, bulletspawner.transform.position.y), Quaternion.identity);
        newBullet.transform.rotation = bulletspawner.transform.rotation;
        instantiatedBullets.Add(newBullet);

        //nice
    }

    public void DestroyAllBullets()
    {
        foreach(GameObject g in instantiatedBullets)
        {
            /*
            if(g.active == true)
            {
                Destroy
            }
            */

            Destroy(g);
        }
    }
}
