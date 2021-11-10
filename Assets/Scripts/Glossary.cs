using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int numberC = 3;
    private float numberA = 5.0f;
    private float numberB = 4.5f;
    private bool b = false;

    public GameObject playerPig;
    private Sprite piggySprite;
    public color piggyColor;


    // Start is called before the first frame update
    private void Start()
    {
        piggyColor = GameObject.Find("playerPig").GetComponent<SpriteRenderer>().color;
        //piggySprite = playerPig.GetComponent<SpriteRenderer>().sprite;
        AddNumbers();
    }

    // Update is called once per frame
    public void AddNumbers()
    {
        //float x = numberA + numberB / 2;
        float y = numberA + GetNumberDivided2(numberB);
        Vector3 vec = new Vector3(0, 5.3f, 1.11f);

        float q = vec.z + vec.y. vec.x;
        Debug.Log(q);

    }

    public float GetNumberDivided2(float num)
    {
        float value = 0;
        if (num >= 0)
        {
            value = num /2;
        }
        else
        {
            value = num *2;
        }
        return value;
    }

}
