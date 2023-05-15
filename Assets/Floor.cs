
using UnityEngine;
using TMPro;
public class Floor : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private TMP_Text[] LR;
        
    private void Awake()
    {
        char[] symbol = { '+', '-', '×', '÷' };
        foreach (var VARIABLE in LR)
        {
            string output = "";
            int sign = Random.Range(0, 4);
            output += symbol[sign];
            switch (sign)
            {
                case 0:case 1:
                    output += Random.Range(1, 50);
                    break;
                case 2:case 3:
                    output += Random.Range(1, 6);
                    break;
            }
            VARIABLE.text = output;
        }
    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if(transform.position.x > 10) Destroy(this.gameObject);
    }
}
