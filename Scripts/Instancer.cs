using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Instancer : ScriptableObject
{
   //MonoBehavoiur are huge no need to deal with it when you don't have too

   public GameObject prefab;
   private int num;
   
   public void CreateInstance()
   {
      Instantiate(prefab);
   }

   public void CreateInstance(Vector3Data obj )
   {
      Instantiate(prefab, obj.value, Quaternion.identity);
      //Quaternion is a way of rotation but for this its keeping its values 0
   }

   public void CreateInstanceFromList(Vector3DataList obj)
   {
      foreach (var t in obj.vector3List)
      {
         Instantiate(prefab, t.value, Quaternion.identity);
      }
   }
   
   
   
   public void CreateInstanceFromListCounting(Vector3DataList obj)
   {
      Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
      num++;
      if (num == obj.vector3List.Count)
      {
         num = 0;
      }

   }
   public void CreateInstanceListRandomly(Vector3DataList obj)
   {
      num = Random.Range(0, obj.vector3List.Count - 1);
      Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
     

   }
}

