using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RestApiManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string URL;
    [SerializeField] public GameObject Mano;
    [SerializeField] public Text BarajaText;
    /*[SerializeField] public Text Numero1;
    [SerializeField] public GameObject Corazon1;
    [SerializeField] public GameObject Diamante1;
    [SerializeField] public GameObject Pica1;
    [SerializeField] public GameObject Trebol1;
    [SerializeField] public Text Numero2;
    [SerializeField] public GameObject Corazon2;
    [SerializeField] public GameObject Diamante2;
    [SerializeField] public GameObject Pica2;
    [SerializeField] public GameObject Trebol2;
    [SerializeField] public Text Numero3;
    [SerializeField] public GameObject Corazon3;
    [SerializeField] public GameObject Diamante3;
    [SerializeField] public GameObject Pica3;
    [SerializeField] public GameObject Trebol3;
    [SerializeField] public Text Numero4;
    [SerializeField] public GameObject Corazon4;
    [SerializeField] public GameObject Diamante4;
    [SerializeField] public GameObject Pica4;
    [SerializeField] public GameObject Trebol4;
    [SerializeField] public Text Numero5;
    [SerializeField] public GameObject Corazon5;
    [SerializeField] public GameObject Diamante5;
    [SerializeField] public GameObject Pica5;
    [SerializeField] public GameObject Trebol5;
    int counter;*/
    
    void Start()
    {
        
    }


    public void ClickGetCards()
    {
        StartCoroutine(GetCards());
    }

    IEnumerator GetCards()
    {

        string url = URL + "/BarajaPoker";
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();

        if (www.isNetworkError)
        {
            Debug.Log("NETWORK ERROR " + www.error);
        }
        else if (www.responseCode == 200)
        {
            Mano.SetActive(true);
            Debug.Log(www.downloadHandler.text);
            BarajaData resData = JsonUtility.FromJson<BarajaData>(www.downloadHandler.text);

            foreach (Cartas data in resData.BarajaPoker)
            {
                Debug.Log(data.Palo + " | " + data.Numero);
                BarajaText.text += data.Palo + ":  " + data.Numero + "\n";
                /*
                if (counter==0) {
                    
                    if (data.Palo == "Corazon")
                    {
                        Numero1.color = Color.red;
                        Corazon1.SetActive(true);
                    }
                    if (data.Palo == "Diamante")
                    {
                        Numero1.color = Color.red;
                        Diamante1.SetActive(true);
                    }
                    if (data.Palo == "Pica")
                    {
                        Pica1.SetActive(true);
                    }
                    if (data.Palo == "Trebol")
                    {
                        Trebol1.SetActive(true);
                    }

                    Numero1.text += data.Numero;

                    counter = counter+1;
                }
                if (counter == 1)
                {

                    if (data.Palo == "Corazon")
                    {
                        Numero2.color = Color.red;
                        Corazon2.SetActive(true);
                    }
                    if (data.Palo == "Diamante")
                    {
                        Numero2.color = Color.red;
                        Diamante2.SetActive(true);
                    }
                    if (data.Palo == "Pica")
                    {
                        Pica2.SetActive(true);
                    }
                    if (data.Palo == "Trebol")
                    {
                        Trebol2.SetActive(true);
                    }

                    Numero2.text += data.Numero;

                    counter = counter + 1;
                }
                if (counter == 2)
                {

                    if (data.Palo == "Corazon")
                    {
                        Numero3.color = Color.red;
                        Corazon3.SetActive(true);
                    }
                    if (data.Palo == "Diamante")
                    {
                        Numero3.color = Color.red;
                        Diamante3.SetActive(true);
                    }
                    if (data.Palo == "Pica")
                    {
                        Pica3.SetActive(true);
                    }
                    if (data.Palo == "Trebol")
                    {
                        Trebol3.SetActive(true);
                    }

                    Numero3.text += data.Numero;

                    counter = counter + 1;
                }
                if (counter == 3)
                {

                    if (data.Palo == "Corazon")
                    {
                        Numero4.color = Color.red;
                        Corazon4.SetActive(true);
                    }
                    if (data.Palo == "Diamante")
                    {
                        Numero4.color = Color.red;
                        Diamante4.SetActive(true);
                    }
                    if (data.Palo == "Pica")
                    {
                        Pica4.SetActive(true);
                    }
                    if (data.Palo == "Trebol")
                    {
                        Trebol4.SetActive(true);
                    }

                    Numero4.text += data.Numero;

                    counter = counter + 1;
                }
                else
                {
                    if (data.Palo == "Corazon")
                    {
                        Numero5.color = Color.red;
                        Corazon5.SetActive(true);
                    }
                    if (data.Palo == "Diamante")
                    {
                        Numero5.color = Color.red;
                        Diamante5.SetActive(true);
                    }
                    if (data.Palo == "Pica")
                    {
                        Pica5.SetActive(true);
                    }
                    if (data.Palo == "Trebol")
                    {
                        Trebol5.SetActive(true);
                    }

                    Numero5.text += data.Numero;

                    counter = 0;
                }*/

            }
        }
        else
        {
            Debug.Log(www.error);
        }
    }
}

[System.Serializable]
public class Cartas
{
    public string Palo;
    public string Numero;
}
[System.Serializable]
public class BarajaData
{
    public Cartas[] BarajaPoker;
}
