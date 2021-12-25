using UnityEngine;

namespace Liskov_Substitution
{
    public class React : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            var myGeoObject = col.gameObject.GetComponent<GeoObject>();
        
            if (myGeoObject == null)
                return;
            
            GeoObjectReact(myGeoObject);
        }

        private static void GeoObjectReact(GeoObject myGeoObject)
        {
            Debug.Log("Type: " + myGeoObject.GetType() + " ,ID: " + myGeoObject.id + " ,Sum: " +  myGeoObject.AdditionOfValues());
        }
    }
}
