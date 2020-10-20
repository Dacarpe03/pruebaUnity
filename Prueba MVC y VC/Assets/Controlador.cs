using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public List<FiguraVista> figuras;
    public FiguraModelo figuraModelo;
    public FiguraVista figuraPrefab;
    // Start is called before the first frame update
    void Start()
    {
        figuraModelo = new FiguraModelo();
        figuraPrefab = Instantiate(figuraPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        figuraModelo.Move();
        figuraPrefab.Move(figuraModelo.Position);
    }
}
