using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Csgo : MonoBehaviour
{

    static int score = 0;
    static int bullets = 30;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI bulletsText;
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        score = score + 100;
        bullets = bullets - 1;
        moneyText.text = "$" + score;
        bulletsText.text = bullets + "";
        Destroy(gameObject);
        Destroy(image);

    }
}
