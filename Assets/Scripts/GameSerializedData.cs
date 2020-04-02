using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSerializedData
{
    private  int _score=-1;
    private  int _calculationIndex=-1;
    private int _levelIndexToContinue = -1;
    private List<string> _rocketUnlocked=null;
    private string _userLoggedIn = null;
    public int Score {
        get {
            if (_score==-1) {
                DeserializeData();
            }
            return _score;
        }
        set {
            _score = value;
        }
    }
    public int CalculationIndex
    {
        get
        {
            if (_calculationIndex == -1)
            {
                DeserializeData();
            }
            return _calculationIndex;
        }
        set
        {
            _calculationIndex = value;
        }
    }

    public int LevelIndexToContinue
    {
        get
        {
            if (_levelIndexToContinue == -1)
            {
                DeserializeData();
            }
            return _levelIndexToContinue;
        }
        set
        {
            _levelIndexToContinue = value;
        }
    }

        public string UserLoggedIn
    {
        get
        {
            if (_userLoggedIn ==null)
            {
                DeserializeData();
            }
            return _userLoggedIn;
        }
        set
        {
            _userLoggedIn = value;
        }
    }

    public List<string> RocketUnlocked
    {
        get
        {
            if (_rocketUnlocked == null)
            {
                DeserializeData();
            }
            return _rocketUnlocked;
        }
    }

    private static void DeserializeData() { 
    
    }

    public static void SaveData() { 
    
    }
}
