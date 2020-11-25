using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies;
    [SerializeField] private GameObject palanca;

    private void Update()
    {
        if (enemies.Count == 3)
        {
            palanca.SetActive(true);
        }
        else if (enemies.Count == 0)
        {
            // Activa Puerta
        }
    }

    public void SearchEnemy(GameObject enemy)
    {
        for (int contador = 0; contador < enemies.Count; contador++)
        {
            if (enemies[contador].gameObject.name == enemy.name) DeleteEnemy(contador);
        }
    }

    private void DeleteEnemy(int index)
    {
        enemies.RemoveAt(index);
    }

    public int GetEnemiesAmount()
    {
        return enemies.Count;
    }

}
