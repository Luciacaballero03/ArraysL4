using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public Enemy[] enemies;
    public int defaultDamagePointsValue = 5;
    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = enemies.Length -1;
        enemies = FindObjectsOfType<Enemy>();
        // establecer el valor de damagePoints de todos los elementos a un número cualquiera
        SetDamagePointsTo(defaultDamagePointsValue);
        // DesactivateFirstElement(enemies);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (contador >= 0)
            {
                enemies[contador].gameObject.SetActive(false);
                contador--;
            }
        }
    }

    void SetDamagePointsTo(int value)
    {
        for (int i = 0; i<enemies.Length; i++){
            enemies[i].damagePoints = value;
        }
    }

    void DesactivateFirstElement(Enemy[] array)
    {
        array[0].gameObject.SetActive(false);
    }

    
}
