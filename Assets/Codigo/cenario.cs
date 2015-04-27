using UnityEngine;
using System.Collections;

[SerializePrivateVariables]
public class cenario : MonoBehaviour {
    private float velocidade;
    private static Vector2 posicaoInicial;
    private bool emloop;
    private bool emMovimento;
    public tipo_cenario tipo;

	void Start () {
        posicaoInicial = Camera.main.ScreenToWorldPoint(new Vector2(2 * Screen.width, 0));
        posicaoInicial = new Vector2(posicaoInicial.x, 0);
	}
	
	void Update () {
        if (emMovimento)
        {
            transform.Translate(-Vector2.right * velocidade * Time.deltaTime);

            if (SaiuTela())
            {
                if (emloop)
                {
                    reset();
                }
                else
                {
                    emMovimento = false;
                }
            }
        }
	}

    bool SaiuTela()
    {
        float x = Camera.main.WorldToScreenPoint(transform.position).x;

        return x < 0;//-Screen.width;// || x > Screen.width;
    }

    public void reset(){
        emMovimento = true;
        //transform.position = posicaoInicial;
        transform.position = new Vector3(posicaoInicial.x, transform.position.y, transform.position.z);

    }

    public bool estaMovimento()
    {
        return emMovimento;
    }
}

public enum tipo_cenario
{
    casa_1 = 0,
    casa_2 = 1,
    case_3 = 2,
    casa_4 = 3,
    casa_5 = 4
};