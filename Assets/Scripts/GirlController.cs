using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlController : MonoBehaviour {
    [SerializeField]
    GameObject[] lifes;

    int livesNumber;

    private void Start() {
        livesNumber = 3;

        foreach (GameObject life in lifes)
            life.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.name.Equals("Hand")) {
            livesNumber -= 1;
            lifes[livesNumber].SetActive(false);

            if (livesNumber <= 0) {
                ZombieController.isAttacking = false;
                Destroy(gameObject);
            }
        }
    }
}
