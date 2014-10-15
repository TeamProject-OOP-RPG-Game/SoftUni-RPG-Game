using UnityEngine;
using System.Collections;

public interface ICollidable {
    void OnTriggerEnter(Collider other);
    void OnTriggerExit(Collider other);
}
