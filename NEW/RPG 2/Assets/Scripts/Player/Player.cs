using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour, IPlayer, ICollidable
{
    void Update()
    {
        
        if (isTriggered == true)
        {
            Debug.Log("Trigger Action");
        }
        isTriggered = false;
    }

    private string name;
    private int knowledge;
    private int time;
    private int money;
    private int energy;
    private int currentExperience;
    private int requiredExperience;
    private int level;
    private int speed;
    private bool isTriggered = false;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be null or empty!");
            }
            else if(value.Length < 3) {
                throw new ArgumentException("Name must be at least 3 symbols long!");
            }
        }
    }

    public int Knowledge
    {
        get
        {
            return this.knowledge;
        }

       private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Knowledge must be positive!");
            }

            this.knowledge = value;
        }
    }

    public int Time
    {
        get
        {
            return this.time;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Time must be positive!");
            }

            this.time = value;
        }
    }

    public int Money
    {
        get
        {
            return this.money;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Money cannot be negative!");
            }

            this.money = value;
        }
    }
    
    public int Energy
    {
        get
        {
            return this.energy;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Energy cannot be negative!");
            }

            this.energy = value;
        }
    }
    
    public int CurrentExperience
    {
        get
        {
            return this.currentExperience;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Experience cannot be negative!");
            }

            this.currentExperience = value;
        }
    }
    
    public int RequiredExperience
    {
        get
        {
            return this.requiredExperience;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Required Experience cannot be negative!");
            }

            this.requiredExperience = value;
        }
    }
    
    public int Level
    {
        get
        {
            return this.level;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Level cannot be negative!");
            }

            this.level = value;
        }
    }
    
    public int Speed
    {
        get
        {
            return this.speed;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Speed cannot be negative!");
            }

            this.speed = value;
        }
    }

    public void IncreaseTime(int bonusTime)
    {
        this.Time = this.Time += bonusTime;
    }
    public void IncreaseEnergy(int bonusEnergy)
    {
        this.Energy = this.Energy += bonusEnergy;
    }
    public void IncreaseXP(int bonusXP)
    {
        this.Energy = this.Energy += bonusXP;
    }
    public void IncreaseMoney(int bonusMoney)
    {
        this.Money = this.Money += bonusMoney;
    }
    public void IncreaseRequiredXP(int nextLevelRequiredXP)
    {
        this.RequiredExperience = this.RequiredExperience += nextLevelRequiredXP;
    }
    public void IncreaseLevel()
    {
        this.Level = this.Level++;
    }
    public void IncreaseSpeed(int bonusSpeed)
    {
        this.Speed += bonusSpeed;
    }

    public void OnTriggerEnter(Collider other)
    {
        //private bool touchingObj = false;


        switch (other.tag)
        {
            case "PickUpMoney": IncreaseMoney(100);
                break;
            case "PickUpEnergy": IncreaseEnergy(100);
                break;
            case "PickUpTime": IncreaseTime(100);
                break;
        }
        isTriggered = true;
        
    }

    public void OnTriggerExit(Collider other)
    {
        isTriggered = false;
    }
}
