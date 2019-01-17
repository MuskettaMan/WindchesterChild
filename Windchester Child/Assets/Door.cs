﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    private RoomManager roomManager;
    [SerializeField] private MapManager mapManager;

    private Vector2 currentPosition;
    private Vector2 nextPosition;

    private GameObject nextDoor;

    private Direction dir;

    enum Direction {
        Down,
        Right,
        Up,
        Left
    }

    private void Start() {
        roomManager = transform.parent.GetComponent<RoomManager>();
        mapManager = GameObject.Find("Map Manager").GetComponent<MapManager>();

        dir = (Direction)(transform.eulerAngles.z / 90);

        currentPosition = roomManager.transform.position / mapManager.offset;
        if(dir == Direction.Down) {
            nextPosition = new Vector2(currentPosition.x, currentPosition.y + 1);
        } else if(dir == Direction.Right) {
            nextPosition = new Vector2(currentPosition.x - 1, currentPosition.y);
        } else if(dir == Direction.Up) {
            nextPosition = new Vector2(currentPosition.x, currentPosition.y - 1);
        } else if(dir == Direction.Left) {
            nextPosition = new Vector2(currentPosition.x + 1, currentPosition.y);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        EnterDoor();
    }

    private void EnterDoor() {
        if((nextPosition.x > 0 && nextPosition.x < 15) && (nextPosition.y > 0 && nextPosition.y < 15)) {
            GameObject instance = mapManager.Grid.GetTile((int)nextPosition.x, (int)nextPosition.y).Instance;
            if(instance == null) {
                instance = Instantiate(mapManager.rooms[Random.Range(0, mapManager.rooms.Count)], new Vector3((int)nextPosition.x * mapManager.offset, (int)nextPosition.y * mapManager.offset, 0), Quaternion.identity);
                mapManager.Grid.GetTile((int)nextPosition.x, (int)nextPosition.y).Instance = instance;
            }

            Vector3 newPos = new Vector3();
            List<GameObject> doors = instance.GetComponent<RoomManager>().Doors;

            Vector3 offset = new Vector3(0.5f, 1, 0);

            switch(dir) {
                case Direction.Down:
                    newPos = doors[2].transform.position + new Vector3(0, offset.y, 0);
                    break;
                case Direction.Right:
                    newPos = doors[3].transform.position - new Vector3(offset.x, 0, 0);
                    break;
                case Direction.Up:
                    newPos = doors[0].transform.position - new Vector3(0, offset.y + 0.1f, 0);
                    break;
                case Direction.Left:
                    newPos = doors[1].transform.position + new Vector3(offset.x, 0, 0);
                    break;
            }
            mapManager.player.transform.position = newPos;
        }
    }

}
