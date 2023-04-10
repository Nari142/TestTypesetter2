using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    private float f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        StartCoroutine(WaitSecond());
    }

    IEnumerator WaitSecond()
    {
        while (true)
        {
            for(f = 0.05f; f <=1; f+= 0.05f)
            {
                Color color = sprite.material.color;
                color.a = f;
                sprite.material.color = color;
                yield return new WaitForSeconds(0.05f);

            }
            for(f = 1f; f>= -0.05; f -= 0.05f)
            {
                Color color = sprite.material.color;
                color.a = f;
                sprite.material.color = color;
                yield return new WaitForSeconds(0.05f);
            }
        }
    }
}
