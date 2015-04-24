using UnityEngine;
using System.Collections;

[SerializePrivateVariables]
public class gerenciador_cenario : MonoBehaviour {

    public cenario[] casas;
    private cenario[,] piscina;
    private float tempo, tempoCriacao;
    private int tamanho;

	void Start () {

        piscina = new cenario[casas.GetLength(0), tamanho];

        for (int i = 0; i < casas.GetLength(0); i++)
        {
            for(int j = 0; j < tamanho; j++){
                piscina[i, j] = Instantiate(casas[i]);
            }
        }
	}

    void Update()
    {
        tempo += Time.deltaTime;
        if (tempo >= tempoCriacao)
        {
            if (add_casa())
            {
                tempo -= tempoCriacao;
            }
        }
	}

    bool add_casa()
    {
        int r = Random.Range(0, piscina.GetLength(0));
        
        for (int i = 0; i < piscina.GetLength(1); i++)
        {
            if (!piscina[r, i].estaMovimento())
            {
                piscina[r, i].reset();
                return true;
            }
        }
        return false;
    }
}