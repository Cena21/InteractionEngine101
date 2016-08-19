﻿using UnityEngine;

namespace Leap.Unity.Interaction {

  public abstract class IMoveToController : IControllerBase {
    public abstract void MoveTo(ReadonlyList<Hand> hands, PhysicsMoveInfo info, Vector3 solvedPosition, Quaternion solvedRotation);
    public abstract void SetGraspedState();
    public abstract void OnGraspBegin();
    public abstract void OnGraspEnd();
  }

  public struct PhysicsMoveInfo {
    public bool shouldTeleport;
    public float remainingDistanceLastFrame;
  }
}
