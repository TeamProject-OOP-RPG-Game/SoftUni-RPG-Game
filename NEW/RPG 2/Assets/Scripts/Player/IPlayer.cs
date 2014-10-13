using UnityEngine;
using System.Collections;

public interface IPlayer : ICollidable {

    void IncreaseTime(int bonusTime);
    void IncreaseEnergy(int bonusEnergy);
    void IncreaseXP(int bonusXP);
    void IncreaseMoney(int bonusMoney);
    void IncreaseRequiredXP(int nextLevelRequiredXP);
    void IncreaseLevel();
    void IncreaseSpeed(int bonusSpeed);
    void OnTriggerEnter(Collider other);
    void OnTriggerExit(Collider other);
}
