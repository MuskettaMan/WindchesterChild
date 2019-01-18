using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    [SerializeField] private List<GameObject> doors = new List<GameObject>();
    [SerializeField] private Camera camera;

    public Camera Camera {
        get {
            return camera;
        }

        private set {
            camera = value;
        }
    }
    
    public List<GameObject> Doors {
        get {
            return doors;
        }

        private set {
            doors = value;
        }
    }

}
