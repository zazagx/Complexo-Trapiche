using UnityEngine;

public class PontoInteresse : MonoBehaviour
{
    public GameObject painel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        painel.SetActive(true);
    }
}
