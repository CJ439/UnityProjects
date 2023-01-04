using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    public int m_size;
    public int m_gallons;
    
    public void Fill(int gallons)
    {
        m_gallons += gallons;
        if (m_gallons > m_size)
            m_gallons = m_size;
    }
    public void Drain(int gallons)
    {
        if (m_gallons < 0)
            m_gallons = 0;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
