using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CodigoPlayer1 : MonoBehaviour
{
    public float velocidadInicial;
    public float distancia;
    public float aceleracion;
    public float tiempo;
    float saveTime;
    Rigidbody rb;

    void Start()
    {
        //distancia = velocidadInicial*tiempo+((aceleracion*(Mathf.Pow(tiempo,2)))/2);
        rb= GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        //tiempo = Mathf.Clamp(saveTime*Time.deltaTime,1,saveTime);
        //tiempo =tiempo*Time.deltaTime+1;
        //tiempo +=Time.deltaTime;
        MRUV();
    }
    void FixedUpdate(){
        rb.velocity=new Vector3(distancia,0,0);
    }
    void MRUV(){
        distancia = (velocidadInicial*tiempo)+(aceleracion*Mathf.Pow(tiempo,2))*aceleracion*0.5f;
    }

    public void SetInputAceleracion(string dato){
        aceleracion =int.Parse(dato);
    }
    public void SetInputTiempo(string dato){
        tiempo =int.Parse(dato);
    }
    public void SetInputVelocidadInicial(string dato){
        velocidadInicial =int.Parse(dato);
    }
}
