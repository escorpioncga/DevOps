using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Baile1 : MonoBehaviour
{
   GameObject Efectos;
   public List<GameObject> Fx;
    // Start is called before the first frame update
    void Start()
    {
       Efectos=transform.GetChild(2).gameObject;
       for(int i=0;i<3;i++)
         this.Fx.Add(Efectos.transform.GetChild(i).gameObject);
    }

    //Doctor Mauricio ALba
    public ParticleSystem jurado1()
    {
      return null;
     }
    //Doctor Oscar Franco
    public ParticleSystem jurado2()
    {
     return null;
    }
    //Doctor Luis Botia
    public ParticleSystem jurado3()
    {
      return null;
    }
}
