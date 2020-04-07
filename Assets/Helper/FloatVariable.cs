using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public float initialValue;

    //Runtime Value
    [NonSerialized]
    public float Value;



    public void SetValue(float value)
    {
        Value = value;
    }

    public void SetValue(FloatVariable value)
    {
        Value = value.Value;
    }

    public void ApplyChange(float amount)
    {
        Value += amount;
    }

    public void ApplyChange(FloatVariable amount)
    {
        Value += amount.Value;
    }

    public void OnAfterDeserialize()
    {
        Value = initialValue;
    }

    public void OnBeforeSerialize()
    {

    }


}
