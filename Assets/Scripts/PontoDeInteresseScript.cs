using UnityEngine;

public class PontoDeInteresseScript : MonoBehaviour
{
    public GameObject pontoDeInteresse;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        pontoDeInteresse.SetActive(true);
    }

     private void OnTriggerExit(Collider other)
    {
        pontoDeInteresse.SetActive(false);
    }
}
