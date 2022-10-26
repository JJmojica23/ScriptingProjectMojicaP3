using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    public class AnotherClass
    {
        public int apples;
        public int bananas;

        private int stapler;
        private int sellotape;

        public void FruitMachine (int a, int b)
        {
            int answer;
            answer = a + b;
            Debug.Log("Fruit total; " + answer);
        }

        private void OfficeSort (int a, int b)
        {
            int answer;
            answer = a + b;
            Debug.Log("Office Supplies total: " + answer);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
        Debug.Log("Beta is set to: " + beta);
        Debug.Log("Gamma is set to: " + gamma);
    }
}
